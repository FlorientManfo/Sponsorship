
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
            this.tmrPresentation = new System.Windows.Forms.Timer(this.components);
            this.tmrRecherche = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilleul1 = new System.Windows.Forms.Label();
            this.lblFilleul2 = new System.Windows.Forms.Label();
            this.pbFilleul2 = new System.Windows.Forms.PictureBox();
            this.pbFilleul1 = new System.Windows.Forms.PictureBox();
            this.lblParrain = new System.Windows.Forms.Label();
            this.lblFiliereP = new System.Windows.Forms.Label();
            this.pbParrain = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFiliereFilleul2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFiliereFilleul1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPresentation
            // 
            this.tmrPresentation.Tick += new System.EventHandler(this.tmrPresentation_Tick);
            // 
            // tmrRecherche
            // 
            this.tmrRecherche.Tick += new System.EventHandler(this.tmrRecherche_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1645, 37);
            this.panel4.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1597, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(494, 481);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(324, 328);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Demarer";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-10, -163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fillius";
            // 
            // lblFilleul1
            // 
            this.lblFilleul1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilleul1.AutoSize = true;
            this.lblFilleul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul1.ForeColor = System.Drawing.Color.White;
            this.lblFilleul1.Location = new System.Drawing.Point(4, 0);
            this.lblFilleul1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilleul1.Name = "lblFilleul1";
            this.lblFilleul1.Size = new System.Drawing.Size(30, 31);
            this.lblFilleul1.TabIndex = 5;
            this.lblFilleul1.Text = "?";
            // 
            // lblFilleul2
            // 
            this.lblFilleul2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilleul2.AutoSize = true;
            this.lblFilleul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul2.ForeColor = System.Drawing.Color.White;
            this.lblFilleul2.Location = new System.Drawing.Point(4, 0);
            this.lblFilleul2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilleul2.Name = "lblFilleul2";
            this.lblFilleul2.Size = new System.Drawing.Size(30, 31);
            this.lblFilleul2.TabIndex = 5;
            this.lblFilleul2.Text = "?";
            // 
            // pbFilleul2
            // 
            this.pbFilleul2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFilleul2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFilleul2.Image = ((System.Drawing.Image)(resources.GetObject("pbFilleul2.Image")));
            this.pbFilleul2.Location = new System.Drawing.Point(816, 481);
            this.pbFilleul2.Margin = new System.Windows.Forms.Padding(4);
            this.pbFilleul2.Name = "pbFilleul2";
            this.pbFilleul2.Size = new System.Drawing.Size(378, 328);
            this.pbFilleul2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilleul2.TabIndex = 0;
            this.pbFilleul2.TabStop = false;
            // 
            // pbFilleul1
            // 
            this.pbFilleul1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFilleul1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFilleul1.Image = ((System.Drawing.Image)(resources.GetObject("pbFilleul1.Image")));
            this.pbFilleul1.Location = new System.Drawing.Point(118, 481);
            this.pbFilleul1.Margin = new System.Windows.Forms.Padding(4);
            this.pbFilleul1.Name = "pbFilleul1";
            this.pbFilleul1.Size = new System.Drawing.Size(379, 328);
            this.pbFilleul1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilleul1.TabIndex = 0;
            this.pbFilleul1.TabStop = false;
            // 
            // lblParrain
            // 
            this.lblParrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblParrain.AutoSize = true;
            this.lblParrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParrain.ForeColor = System.Drawing.Color.White;
            this.lblParrain.Location = new System.Drawing.Point(4, 0);
            this.lblParrain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParrain.Name = "lblParrain";
            this.lblParrain.Size = new System.Drawing.Size(43, 46);
            this.lblParrain.TabIndex = 4;
            this.lblParrain.Text = "?";
            // 
            // lblFiliereP
            // 
            this.lblFiliereP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiliereP.AutoSize = true;
            this.lblFiliereP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFiliereP.Location = new System.Drawing.Point(4, 0);
            this.lblFiliereP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiliereP.Name = "lblFiliereP";
            this.lblFiliereP.Size = new System.Drawing.Size(30, 31);
            this.lblFiliereP.TabIndex = 3;
            this.lblFiliereP.Text = "?";
            // 
            // pbParrain
            // 
            this.pbParrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbParrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbParrain.Image = ((System.Drawing.Image)(resources.GetObject("pbParrain.Image")));
            this.pbParrain.Location = new System.Drawing.Point(494, 155);
            this.pbParrain.Margin = new System.Windows.Forms.Padding(4);
            this.pbParrain.Name = "pbParrain";
            this.pbParrain.Size = new System.Drawing.Size(363, 328);
            this.pbParrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbParrain.TabIndex = 0;
            this.pbParrain.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 100);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(1543, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 98);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1305, 137);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 889);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.flowLayoutPanel7);
            this.panel3.Controls.Add(this.flowLayoutPanel5);
            this.panel3.Controls.Add(this.flowLayoutPanel6);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.pbParrain);
            this.panel3.Controls.Add(this.pbFilleul2);
            this.panel3.Controls.Add(this.pbFilleul1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(0, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 889);
            this.panel3.TabIndex = 14;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel7.Controls.Add(this.lblFiliereFilleul2);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(816, 420);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(378, 63);
            this.flowLayoutPanel7.TabIndex = 11;
            // 
            // lblFiliereFilleul2
            // 
            this.lblFiliereFilleul2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiliereFilleul2.AutoSize = true;
            this.lblFiliereFilleul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereFilleul2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFiliereFilleul2.Location = new System.Drawing.Point(4, 0);
            this.lblFiliereFilleul2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiliereFilleul2.Name = "lblFiliereFilleul2";
            this.lblFiliereFilleul2.Size = new System.Drawing.Size(83, 25);
            this.lblFiliereFilleul2.TabIndex = 3;
            this.lblFiliereFilleul2.Text = "PREPA";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel5.Controls.Add(this.lblFiliereP);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(494, 39);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(363, 63);
            this.flowLayoutPanel5.TabIndex = 9;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel6.Controls.Add(this.lblFiliereFilleul1);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(118, 420);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(379, 63);
            this.flowLayoutPanel6.TabIndex = 10;
            // 
            // lblFiliereFilleul1
            // 
            this.lblFiliereFilleul1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiliereFilleul1.AutoSize = true;
            this.lblFiliereFilleul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliereFilleul1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFiliereFilleul1.Location = new System.Drawing.Point(4, 0);
            this.lblFiliereFilleul1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiliereFilleul1.Name = "lblFiliereFilleul1";
            this.lblFiliereFilleul1.Size = new System.Drawing.Size(48, 25);
            this.lblFiliereFilleul1.TabIndex = 3;
            this.lblFiliereFilleul1.Text = "TIC";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel4.Controls.Add(this.lblFilleul2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(816, 804);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(378, 63);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel3.Controls.Add(this.lblFilleul1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(118, 804);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(379, 63);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel2.Controls.Add(this.lblParrain);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(494, 96);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(363, 63);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 1026);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrPresentation;
        private System.Windows.Forms.Timer tmrRecherche;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbFilleul1;
        private System.Windows.Forms.PictureBox pbFilleul2;
        private System.Windows.Forms.Label lblFilleul2;
        private System.Windows.Forms.Label lblFilleul1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbParrain;
        private System.Windows.Forms.Label lblFiliereP;
        private System.Windows.Forms.Label lblParrain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFiliereFilleul2;
        private System.Windows.Forms.Label lblFiliereFilleul1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

