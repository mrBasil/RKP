namespace RKP.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.баланНоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текучестьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькРезисторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_test = new System.Windows.Forms.Label();
            this.lb_main = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_res = new System.Windows.Forms.Label();
            this.lb_info = new System.Windows.Forms.Label();
            this.pb_load = new System.Windows.Forms.ProgressBar();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_unLoad = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lb_info_szm = new System.Windows.Forms.Label();
            this.lb_HZ = new System.Windows.Forms.Label();
            this.rBtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_4 = new System.Windows.Forms.RadioButton();
            this.rbtn_5 = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.инструкцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadCellToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCellToolStripMenuItem
            // 
            this.loadCellToolStripMenuItem.Name = "loadCellToolStripMenuItem";
            this.loadCellToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.loadCellToolStripMenuItem.Text = "LoadCell";
            this.loadCellToolStripMenuItem.Click += new System.EventHandler(this.loadCellToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem,
            this.баланНоляToolStripMenuItem,
            this.текучестьToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.оПрограммеToolStripMenuItem.Text = "Испытания";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторToolStripMenuItem.Text = "RKP";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // баланНоляToolStripMenuItem
            // 
            this.баланНоляToolStripMenuItem.Name = "баланНоляToolStripMenuItem";
            this.баланНоляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.баланНоляToolStripMenuItem.Text = "ZeroBalance";
            this.баланНоляToolStripMenuItem.Click += new System.EventHandler(this.баланНоляToolStripMenuItem_Click);
            // 
            // текучестьToolStripMenuItem
            // 
            this.текучестьToolStripMenuItem.Name = "текучестьToolStripMenuItem";
            this.текучестьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.текучестьToolStripMenuItem.Text = "Creeps";
            this.текучестьToolStripMenuItem.Click += new System.EventHandler(this.текучестьToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калькРезисторовToolStripMenuItem,
            this.logToolStripMenuItem});
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструкцияToolStripMenuItem.Text = "Инструменты";
            // 
            // калькРезисторовToolStripMenuItem
            // 
            this.калькРезисторовToolStripMenuItem.Name = "калькРезисторовToolStripMenuItem";
            this.калькРезисторовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.калькРезисторовToolStripMenuItem.Text = "Кальк. резисторов";
            this.калькРезисторовToolStripMenuItem.Click += new System.EventHandler(this.калькРезисторовToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_test);
            this.panel1.Controls.Add(this.lb_main);
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 146);
            this.panel1.TabIndex = 1;
            // 
            // lb_test
            // 
            this.lb_test.AutoSize = true;
            this.lb_test.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test.Location = new System.Drawing.Point(25, 82);
            this.lb_test.Name = "lb_test";
            this.lb_test.Size = new System.Drawing.Size(159, 43);
            this.lb_test.TabIndex = 1;
            this.lb_test.Text = "#######";
            this.lb_test.Click += new System.EventHandler(this.lb_test_Click);
            // 
            // lb_main
            // 
            this.lb_main.AutoSize = true;
            this.lb_main.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_main.Location = new System.Drawing.Point(25, 20);
            this.lb_main.Name = "lb_main";
            this.lb_main.Size = new System.Drawing.Size(159, 43);
            this.lb_main.TabIndex = 0;
            this.lb_main.Text = "#######";
            this.lb_main.Click += new System.EventHandler(this.lb_main_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lb_res);
            this.panel2.Location = new System.Drawing.Point(276, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 145);
            this.panel2.TabIndex = 2;
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_res.Location = new System.Drawing.Point(13, 13);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(63, 25);
            this.lb_res.TabIndex = 0;
            this.lb_res.Text = "0 Om";
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(12, 35);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(31, 13);
            this.lb_info.TabIndex = 3;
            this.lb_info.Text = "Info: ";
            this.lb_info.Click += new System.EventHandler(this.lb_info_Click);
            // 
            // pb_load
            // 
            this.pb_load.Location = new System.Drawing.Point(12, 213);
            this.pb_load.Name = "pb_load";
            this.pb_load.Size = new System.Drawing.Size(558, 23);
            this.pb_load.TabIndex = 4;
            // 
            // btn_set
            // 
            this.btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_set.Location = new System.Drawing.Point(576, 195);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(127, 41);
            this.btn_set.TabIndex = 5;
            this.btn_set.Text = "set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_load.Location = new System.Drawing.Point(578, 54);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(90, 38);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "+Наг";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_unLoad
            // 
            this.btn_unLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_unLoad.Location = new System.Drawing.Point(577, 154);
            this.btn_unLoad.Name = "btn_unLoad";
            this.btn_unLoad.Size = new System.Drawing.Size(90, 35);
            this.btn_unLoad.TabIndex = 7;
            this.btn_unLoad.Text = "-Раз";
            this.btn_unLoad.UseVisualStyleBackColor = true;
            this.btn_unLoad.Click += new System.EventHandler(this.btn_unLoad_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Red;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.Location = new System.Drawing.Point(576, 96);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(91, 53);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lb_info_szm
            // 
            this.lb_info_szm.AutoSize = true;
            this.lb_info_szm.Location = new System.Drawing.Point(576, 35);
            this.lb_info_szm.Name = "lb_info_szm";
            this.lb_info_szm.Size = new System.Drawing.Size(24, 13);
            this.lb_info_szm.TabIndex = 11;
            this.lb_info_szm.Text = "info";
            // 
            // lb_HZ
            // 
            this.lb_HZ.AutoSize = true;
            this.lb_HZ.Location = new System.Drawing.Point(672, 54);
            this.lb_HZ.Name = "lb_HZ";
            this.lb_HZ.Size = new System.Drawing.Size(22, 13);
            this.lb_HZ.TabIndex = 13;
            this.lb_HZ.Text = "HZ";
            // 
            // rBtn_1
            // 
            this.rBtn_1.AutoSize = true;
            this.rBtn_1.Location = new System.Drawing.Point(675, 75);
            this.rBtn_1.Name = "rBtn_1";
            this.rBtn_1.Size = new System.Drawing.Size(31, 17);
            this.rBtn_1.TabIndex = 15;
            this.rBtn_1.TabStop = true;
            this.rBtn_1.Text = "1";
            this.rBtn_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(675, 98);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(31, 17);
            this.rbtn_2.TabIndex = 16;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "2";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_3
            // 
            this.rbtn_3.AutoSize = true;
            this.rbtn_3.Location = new System.Drawing.Point(675, 121);
            this.rbtn_3.Name = "rbtn_3";
            this.rbtn_3.Size = new System.Drawing.Size(31, 17);
            this.rbtn_3.TabIndex = 17;
            this.rbtn_3.TabStop = true;
            this.rbtn_3.Text = "3";
            this.rbtn_3.UseVisualStyleBackColor = true;
            // 
            // rbtn_4
            // 
            this.rbtn_4.AutoSize = true;
            this.rbtn_4.Location = new System.Drawing.Point(675, 144);
            this.rbtn_4.Name = "rbtn_4";
            this.rbtn_4.Size = new System.Drawing.Size(31, 17);
            this.rbtn_4.TabIndex = 18;
            this.rbtn_4.TabStop = true;
            this.rbtn_4.Text = "4";
            this.rbtn_4.UseVisualStyleBackColor = true;
            // 
            // rbtn_5
            // 
            this.rbtn_5.AutoSize = true;
            this.rbtn_5.Location = new System.Drawing.Point(675, 167);
            this.rbtn_5.Name = "rbtn_5";
            this.rbtn_5.Size = new System.Drawing.Size(31, 17);
            this.rbtn_5.TabIndex = 19;
            this.rbtn_5.TabStop = true;
            this.rbtn_5.Text = "5";
            this.rbtn_5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 248);
            this.Controls.Add(this.rbtn_5);
            this.Controls.Add(this.rbtn_4);
            this.Controls.Add(this.rbtn_3);
            this.Controls.Add(this.rbtn_2);
            this.Controls.Add(this.rBtn_1);
            this.Controls.Add(this.lb_HZ);
            this.Controls.Add(this.lb_info_szm);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_unLoad);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.pb_load);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Настройка ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_test;
        private System.Windows.Forms.Label lb_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.ProgressBar pb_load;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_unLoad;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lb_info_szm;
        private System.Windows.Forms.ToolStripMenuItem баланНоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текучестьToolStripMenuItem;
        private System.Windows.Forms.Label lb_HZ;
        private System.Windows.Forms.RadioButton rBtn_1;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.RadioButton rbtn_3;
        private System.Windows.Forms.RadioButton rbtn_4;
        private System.Windows.Forms.RadioButton rbtn_5;
        private System.Windows.Forms.ToolStripMenuItem калькРезисторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
    }
}