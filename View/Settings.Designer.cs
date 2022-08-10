namespace RKP.View
{
    partial class Settings
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
            this.tp_settings = new System.Windows.Forms.TabControl();
            this.tp_etalon = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.num_adres_e = new System.Windows.Forms.NumericUpDown();
            this.comboBox_device_e = new System.Windows.Forms.ComboBox();
            this.cb_shinaRS_e = new System.Windows.Forms.CheckBox();
            this.btn_save_etalon = new System.Windows.Forms.Button();
            this.comboBox_stopBits_e = new System.Windows.Forms.ComboBox();
            this.comboBox_parity_e = new System.Windows.Forms.ComboBox();
            this.comboBox_BitSize_e = new System.Windows.Forms.ComboBox();
            this.comBox_baudRete_e = new System.Windows.Forms.ComboBox();
            this.comboBox_com_e = new System.Windows.Forms.ComboBox();
            this.tp_test = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.num_adres_t = new System.Windows.Forms.NumericUpDown();
            this.comboBox_device_t = new System.Windows.Forms.ComboBox();
            this.btn_save_test = new System.Windows.Forms.Button();
            this.comboBox_stopBits_t = new System.Windows.Forms.ComboBox();
            this.comboBox_parity_t = new System.Windows.Forms.ComboBox();
            this.comboBox_BitSize_t = new System.Windows.Forms.ComboBox();
            this.comBox_baudRete_t = new System.Windows.Forms.ComboBox();
            this.comboBox_com_t = new System.Windows.Forms.ComboBox();
            this.tp_db = new System.Windows.Forms.TabPage();
            this.btn_save_db = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.tp_peref = new System.Windows.Forms.TabPage();
            this.cb_shinaRS_p = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num_adres_p = new System.Windows.Forms.NumericUpDown();
            this.comboBox_device_p = new System.Windows.Forms.ComboBox();
            this.btn_save_p = new System.Windows.Forms.Button();
            this.comboBox_stopBits_p = new System.Windows.Forms.ComboBox();
            this.comboBox_parity_p = new System.Windows.Forms.ComboBox();
            this.comboBox_BitSize_p = new System.Windows.Forms.ComboBox();
            this.comBox_baudRete_p = new System.Windows.Forms.ComboBox();
            this.comboBox_com_p = new System.Windows.Forms.ComboBox();
            this.cb_shinaRS_t = new System.Windows.Forms.CheckBox();
            this.tp_config = new System.Windows.Forms.TabPage();
            this.cb_have_etalon = new System.Windows.Forms.CheckBox();
            this.cb_have_test = new System.Windows.Forms.CheckBox();
            this.cb_have_peref = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tp_settings.SuspendLayout();
            this.tp_etalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_e)).BeginInit();
            this.tp_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_t)).BeginInit();
            this.tp_db.SuspendLayout();
            this.tp_peref.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_p)).BeginInit();
            this.tp_config.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_settings
            // 
            this.tp_settings.Controls.Add(this.tp_config);
            this.tp_settings.Controls.Add(this.tp_etalon);
            this.tp_settings.Controls.Add(this.tp_test);
            this.tp_settings.Controls.Add(this.tp_peref);
            this.tp_settings.Controls.Add(this.tp_db);
            this.tp_settings.Location = new System.Drawing.Point(12, 12);
            this.tp_settings.Multiline = true;
            this.tp_settings.Name = "tp_settings";
            this.tp_settings.SelectedIndex = 0;
            this.tp_settings.Size = new System.Drawing.Size(373, 190);
            this.tp_settings.TabIndex = 5;
            // 
            // tp_etalon
            // 
            this.tp_etalon.Controls.Add(this.label4);
            this.tp_etalon.Controls.Add(this.num_adres_e);
            this.tp_etalon.Controls.Add(this.comboBox_device_e);
            this.tp_etalon.Controls.Add(this.cb_shinaRS_e);
            this.tp_etalon.Controls.Add(this.btn_save_etalon);
            this.tp_etalon.Controls.Add(this.comboBox_stopBits_e);
            this.tp_etalon.Controls.Add(this.comboBox_parity_e);
            this.tp_etalon.Controls.Add(this.comboBox_BitSize_e);
            this.tp_etalon.Controls.Add(this.comBox_baudRete_e);
            this.tp_etalon.Controls.Add(this.comboBox_com_e);
            this.tp_etalon.Location = new System.Drawing.Point(4, 22);
            this.tp_etalon.Name = "tp_etalon";
            this.tp_etalon.Padding = new System.Windows.Forms.Padding(3);
            this.tp_etalon.Size = new System.Drawing.Size(365, 164);
            this.tp_etalon.TabIndex = 0;
            this.tp_etalon.Text = "Эталон";
            this.tp_etalon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "адрес";
            // 
            // num_adres_e
            // 
            this.num_adres_e.Location = new System.Drawing.Point(57, 108);
            this.num_adres_e.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.num_adres_e.Name = "num_adres_e";
            this.num_adres_e.Size = new System.Drawing.Size(41, 20);
            this.num_adres_e.TabIndex = 14;
            // 
            // comboBox_device_e
            // 
            this.comboBox_device_e.FormattingEnabled = true;
            this.comboBox_device_e.Location = new System.Drawing.Point(13, 78);
            this.comboBox_device_e.Name = "comboBox_device_e";
            this.comboBox_device_e.Size = new System.Drawing.Size(85, 21);
            this.comboBox_device_e.TabIndex = 13;
            // 
            // cb_shinaRS_e
            // 
            this.cb_shinaRS_e.AutoSize = true;
            this.cb_shinaRS_e.Location = new System.Drawing.Point(13, 17);
            this.cb_shinaRS_e.Name = "cb_shinaRS_e";
            this.cb_shinaRS_e.Size = new System.Drawing.Size(89, 17);
            this.cb_shinaRS_e.TabIndex = 12;
            this.cb_shinaRS_e.Text = "Шина RS485";
            this.cb_shinaRS_e.UseVisualStyleBackColor = true;
            // 
            // btn_save_etalon
            // 
            this.btn_save_etalon.Location = new System.Drawing.Point(138, 124);
            this.btn_save_etalon.Name = "btn_save_etalon";
            this.btn_save_etalon.Size = new System.Drawing.Size(75, 23);
            this.btn_save_etalon.TabIndex = 11;
            this.btn_save_etalon.Text = "Сохранить";
            this.btn_save_etalon.UseVisualStyleBackColor = true;
            this.btn_save_etalon.Click += new System.EventHandler(this.btn_save_etalon_Click);
            // 
            // comboBox_stopBits_e
            // 
            this.comboBox_stopBits_e.FormattingEnabled = true;
            this.comboBox_stopBits_e.Location = new System.Drawing.Point(306, 51);
            this.comboBox_stopBits_e.Name = "comboBox_stopBits_e";
            this.comboBox_stopBits_e.Size = new System.Drawing.Size(47, 21);
            this.comboBox_stopBits_e.TabIndex = 9;
            // 
            // comboBox_parity_e
            // 
            this.comboBox_parity_e.FormattingEnabled = true;
            this.comboBox_parity_e.Location = new System.Drawing.Point(247, 51);
            this.comboBox_parity_e.Name = "comboBox_parity_e";
            this.comboBox_parity_e.Size = new System.Drawing.Size(53, 21);
            this.comboBox_parity_e.TabIndex = 8;
            // 
            // comboBox_BitSize_e
            // 
            this.comboBox_BitSize_e.FormattingEnabled = true;
            this.comboBox_BitSize_e.Location = new System.Drawing.Point(182, 51);
            this.comboBox_BitSize_e.Name = "comboBox_BitSize_e";
            this.comboBox_BitSize_e.Size = new System.Drawing.Size(59, 21);
            this.comboBox_BitSize_e.TabIndex = 7;
            // 
            // comBox_baudRete_e
            // 
            this.comBox_baudRete_e.FormattingEnabled = true;
            this.comBox_baudRete_e.Location = new System.Drawing.Point(104, 51);
            this.comBox_baudRete_e.Name = "comBox_baudRete_e";
            this.comBox_baudRete_e.Size = new System.Drawing.Size(72, 21);
            this.comBox_baudRete_e.TabIndex = 6;
            // 
            // comboBox_com_e
            // 
            this.comboBox_com_e.FormattingEnabled = true;
            this.comboBox_com_e.Location = new System.Drawing.Point(13, 51);
            this.comboBox_com_e.Name = "comboBox_com_e";
            this.comboBox_com_e.Size = new System.Drawing.Size(85, 21);
            this.comboBox_com_e.TabIndex = 5;
            // 
            // tp_test
            // 
            this.tp_test.Controls.Add(this.cb_shinaRS_t);
            this.tp_test.Controls.Add(this.label5);
            this.tp_test.Controls.Add(this.num_adres_t);
            this.tp_test.Controls.Add(this.comboBox_device_t);
            this.tp_test.Controls.Add(this.btn_save_test);
            this.tp_test.Controls.Add(this.comboBox_stopBits_t);
            this.tp_test.Controls.Add(this.comboBox_parity_t);
            this.tp_test.Controls.Add(this.comboBox_BitSize_t);
            this.tp_test.Controls.Add(this.comBox_baudRete_t);
            this.tp_test.Controls.Add(this.comboBox_com_t);
            this.tp_test.Location = new System.Drawing.Point(4, 22);
            this.tp_test.Name = "tp_test";
            this.tp_test.Padding = new System.Windows.Forms.Padding(3);
            this.tp_test.Size = new System.Drawing.Size(365, 164);
            this.tp_test.TabIndex = 1;
            this.tp_test.Text = "Испытуемый";
            this.tp_test.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "адрес";
            // 
            // num_adres_t
            // 
            this.num_adres_t.Location = new System.Drawing.Point(57, 105);
            this.num_adres_t.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.num_adres_t.Name = "num_adres_t";
            this.num_adres_t.Size = new System.Drawing.Size(41, 20);
            this.num_adres_t.TabIndex = 17;
            // 
            // comboBox_device_t
            // 
            this.comboBox_device_t.FormattingEnabled = true;
            this.comboBox_device_t.Location = new System.Drawing.Point(13, 78);
            this.comboBox_device_t.Name = "comboBox_device_t";
            this.comboBox_device_t.Size = new System.Drawing.Size(85, 21);
            this.comboBox_device_t.TabIndex = 16;
            // 
            // btn_save_test
            // 
            this.btn_save_test.Location = new System.Drawing.Point(138, 124);
            this.btn_save_test.Name = "btn_save_test";
            this.btn_save_test.Size = new System.Drawing.Size(75, 23);
            this.btn_save_test.TabIndex = 15;
            this.btn_save_test.Text = "Сохранить";
            this.btn_save_test.UseVisualStyleBackColor = true;
            this.btn_save_test.Click += new System.EventHandler(this.btn_save_test_Click);
            // 
            // comboBox_stopBits_t
            // 
            this.comboBox_stopBits_t.FormattingEnabled = true;
            this.comboBox_stopBits_t.Location = new System.Drawing.Point(306, 51);
            this.comboBox_stopBits_t.Name = "comboBox_stopBits_t";
            this.comboBox_stopBits_t.Size = new System.Drawing.Size(47, 21);
            this.comboBox_stopBits_t.TabIndex = 14;
            // 
            // comboBox_parity_t
            // 
            this.comboBox_parity_t.FormattingEnabled = true;
            this.comboBox_parity_t.Location = new System.Drawing.Point(247, 51);
            this.comboBox_parity_t.Name = "comboBox_parity_t";
            this.comboBox_parity_t.Size = new System.Drawing.Size(53, 21);
            this.comboBox_parity_t.TabIndex = 13;
            // 
            // comboBox_BitSize_t
            // 
            this.comboBox_BitSize_t.FormattingEnabled = true;
            this.comboBox_BitSize_t.Location = new System.Drawing.Point(182, 51);
            this.comboBox_BitSize_t.Name = "comboBox_BitSize_t";
            this.comboBox_BitSize_t.Size = new System.Drawing.Size(59, 21);
            this.comboBox_BitSize_t.TabIndex = 12;
            // 
            // comBox_baudRete_t
            // 
            this.comBox_baudRete_t.FormattingEnabled = true;
            this.comBox_baudRete_t.Location = new System.Drawing.Point(104, 51);
            this.comBox_baudRete_t.Name = "comBox_baudRete_t";
            this.comBox_baudRete_t.Size = new System.Drawing.Size(72, 21);
            this.comBox_baudRete_t.TabIndex = 11;
            // 
            // comboBox_com_t
            // 
            this.comboBox_com_t.FormattingEnabled = true;
            this.comboBox_com_t.Location = new System.Drawing.Point(13, 51);
            this.comboBox_com_t.Name = "comboBox_com_t";
            this.comboBox_com_t.Size = new System.Drawing.Size(85, 21);
            this.comboBox_com_t.TabIndex = 10;
            // 
            // tp_db
            // 
            this.tp_db.Controls.Add(this.btn_save_db);
            this.tp_db.Controls.Add(this.label3);
            this.tp_db.Controls.Add(this.textBox_path);
            this.tp_db.Controls.Add(this.label2);
            this.tp_db.Controls.Add(this.textBox_port);
            this.tp_db.Controls.Add(this.label1);
            this.tp_db.Controls.Add(this.textBox_IP);
            this.tp_db.Location = new System.Drawing.Point(4, 22);
            this.tp_db.Name = "tp_db";
            this.tp_db.Padding = new System.Windows.Forms.Padding(3);
            this.tp_db.Size = new System.Drawing.Size(365, 164);
            this.tp_db.TabIndex = 2;
            this.tp_db.Text = "Бза данных";
            this.tp_db.UseVisualStyleBackColor = true;
            // 
            // btn_save_db
            // 
            this.btn_save_db.Location = new System.Drawing.Point(138, 124);
            this.btn_save_db.Name = "btn_save_db";
            this.btn_save_db.Size = new System.Drawing.Size(75, 23);
            this.btn_save_db.TabIndex = 6;
            this.btn_save_db.Text = "Сохранить";
            this.btn_save_db.UseVisualStyleBackColor = true;
            this.btn_save_db.Click += new System.EventHandler(this.btn_save_db_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(45, 71);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(314, 20);
            this.textBox_path.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(45, 45);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(76, 20);
            this.textBox_port.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(45, 19);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(204, 20);
            this.textBox_IP.TabIndex = 0;
            // 
            // tp_peref
            // 
            this.tp_peref.Controls.Add(this.cb_shinaRS_p);
            this.tp_peref.Controls.Add(this.label6);
            this.tp_peref.Controls.Add(this.num_adres_p);
            this.tp_peref.Controls.Add(this.comboBox_device_p);
            this.tp_peref.Controls.Add(this.btn_save_p);
            this.tp_peref.Controls.Add(this.comboBox_stopBits_p);
            this.tp_peref.Controls.Add(this.comboBox_parity_p);
            this.tp_peref.Controls.Add(this.comboBox_BitSize_p);
            this.tp_peref.Controls.Add(this.comBox_baudRete_p);
            this.tp_peref.Controls.Add(this.comboBox_com_p);
            this.tp_peref.Location = new System.Drawing.Point(4, 22);
            this.tp_peref.Name = "tp_peref";
            this.tp_peref.Padding = new System.Windows.Forms.Padding(3);
            this.tp_peref.Size = new System.Drawing.Size(365, 164);
            this.tp_peref.TabIndex = 3;
            this.tp_peref.Text = "Переферия";
            this.tp_peref.UseVisualStyleBackColor = true;
            // 
            // cb_shinaRS_p
            // 
            this.cb_shinaRS_p.AutoSize = true;
            this.cb_shinaRS_p.Location = new System.Drawing.Point(14, 11);
            this.cb_shinaRS_p.Name = "cb_shinaRS_p";
            this.cb_shinaRS_p.Size = new System.Drawing.Size(89, 17);
            this.cb_shinaRS_p.TabIndex = 29;
            this.cb_shinaRS_p.Text = "Шина RS485";
            this.cb_shinaRS_p.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "адрес";
            // 
            // num_adres_p
            // 
            this.num_adres_p.Location = new System.Drawing.Point(58, 88);
            this.num_adres_p.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.num_adres_p.Name = "num_adres_p";
            this.num_adres_p.Size = new System.Drawing.Size(41, 20);
            this.num_adres_p.TabIndex = 26;
            // 
            // comboBox_device_p
            // 
            this.comboBox_device_p.FormattingEnabled = true;
            this.comboBox_device_p.Location = new System.Drawing.Point(14, 61);
            this.comboBox_device_p.Name = "comboBox_device_p";
            this.comboBox_device_p.Size = new System.Drawing.Size(85, 21);
            this.comboBox_device_p.TabIndex = 25;
            // 
            // btn_save_p
            // 
            this.btn_save_p.Location = new System.Drawing.Point(139, 107);
            this.btn_save_p.Name = "btn_save_p";
            this.btn_save_p.Size = new System.Drawing.Size(75, 23);
            this.btn_save_p.TabIndex = 24;
            this.btn_save_p.Text = "Сохранить";
            this.btn_save_p.UseVisualStyleBackColor = true;
            this.btn_save_p.Click += new System.EventHandler(this.btn_save_p_Click);
            // 
            // comboBox_stopBits_p
            // 
            this.comboBox_stopBits_p.FormattingEnabled = true;
            this.comboBox_stopBits_p.Location = new System.Drawing.Point(307, 34);
            this.comboBox_stopBits_p.Name = "comboBox_stopBits_p";
            this.comboBox_stopBits_p.Size = new System.Drawing.Size(47, 21);
            this.comboBox_stopBits_p.TabIndex = 23;
            // 
            // comboBox_parity_p
            // 
            this.comboBox_parity_p.FormattingEnabled = true;
            this.comboBox_parity_p.Location = new System.Drawing.Point(248, 34);
            this.comboBox_parity_p.Name = "comboBox_parity_p";
            this.comboBox_parity_p.Size = new System.Drawing.Size(53, 21);
            this.comboBox_parity_p.TabIndex = 22;
            // 
            // comboBox_BitSize_p
            // 
            this.comboBox_BitSize_p.FormattingEnabled = true;
            this.comboBox_BitSize_p.Location = new System.Drawing.Point(183, 34);
            this.comboBox_BitSize_p.Name = "comboBox_BitSize_p";
            this.comboBox_BitSize_p.Size = new System.Drawing.Size(59, 21);
            this.comboBox_BitSize_p.TabIndex = 21;
            // 
            // comBox_baudRete_p
            // 
            this.comBox_baudRete_p.FormattingEnabled = true;
            this.comBox_baudRete_p.Location = new System.Drawing.Point(105, 34);
            this.comBox_baudRete_p.Name = "comBox_baudRete_p";
            this.comBox_baudRete_p.Size = new System.Drawing.Size(72, 21);
            this.comBox_baudRete_p.TabIndex = 20;
            // 
            // comboBox_com_p
            // 
            this.comboBox_com_p.FormattingEnabled = true;
            this.comboBox_com_p.Location = new System.Drawing.Point(14, 34);
            this.comboBox_com_p.Name = "comboBox_com_p";
            this.comboBox_com_p.Size = new System.Drawing.Size(85, 21);
            this.comboBox_com_p.TabIndex = 19;
            // 
            // cb_shinaRS_t
            // 
            this.cb_shinaRS_t.AutoSize = true;
            this.cb_shinaRS_t.Location = new System.Drawing.Point(13, 18);
            this.cb_shinaRS_t.Name = "cb_shinaRS_t";
            this.cb_shinaRS_t.Size = new System.Drawing.Size(89, 17);
            this.cb_shinaRS_t.TabIndex = 19;
            this.cb_shinaRS_t.Text = "Шина RS485";
            this.cb_shinaRS_t.UseVisualStyleBackColor = true;
            // 
            // tp_config
            // 
            this.tp_config.Controls.Add(this.label7);
            this.tp_config.Controls.Add(this.cb_have_peref);
            this.tp_config.Controls.Add(this.cb_have_test);
            this.tp_config.Controls.Add(this.cb_have_etalon);
            this.tp_config.Location = new System.Drawing.Point(4, 22);
            this.tp_config.Name = "tp_config";
            this.tp_config.Size = new System.Drawing.Size(365, 164);
            this.tp_config.TabIndex = 4;
            this.tp_config.Text = "Конфигурация";
            this.tp_config.UseVisualStyleBackColor = true;
            // 
            // cb_have_etalon
            // 
            this.cb_have_etalon.AutoSize = true;
            this.cb_have_etalon.Location = new System.Drawing.Point(106, 55);
            this.cb_have_etalon.Name = "cb_have_etalon";
            this.cb_have_etalon.Size = new System.Drawing.Size(119, 17);
            this.cb_have_etalon.TabIndex = 0;
            this.cb_have_etalon.Text = "Эталонный датчик";
            this.cb_have_etalon.UseVisualStyleBackColor = true;
            // 
            // cb_have_test
            // 
            this.cb_have_test.AutoSize = true;
            this.cb_have_test.Location = new System.Drawing.Point(106, 79);
            this.cb_have_test.Name = "cb_have_test";
            this.cb_have_test.Size = new System.Drawing.Size(129, 17);
            this.cb_have_test.TabIndex = 1;
            this.cb_have_test.Text = "Испытуемый датчик";
            this.cb_have_test.UseVisualStyleBackColor = true;
            // 
            // cb_have_peref
            // 
            this.cb_have_peref.AutoSize = true;
            this.cb_have_peref.Location = new System.Drawing.Point(106, 103);
            this.cb_have_peref.Name = "cb_have_peref";
            this.cb_have_peref.Size = new System.Drawing.Size(175, 17);
            this.cb_have_peref.TabIndex = 2;
            this.cb_have_peref.Text = "Исполнительные механизмы";
            this.cb_have_peref.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Выбор конфигурации";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 215);
            this.Controls.Add(this.tp_settings);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tp_settings.ResumeLayout(false);
            this.tp_etalon.ResumeLayout(false);
            this.tp_etalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_e)).EndInit();
            this.tp_test.ResumeLayout(false);
            this.tp_test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_t)).EndInit();
            this.tp_db.ResumeLayout(false);
            this.tp_db.PerformLayout();
            this.tp_peref.ResumeLayout(false);
            this.tp_peref.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_adres_p)).EndInit();
            this.tp_config.ResumeLayout(false);
            this.tp_config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tp_settings;
        private System.Windows.Forms.TabPage tp_etalon;
        private System.Windows.Forms.ComboBox comboBox_stopBits_e;
        private System.Windows.Forms.ComboBox comboBox_parity_e;
        private System.Windows.Forms.ComboBox comboBox_BitSize_e;
        private System.Windows.Forms.ComboBox comBox_baudRete_e;
        private System.Windows.Forms.ComboBox comboBox_com_e;
        private System.Windows.Forms.TabPage tp_test;
        private System.Windows.Forms.Button btn_save_etalon;
        private System.Windows.Forms.Button btn_save_test;
        private System.Windows.Forms.ComboBox comboBox_stopBits_t;
        private System.Windows.Forms.ComboBox comboBox_parity_t;
        private System.Windows.Forms.ComboBox comboBox_BitSize_t;
        private System.Windows.Forms.ComboBox comBox_baudRete_t;
        private System.Windows.Forms.ComboBox comboBox_com_t;
        private System.Windows.Forms.CheckBox cb_shinaRS_e;
        private System.Windows.Forms.TabPage tp_db;
        private System.Windows.Forms.Button btn_save_db;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.ComboBox comboBox_device_e;
        private System.Windows.Forms.ComboBox comboBox_device_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_adres_e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_adres_t;
        private System.Windows.Forms.TabPage tp_peref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_adres_p;
        private System.Windows.Forms.ComboBox comboBox_device_p;
        private System.Windows.Forms.Button btn_save_p;
        private System.Windows.Forms.ComboBox comboBox_stopBits_p;
        private System.Windows.Forms.ComboBox comboBox_parity_p;
        private System.Windows.Forms.ComboBox comboBox_BitSize_p;
        private System.Windows.Forms.ComboBox comBox_baudRete_p;
        private System.Windows.Forms.ComboBox comboBox_com_p;
        private System.Windows.Forms.CheckBox cb_shinaRS_p;
        private System.Windows.Forms.TabPage tp_config;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_have_peref;
        private System.Windows.Forms.CheckBox cb_have_test;
        private System.Windows.Forms.CheckBox cb_have_etalon;
        private System.Windows.Forms.CheckBox cb_shinaRS_t;
    }
}