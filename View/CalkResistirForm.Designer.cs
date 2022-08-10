namespace RKP.View
{
    partial class CalkResistirForm
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.lb_itog = new System.Windows.Forms.Label();
            this.num_r1 = new System.Windows.Forms.NumericUpDown();
            this.num_r2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_r1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_r2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(181, 21);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 46);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calc";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lb_itog
            // 
            this.lb_itog.AutoSize = true;
            this.lb_itog.Location = new System.Drawing.Point(119, 90);
            this.lb_itog.Name = "lb_itog";
            this.lb_itog.Size = new System.Drawing.Size(42, 13);
            this.lb_itog.TabIndex = 1;
            this.lb_itog.Text = "#####";
            // 
            // num_r1
            // 
            this.num_r1.Location = new System.Drawing.Point(12, 21);
            this.num_r1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_r1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_r1.Name = "num_r1";
            this.num_r1.Size = new System.Drawing.Size(120, 20);
            this.num_r1.TabIndex = 2;
            this.num_r1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_r2
            // 
            this.num_r2.Location = new System.Drawing.Point(12, 47);
            this.num_r2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_r2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_r2.Name = "num_r2";
            this.num_r2.Size = new System.Drawing.Size(120, 20);
            this.num_r2.TabIndex = 3;
            this.num_r2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Om";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Om";
            // 
            // CalkResistirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_r2);
            this.Controls.Add(this.num_r1);
            this.Controls.Add(this.lb_itog);
            this.Controls.Add(this.btn_calc);
            this.Name = "CalkResistirForm";
            this.Text = "Пара. сопр.";
            ((System.ComponentModel.ISupportInitialize)(this.num_r1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_r2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lb_itog;
        private System.Windows.Forms.NumericUpDown num_r1;
        private System.Windows.Forms.NumericUpDown num_r2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}