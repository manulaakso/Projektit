namespace Studypoint_2._0
{
    partial class KIRJAUDU
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
            this.KirjauduGB = new System.Windows.Forms.GroupBox();
            this.KirjauduBT01 = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajatnsTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EtusivuBT01 = new System.Windows.Forms.Button();
            this.KirjauduGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // KirjauduGB
            // 
            this.KirjauduGB.BackColor = System.Drawing.Color.SteelBlue;
            this.KirjauduGB.Controls.Add(this.KirjauduBT01);
            this.KirjauduGB.Controls.Add(this.SalasanaTB);
            this.KirjauduGB.Controls.Add(this.KayttajatnsTB);
            this.KirjauduGB.Controls.Add(this.label2);
            this.KirjauduGB.Controls.Add(this.label1);
            this.KirjauduGB.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduGB.Location = new System.Drawing.Point(297, 160);
            this.KirjauduGB.Margin = new System.Windows.Forms.Padding(0);
            this.KirjauduGB.Name = "KirjauduGB";
            this.KirjauduGB.Padding = new System.Windows.Forms.Padding(0);
            this.KirjauduGB.Size = new System.Drawing.Size(541, 471);
            this.KirjauduGB.TabIndex = 0;
            this.KirjauduGB.TabStop = false;
            this.KirjauduGB.Text = "Kirjaudu sisään";
            // 
            // KirjauduBT01
            // 
            this.KirjauduBT01.Location = new System.Drawing.Point(161, 281);
            this.KirjauduBT01.Name = "KirjauduBT01";
            this.KirjauduBT01.Size = new System.Drawing.Size(199, 53);
            this.KirjauduBT01.TabIndex = 4;
            this.KirjauduBT01.Text = "Kirjaudu sisään";
            this.KirjauduBT01.UseVisualStyleBackColor = true;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(140, 214);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.PasswordChar = '*';
            this.SalasanaTB.Size = new System.Drawing.Size(268, 22);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajatnsTB
            // 
            this.KayttajatnsTB.Location = new System.Drawing.Point(140, 139);
            this.KayttajatnsTB.Name = "KayttajatnsTB";
            this.KayttajatnsTB.Size = new System.Drawing.Size(268, 22);
            this.KayttajatnsTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // EtusivuBT01
            // 
            this.EtusivuBT01.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtusivuBT01.Location = new System.Drawing.Point(42, 33);
            this.EtusivuBT01.Name = "EtusivuBT01";
            this.EtusivuBT01.Size = new System.Drawing.Size(207, 73);
            this.EtusivuBT01.TabIndex = 1;
            this.EtusivuBT01.Text = "Etusivu";
            this.EtusivuBT01.UseVisualStyleBackColor = true;
            this.EtusivuBT01.Click += new System.EventHandler(this.EtusivuBT01_Click);
            // 
            // KIRJAUDU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Studypoint_2._0.Properties.Resources.technology_background_1632715;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.EtusivuBT01);
            this.Controls.Add(this.KirjauduGB);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KIRJAUDU";
            this.Size = new System.Drawing.Size(1332, 785);
            this.KirjauduGB.ResumeLayout(false);
            this.KirjauduGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox KirjauduGB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajatnsTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button KirjauduBT01;
        private System.Windows.Forms.Button EtusivuBT01;
    }
}
