
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
            this.lblFiliereP = new System.Windows.Forms.Label();
            this.lblParrain = new System.Windows.Forms.Label();
            this.lblFilleul1 = new System.Windows.Forms.Label();
            this.pbFilleul1 = new System.Windows.Forms.PictureBox();
            this.pbFilleul2 = new System.Windows.Forms.PictureBox();
            this.lblFilleul2 = new System.Windows.Forms.Label();
            this.lblFiliereFilleul1 = new System.Windows.Forms.Label();
            this.lblFiliereFilleul2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbParrain
            // 
            this.pbParrain.Image = ((System.Drawing.Image)(resources.GetObject("pbParrain.Image")));
            this.pbParrain.Location = new System.Drawing.Point(59, 152);
            this.pbParrain.Name = "pbParrain";
            this.pbParrain.Size = new System.Drawing.Size(183, 206);
            this.pbParrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbParrain.TabIndex = 0;
            this.pbParrain.TabStop = false;
            // 
            // tmrPresentation
            // 
            this.tmrPresentation.Interval = 300;
            this.tmrPresentation.Tick += new System.EventHandler(this.tmrPresentation_Tick);
            // 
            // tmrRecherche
            // 
            this.tmrRecherche.Interval = 400;
            this.tmrRecherche.Tick += new System.EventHandler(this.tmrRecherche_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(389, 479);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(251, 69);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Demarrer";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFiliereP
            // 
            this.lblFiliereP.AutoSize = true;
            this.lblFiliereP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFiliereP.Location = new System.Drawing.Point(116, 110);
            this.lblFiliereP.Name = "lblFiliereP";
            this.lblFiliereP.Size = new System.Drawing.Size(25, 25);
            this.lblFiliereP.TabIndex = 3;
            this.lblFiliereP.Text = "?";
            // 
            // lblParrain
            // 
            this.lblParrain.AutoSize = true;
            this.lblParrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblParrain.Location = new System.Drawing.Point(55, 362);
            this.lblParrain.Name = "lblParrain";
            this.lblParrain.Size = new System.Drawing.Size(25, 25);
            this.lblParrain.TabIndex = 4;
            this.lblParrain.Text = "?";
            // 
            // lblFilleul1
            // 
            this.lblFilleul1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilleul1.AutoSize = true;
            this.lblFilleul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFilleul1.Location = new System.Drawing.Point(64, 370);
            this.lblFilleul1.Name = "lblFilleul1";
            this.lblFilleul1.Size = new System.Drawing.Size(25, 25);
            this.lblFilleul1.TabIndex = 5;
            this.lblFilleul1.Text = "?";
            // 
            // pbFilleul1
            // 
            this.pbFilleul1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilleul1.Image = ((System.Drawing.Image)(resources.GetObject("pbFilleul1.Image")));
            this.pbFilleul1.Location = new System.Drawing.Point(69, 152);
            this.pbFilleul1.Name = "pbFilleul1";
            this.pbFilleul1.Size = new System.Drawing.Size(184, 206);
            this.pbFilleul1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilleul1.TabIndex = 0;
            this.pbFilleul1.TabStop = false;
            // 
            // pbFilleul2
            // 
            this.pbFilleul2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilleul2.Image = ((System.Drawing.Image)(resources.GetObject("pbFilleul2.Image")));
            this.pbFilleul2.Location = new System.Drawing.Point(418, 152);
            this.pbFilleul2.Name = "pbFilleul2";
            this.pbFilleul2.Size = new System.Drawing.Size(180, 206);
            this.pbFilleul2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilleul2.TabIndex = 0;
            this.pbFilleul2.TabStop = false;
            // 
            // lblFilleul2
            // 
            this.lblFilleul2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilleul2.AutoSize = true;
            this.lblFilleul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFilleul2.Location = new System.Drawing.Point(414, 362);
            this.lblFilleul2.Name = "lblFilleul2";
            this.lblFilleul2.Size = new System.Drawing.Size(25, 25);
            this.lblFilleul2.TabIndex = 5;
            this.lblFilleul2.Text = "?";
            // 
            // lblFiliereFilleul1
            // 
            this.lblFiliereFilleul1.AutoSize = true;
            this.lblFiliereFilleul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereFilleul1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFiliereFilleul1.Location = new System.Drawing.Point(130, 110);
            this.lblFiliereFilleul1.Name = "lblFiliereFilleul1";
            this.lblFiliereFilleul1.Size = new System.Drawing.Size(48, 25);
            this.lblFiliereFilleul1.TabIndex = 6;
            this.lblFiliereFilleul1.Text = "TIC";
            // 
            // lblFiliereFilleul2
            // 
            this.lblFiliereFilleul2.AutoSize = true;
            this.lblFiliereFilleul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereFilleul2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFiliereFilleul2.Location = new System.Drawing.Point(476, 110);
            this.lblFiliereFilleul2.Name = "lblFiliereFilleul2";
            this.lblFiliereFilleul2.Size = new System.Drawing.Size(88, 25);
            this.lblFiliereFilleul2.TabIndex = 7;
            this.lblFiliereFilleul2.Text = "PREPA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(344, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 488);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(296, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filleuls";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(-12, 454);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1110, 8);
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
            this.panel1.Location = new System.Drawing.Point(-7, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 464);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-11, 77);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1110, 8);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbParrain);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblFiliereP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblParrain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 464);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(92, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parain";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pbFilleul1);
            this.panel3.Controls.Add(this.lblFiliereFilleul2);
            this.panel3.Controls.Add(this.pbFilleul2);
            this.panel3.Controls.Add(this.lblFiliereFilleul1);
            this.panel3.Controls.Add(this.lblFilleul2);
            this.panel3.Controls.Add(this.lblFilleul1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(355, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 451);
            this.panel3.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 560);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbParrain;
        private System.Windows.Forms.Timer tmrPresentation;
        private System.Windows.Forms.Timer tmrRecherche;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFiliereP;
        private System.Windows.Forms.Label lblParrain;
        private System.Windows.Forms.Label lblFilleul1;
        private System.Windows.Forms.PictureBox pbFilleul1;
        private System.Windows.Forms.PictureBox pbFilleul2;
        private System.Windows.Forms.Label lblFilleul2;
        private System.Windows.Forms.Label lblFiliereFilleul1;
        private System.Windows.Forms.Label lblFiliereFilleul2;
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

