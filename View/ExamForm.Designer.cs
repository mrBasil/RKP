namespace RKP.View
{
    partial class ExamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_unLoad = new System.Windows.Forms.Button();
            this.pb_loading = new System.Windows.Forms.ProgressBar();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_1);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 426);
            this.panel1.TabIndex = 0;
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(3, 0);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(766, 423);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_1.TabIndex = 0;
            this.pb_1.TabStop = false;
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(713, 469);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 25);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(632, 469);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 25);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(632, 498);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 25);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_unLoad
            // 
            this.btn_unLoad.Location = new System.Drawing.Point(632, 527);
            this.btn_unLoad.Name = "btn_unLoad";
            this.btn_unLoad.Size = new System.Drawing.Size(75, 25);
            this.btn_unLoad.TabIndex = 4;
            this.btn_unLoad.Text = "unLoad";
            this.btn_unLoad.UseVisualStyleBackColor = true;
            this.btn_unLoad.Click += new System.EventHandler(this.btn_unLoad_Click);
            // 
            // pb_loading
            // 
            this.pb_loading.Location = new System.Drawing.Point(22, 441);
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(763, 23);
            this.pb_loading.TabIndex = 5;
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(22, 471);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 6;
            this.btn_count.Text = "привести";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(22, 499);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.pb_loading);
            this.Controls.Add(this.btn_unLoad);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.panel1);
            this.Name = "ExamForm";
            this.Text = "Метрологический тест";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_unLoad;
        private System.Windows.Forms.ProgressBar pb_loading;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_save;
    }
}