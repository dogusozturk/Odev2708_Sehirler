namespace Odev2708Sehirler
{
    partial class Form1
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
            this.labelSehir = new System.Windows.Forms.Label();
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.labelIlce = new System.Windows.Forms.Label();
            this.comboBoxIlce = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSehir
            // 
            this.labelSehir.AutoSize = true;
            this.labelSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSehir.Location = new System.Drawing.Point(12, 50);
            this.labelSehir.Name = "labelSehir";
            this.labelSehir.Size = new System.Drawing.Size(47, 18);
            this.labelSehir.TabIndex = 0;
            this.labelSehir.Text = "Şehir";
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(65, 51);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSehir.TabIndex = 1;
            this.comboBoxSehir.SelectedIndexChanged += new System.EventHandler(this.comboBoxSehir_SelectedIndexChanged);
            // 
            // labelIlce
            // 
            this.labelIlce.AutoSize = true;
            this.labelIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIlce.Location = new System.Drawing.Point(12, 89);
            this.labelIlce.Name = "labelIlce";
            this.labelIlce.Size = new System.Drawing.Size(34, 18);
            this.labelIlce.TabIndex = 0;
            this.labelIlce.Text = "İlçe";
            // 
            // comboBoxIlce
            // 
            this.comboBoxIlce.FormattingEnabled = true;
            this.comboBoxIlce.Location = new System.Drawing.Point(65, 90);
            this.comboBoxIlce.Name = "comboBoxIlce";
            this.comboBoxIlce.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIlce.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.comboBoxIlce);
            this.Controls.Add(this.labelIlce);
            this.Controls.Add(this.comboBoxSehir);
            this.Controls.Add(this.labelSehir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSehir;
        private System.Windows.Forms.ComboBox comboBoxSehir;
        private System.Windows.Forms.Label labelIlce;
        private System.Windows.Forms.ComboBox comboBoxIlce;
    }
}

