using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using Hbm.Api.Mgc;
using Hbm.Api.Common;
using Hbm.Api.Common.Entities.Problems;
using Hbm.Api;
using Hbm.Api.Common.Entities.Channels;
using Hbm.Api.Common.Entities.Signals;
using Hbm.Api.Common.Entities;
using System.Threading;
using Hbm.Api.Common.Enums;
using Hbm.Api.SensorDB.Entities.Sensors;
using Hbm.Api.SensorDB.Entities;

namespace RKP.Data.Indik
{
    public class MGCPluse
    {
        /*Надо реализовать всю логику получения данных*/
        private DaqMeasurement _daqSession = null; // DAQ session
        private DaqEnvironment _daqEnv = null; // DAQ environment
        private List<Signal> _sessionSignals = null; // Registered measurement signals
        private bool measuring = false;

        private string ip;
        private int port;
        public MGCPluse(string IP, int port) 
        {
            ip = IP; ;
            this.port = port;

            _daqEnv = DaqEnvironment.GetInstance();
            _daqSession = new DaqMeasurement();
            _sessionSignals = new List<Signal>(); // To store our registered signals

            StartMeasuring();

        }

        private void StartMeasuring()
        {
            if (!measuring)
            {
               
                Device measDevice = new MgcDevice(ip, port);

                
                List<Problem> problems;
                bool isConnected = _daqEnv.Connect(measDevice, out problems);
                if (isConnected)
                {
                    var ch1 = measDevice.GetAllChannels()[1];



                    
                    Signal s1 = measDevice.Connectors[0].Channels[0].Signals[0];

                    Signal s2 = measDevice.Connectors[1].Channels[0].Signals[0];


                  
                    s1.SampleRate = 2400; // Hz

                    s2.SampleRate = 2400;

                    // We don't check problems list here
                    measDevice.AssignSignal(s1, out problems);
                    measDevice.AssignSignal(s2, out problems);
                    // Register first 2 signals for measurement session
                    _sessionSignals.Add(s1);
                    _sessionSignals.Add(s2);
                    _daqSession.AddSignals(measDevice, _sessionSignals);
                    // Prepare DAQ session. We only need 1
                    // single timestamp per block
                    _daqSession.PrepareDaq();

                    // ---- Start unsynchronized DAQ session ---------------
                    _daqSession.StartDaq(DataAcquisitionMode.Unsynchronized);

                    StartDataFetching(); // Start callback timer

                    // ------------------------------------------
                    // Stop Daq session after 5 seconds !!
                    
                    //StopDataFetching();
                    // ------------------------------------------
                    // Disconnect device
                    
                }
            }
            // Cleanup
            
        }

        /// <summary>
        /// Periodically fetch data
        /// </summary>
        /// <param name="o">Unused. Only needed because of delegate signature</param>
        private void FetchData(object o)
        {
            
            // Check if our session is running
            if (_daqSession.IsRunning)
            {
                // Transfer data into signal buffers, Keep in mind we only have 1 timestamp
                _daqSession.FillMeasurementValues();
                // Process data of each signal, e.g. store to file or show it in chart
                // For demonstration purposes we only show first value on console
                foreach (Signal s in _sessionSignals)
                {

                    MeasurementValues measVals = s.ContinuousMeasurementValues;

                    // Check for overrun
                    if (measVals.BufferOverrunOccurred)
                    {
                       // Console.WriteLine("Buffer overrun for signal {0}", s.Name);
                    }
                    // How many new values do we have ?
                    int newValuesCount = measVals.UpdatedValueCount;

                    //Console.WriteLine("{0} updated values {1}", s.Name, newValuesCount);
                    if (newValuesCount > 0)
                    {
                        // Show first data value
                        // In real world application we would take
                        // measVals.UpdatedValueCount from buffer
                        // --> measVals.Values[measVals.UpdatedValueCount-1]
                        double timestamp = measVals.Timestamps[0];

                        double value = measVals.Values[0];

                        switch (s.Name) {
                            case "C18/500kN #00287ILL":
                                etalon = Math.Round( value, 3);
                                break;
                            case "UUVZ LC":
                                test = Math.Round( value/5, 4);
                                break;
                        }
                       // Console.WriteLine("value: {0} : {1}", timestamp, value);
                    }
                    else
                    {
                        // We don't have values
                        Console.WriteLine("No values for signal: {0}", s.Name);
                    }
                }
            }
        }
        private void StartDataFetching()
        {
            // Data fetching every 100ms
            measuring = true;
            if (measuring) {
                Console.WriteLine("Стартую");
            }
           Task.Run(() => {

                while (measuring) {
                   Task.Delay(200);
                    FetchData(null);
                   measuring = Program.work;
                }
               _daqSession.StopDaq();
           });
            
            
            // Stop our DAQ session
            

        }
        void StopDataFetching()
        {
            measuring = false;
           
            // Stop our DAQ session
            _daqSession.StopDaq();
            
        }


        public double etalon { get; set; }
        public double test { get; set; }


    }
}
