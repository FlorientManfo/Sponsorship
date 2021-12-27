namespace Sponsorship.WinForms
{
    partial class FrmChoseLocationFile
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
            this.btnListe = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbListe = new System.Windows.Forms.TextBox();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(362, 99);
            this.btnListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(110, 31);
            this.btnListe.TabIndex = 0;
            this.btnListe.Text = "List";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(362, 158);
            this.btnImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(110, 31);
            this.btnImage.TabIndex = 0;
            this.btnImage.Text = "Images";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir les emplacements des listes et des images";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(240, 230);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(88, 41);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbListe
            // 
            this.tbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbListe.Location = new System.Drawing.Point(9, 99);
            this.tbListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbListe.Name = "tbListe";
            this.tbListe.Size = new System.Drawing.Size(350, 32);
            this.tbListe.TabIndex = 2;
            // 
            // tbImage
            // 
            this.tbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImage.Location = new System.Drawing.Point(9, 158);
            this.tbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(350, 32);
            this.tbImage.TabIndex = 2;
            // 
            // FrmChoseLocationFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 267);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.tbListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnListe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmChoseLocationFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChoseLocationFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbListe;
        private System.Windows.Forms.TextBox tbImage;
    }
}