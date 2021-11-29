
namespace Sponsorship.WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbParrain = new System.Windows.Forms.PictureBox();
            this.tmrPresentation = new System.Windows.Forms.Timer(this.components);
            this.tmrRecherche = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFilière = new System.Windows.Forms.Label();
            this.lblParrain = new System.Windows.Forms.Label();
            this.lblFilleul = new System.Windows.Forms.Label();
            this.pbFilliole1 = new System.Windows.Forms.PictureBox();
            this.pbFilliole2 = new System.Windows.Forms.PictureBox();
            this.lbFillole2 = new System.Windows.Forms.Label();
            this.lbFiliereFiol1 = new System.Windows.Forms.Label();
            this.lbFiliereFiol2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilliole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilliole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbParrain
            // 
            this.pbParrain.Image = ((System.Drawing.Image)(resources.GetObject("pbParrain.Image")));
            this.pbParrain.Location = new System.Drawing.Point(79, 187);
            this.pbParrain.Margin = new System.Windows.Forms.Padding(4);
            this.pbParrain.Name = "pbParrain";
            this.pbParrain.Size = new System.Drawing.Size(244, 254);
            this.pbParrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbParrain.TabIndex = 0;
            this.pbParrain.TabStop = false;
            // 
            // tmrPresentation
            // 
            this.tmrPresentation.Tick += new System.EventHandler(this.tmrPresentation_Tick);
            // 
            // tmrRecherche
            // 
            this.tmrRecherche.Tick += new System.EventHandler(this.tmrRecherche_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(632, 600);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 63);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Demarer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFilière
            // 
            this.lblFilière.AutoSize = true;
            this.lblFilière.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilière.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFilière.Location = new System.Drawing.Point(155, 135);
            this.lblFilière.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilière.Name = "lblFilière";
            this.lblFilière.Size = new System.Drawing.Size(30, 31);
            this.lblFilière.TabIndex = 3;
            this.lblFilière.Text = "?";
            // 
            // lblParrain
            // 
            this.lblParrain.AutoSize = true;
            this.lblParrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblParrain.Location = new System.Drawing.Point(73, 445);
            this.lblParrain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParrain.Name = "lblParrain";
            this.lblParrain.Size = new System.Drawing.Size(30, 31);
            this.lblParrain.TabIndex = 4;
            this.lblParrain.Text = "?";
            this.lblParrain.TextChanged += new System.EventHandler(this.lblParrain_TextChanged);
            // 
            // lblFilleul
            // 
            this.lblFilleul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilleul.AutoSize = true;
            this.lblFilleul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFilleul.Location = new System.Drawing.Point(86, 456);
            this.lblFilleul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilleul.Name = "lblFilleul";
            this.lblFilleul.Size = new System.Drawing.Size(30, 31);
            this.lblFilleul.TabIndex = 5;
            this.lblFilleul.Text = "?";
            this.lblFilleul.TextChanged += new System.EventHandler(this.lblFilleul_TextChanged);
            // 
            // pbFilliole1
            // 
            this.pbFilliole1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilliole1.Image = ((System.Drawing.Image)(resources.GetObject("pbFilliole1.Image")));
            this.pbFilliole1.Location = new System.Drawing.Point(92, 187);
            this.pbFilliole1.Margin = new System.Windows.Forms.Padding(4);
            this.pbFilliole1.Name = "pbFilliole1";
            this.pbFilliole1.Size = new System.Drawing.Size(245, 254);
            this.pbFilliole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilliole1.TabIndex = 0;
            this.pbFilliole1.TabStop = false;
            // 
            // pbFilliole2
            // 
            this.pbFilliole2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilliole2.Image = ((System.Drawing.Image)(resources.GetObject("pbFilliole2.Image")));
            this.pbFilliole2.Location = new System.Drawing.Point(558, 187);
            this.pbFilliole2.Margin = new System.Windows.Forms.Padding(4);
            this.pbFilliole2.Name = "pbFilliole2";
            this.pbFilliole2.Size = new System.Drawing.Size(240, 254);
            this.pbFilliole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilliole2.TabIndex = 0;
            this.pbFilliole2.TabStop = false;
            // 
            // lbFillole2
            // 
            this.lbFillole2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFillole2.AutoSize = true;
            this.lbFillole2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFillole2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbFillole2.Location = new System.Drawing.Point(552, 445);
            this.lbFillole2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFillole2.Name = "lbFillole2";
            this.lbFillole2.Size = new System.Drawing.Size(30, 31);
            this.lbFillole2.TabIndex = 5;
            this.lbFillole2.Text = "?";
            this.lbFillole2.TextChanged += new System.EventHandler(this.lbFillole2_TextChanged);
            // 
            // lbFiliereFiol1
            // 
            this.lbFiliereFiol1.AutoSize = true;
            this.lbFiliereFiol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiliereFiol1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbFiliereFiol1.Location = new System.Drawing.Point(173, 135);
            this.lbFiliereFiol1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiliereFiol1.Name = "lbFiliereFiol1";
            this.lbFiliereFiol1.Size = new System.Drawing.Size(62, 31);
            this.lbFiliereFiol1.TabIndex = 6;
            this.lbFiliereFiol1.Text = "TIC";
            // 
            // lbFiliereFiol2
            // 
            this.lbFiliereFiol2.AutoSize = true;
            this.lbFiliereFiol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiliereFiol2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbFiliereFiol2.Location = new System.Drawing.Point(634, 135);
            this.lbFiliereFiol2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFiliereFiol2.Name = "lbFiliereFiol2";
            this.lbFiliereFiol2.Size = new System.Drawing.Size(111, 31);
            this.lbFiliereFiol2.TabIndex = 7;
            this.lbFiliereFiol2.Text = "PREPA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(458, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 600);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(122, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(394, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fillius";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 559);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1480, 10);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 571);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbParrain);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblFilière);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblParrain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 571);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbFilliole1);
            this.panel3.Controls.Add(this.lbFiliereFiol2);
            this.panel3.Controls.Add(this.pbFilliole2);
            this.panel3.Controls.Add(this.lbFiliereFiol1);
            this.panel3.Controls.Add(this.lbFillole2);
            this.panel3.Controls.Add(this.lblFilleul);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(473, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 555);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-15, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1480, 10);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(122, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 55);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 689);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilliole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilliole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbParrain;
        private System.Windows.Forms.Timer tmrPresentation;
        private System.Windows.Forms.Timer tmrRecherche;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFilière;
        private System.Windows.Forms.Label lblParrain;
        private System.Windows.Forms.Label lblFilleul;
        private System.Windows.Forms.PictureBox pbFilliole1;
        private System.Windows.Forms.PictureBox pbFilliole2;
        private System.Windows.Forms.Label lbFillole2;
        private System.Windows.Forms.Label lbFiliereFiol1;
        private System.Windows.Forms.Label lbFiliereFiol2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}

