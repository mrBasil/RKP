namespace RKP.View
{
    partial class BalanceZeroBridgeForms
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
            this.btn_set = new System.Windows.Forms.Button();
            this.lb_itog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(130, 157);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 42);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "SET";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // lb_itog
            // 
            this.lb_itog.AutoSize = true;
            this.lb_itog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_itog.Location = new System.Drawing.Point(12, 68);
            this.lb_itog.Name = "lb_itog";
            this.lb_itog.Size = new System.Drawing.Size(89, 31);
            this.lb_itog.TabIndex = 1;
            this.lb_itog.Text = "#####";
            // 
            // BalanceZeroBridgeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 211);
            this.Controls.Add(this.lb_itog);
            this.Controls.Add(this.btn_set);
            this.Name = "BalanceZeroBridgeForms";
            this.Text = "Баланс ноля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_set;
        protected System.Windows.Forms.Label lb_itog;
    }
}