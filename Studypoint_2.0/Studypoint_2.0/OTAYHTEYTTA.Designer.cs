namespace Studypoint_2._0
{
    partial class OTA_YHTEYTTA_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.viestiLB = new System.Windows.Forms.Label();
            this.viestiTB = new System.Windows.Forms.TextBox();
            this.lahetaBT = new System.Windows.Forms.Button();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.sahkopostiTB = new System.Windows.Forms.TextBox();
            this.puhelinnumeroLB = new System.Windows.Forms.Label();
            this.sahkopostiLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.viestiLB);
            this.groupBox1.Controls.Add(this.viestiTB);
            this.groupBox1.Controls.Add(this.lahetaBT);
            this.groupBox1.Controls.Add(this.puhelinTB);
            this.groupBox1.Controls.Add(this.sahkopostiTB);
            this.groupBox1.Controls.Add(this.puhelinnumeroLB);
            this.groupBox1.Controls.Add(this.sahkopostiLB);
            this.groupBox1.Location = new System.Drawing.Point(297, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ota yhteyttä";
            // 
            // viestiLB
            // 
            this.viestiLB.AutoSize = true;
            this.viestiLB.Location = new System.Drawing.Point(84, 192);
            this.viestiLB.Name = "viestiLB";
            this.viestiLB.Size = new System.Drawing.Size(52, 20);
            this.viestiLB.TabIndex = 11;
            this.viestiLB.Text = "Viesti:";
            // 
            // viestiTB
            // 
            this.viestiTB.Location = new System.Drawing.Point(80, 220);
            this.viestiTB.Multiline = true;
            this.viestiTB.Name = "viestiTB";
            this.viestiTB.Size = new System.Drawing.Size(390, 145);
            this.viestiTB.TabIndex = 10;
            // 
            // lahetaBT
            // 
            this.lahetaBT.Location = new System.Drawing.Point(174, 400);
            this.lahetaBT.Name = "lahetaBT";
            this.lahetaBT.Size = new System.Drawing.Size(199, 53);
            this.lahetaBT.TabIndex = 9;
            this.lahetaBT.Text = "Lähetä";
            this.lahetaBT.UseVisualStyleBackColor = true;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Location = new System.Drawing.Point(80, 142);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.PasswordChar = '*';
            this.puhelinTB.Size = new System.Drawing.Size(268, 26);
            this.puhelinTB.TabIndex = 8;
            // 
            // sahkopostiTB
            // 
            this.sahkopostiTB.Location = new System.Drawing.Point(80, 67);
            this.sahkopostiTB.Name = "sahkopostiTB";
            this.sahkopostiTB.Size = new System.Drawing.Size(268, 26);
            this.sahkopostiTB.TabIndex = 7;
            // 
            // puhelinnumeroLB
            // 
            this.puhelinnumeroLB.AutoSize = true;
            this.puhelinnumeroLB.Location = new System.Drawing.Point(85, 116);
            this.puhelinnumeroLB.Name = "puhelinnumeroLB";
            this.puhelinnumeroLB.Size = new System.Drawing.Size(65, 20);
            this.puhelinnumeroLB.TabIndex = 6;
            this.puhelinnumeroLB.Text = "Puhelin:";
            // 
            // sahkopostiLB
            // 
            this.sahkopostiLB.AutoSize = true;
            this.sahkopostiLB.Location = new System.Drawing.Point(81, 32);
            this.sahkopostiLB.Name = "sahkopostiLB";
            this.sahkopostiLB.Size = new System.Drawing.Size(93, 20);
            this.sahkopostiLB.TabIndex = 5;
            this.sahkopostiLB.Text = "Sähköposti:";
            // 
            // OTA_YHTEYTTA_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studypoint_2._0.Properties.Resources.technology_background_1632715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox1);
            this.Name = "OTA_YHTEYTTA_UserControl";
            this.Size = new System.Drawing.Size(1332, 785);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label viestiLB;
        private System.Windows.Forms.TextBox viestiTB;
        private System.Windows.Forms.Button lahetaBT;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.TextBox sahkopostiTB;
        private System.Windows.Forms.Label puhelinnumeroLB;
        private System.Windows.Forms.Label sahkopostiLB;
    }
}
