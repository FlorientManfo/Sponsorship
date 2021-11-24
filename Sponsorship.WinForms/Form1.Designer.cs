
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
            this.pbFilleul = new System.Windows.Forms.PictureBox();
            this.lblFilière = new System.Windows.Forms.Label();
            this.lblParrain = new System.Windows.Forms.Label();
            this.lblFilleul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul)).BeginInit();
            this.SuspendLayout();
            // 
            // pbParrain
            // 
            this.pbParrain.Image = ((System.Drawing.Image)(resources.GetObject("pbParrain.Image")));
            this.pbParrain.Location = new System.Drawing.Point(53, 62);
            this.pbParrain.Name = "pbParrain";
            this.pbParrain.Size = new System.Drawing.Size(239, 206);
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
            this.btnStart.Location = new System.Drawing.Point(606, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbFilleul
            // 
            this.pbFilleul.Image = ((System.Drawing.Image)(resources.GetObject("pbFilleul.Image")));
            this.pbFilleul.Location = new System.Drawing.Point(470, 62);
            this.pbFilleul.Name = "pbFilleul";
            this.pbFilleul.Size = new System.Drawing.Size(239, 206);
            this.pbFilleul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilleul.TabIndex = 2;
            this.pbFilleul.TabStop = false;
            // 
            // lblFilière
            // 
            this.lblFilière.AutoSize = true;
            this.lblFilière.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilière.Location = new System.Drawing.Point(330, 24);
            this.lblFilière.Name = "lblFilière";
            this.lblFilière.Size = new System.Drawing.Size(76, 25);
            this.lblFilière.TabIndex = 3;
            this.lblFilière.Text = "label1";
            // 
            // lblParrain
            // 
            this.lblParrain.AutoSize = true;
            this.lblParrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParrain.Location = new System.Drawing.Point(134, 292);
            this.lblParrain.Name = "lblParrain";
            this.lblParrain.Size = new System.Drawing.Size(76, 25);
            this.lblParrain.TabIndex = 4;
            this.lblParrain.Text = "label1";
            // 
            // lblFilleul
            // 
            this.lblFilleul.AutoSize = true;
            this.lblFilleul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilleul.Location = new System.Drawing.Point(551, 292);
            this.lblFilleul.Name = "lblFilleul";
            this.lblFilleul.Size = new System.Drawing.Size(76, 25);
            this.lblFilleul.TabIndex = 5;
            this.lblFilleul.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFilleul);
            this.Controls.Add(this.lblParrain);
            this.Controls.Add(this.lblFilière);
            this.Controls.Add(this.pbFilleul);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbParrain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbParrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilleul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbParrain;
        private System.Windows.Forms.Timer tmrPresentation;
        private System.Windows.Forms.Timer tmrRecherche;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbFilleul;
        private System.Windows.Forms.Label lblFilière;
        private System.Windows.Forms.Label lblParrain;
        private System.Windows.Forms.Label lblFilleul;
    }
}

