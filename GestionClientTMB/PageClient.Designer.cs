namespace GestionClientTMB
{
    partial class PageClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaisonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomReferent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceSpectacle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.textBoxRaisonSocial = new System.Windows.Forms.TextBox();
            this.textBoxNomRef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des clients du TMB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idclient,
            this.RaisonSocial,
            this.adresse,
            this.codePostal,
            this.ville,
            this.telephone,
            this.mail,
            this.nomReferent,
            this.LicenceSpectacle,
            this.SIRET,
            this.codeAPE});
            this.dataGridView1.Location = new System.Drawing.Point(81, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Idclient
            // 
            this.Idclient.HeaderText = "Id Client";
            this.Idclient.Name = "Idclient";
            // 
            // RaisonSocial
            // 
            this.RaisonSocial.HeaderText = "Raison social";
            this.RaisonSocial.Name = "RaisonSocial";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            // 
            // codePostal
            // 
            this.codePostal.HeaderText = "Code postal";
            this.codePostal.Name = "codePostal";
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            // 
            // mail
            // 
            this.mail.HeaderText = "E-mail";
            this.mail.Name = "mail";
            // 
            // nomReferent
            // 
            this.nomReferent.HeaderText = "NomRéférent";
            this.nomReferent.Name = "nomReferent";
            // 
            // LicenceSpectacle
            // 
            this.LicenceSpectacle.HeaderText = "LicenceSpectacle";
            this.LicenceSpectacle.Name = "LicenceSpectacle";
            // 
            // SIRET
            // 
            this.SIRET.HeaderText = "n°SIRET";
            this.SIRET.Name = "SIRET";
            // 
            // codeAPE
            // 
            this.codeAPE.HeaderText = "Code APE";
            this.codeAPE.Name = "codeAPE";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(507, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter un nouveau client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(531, 178);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(100, 20);
            this.textBoxVille.TabIndex = 3;
            // 
            // textBoxRaisonSocial
            // 
            this.textBoxRaisonSocial.Location = new System.Drawing.Point(333, 178);
            this.textBoxRaisonSocial.Name = "textBoxRaisonSocial";
            this.textBoxRaisonSocial.Size = new System.Drawing.Size(100, 20);
            this.textBoxRaisonSocial.TabIndex = 4;
            // 
            // textBoxNomRef
            // 
            this.textBoxNomRef.Location = new System.Drawing.Point(713, 178);
            this.textBoxNomRef.Name = "textBoxNomRef";
            this.textBoxNomRef.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomRef.TabIndex = 5;
            // 
            // PageClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 546);
            this.Controls.Add(this.textBoxNomRef);
            this.Controls.Add(this.textBoxRaisonSocial);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PageClient";
            this.Text = "PageClient";
            this.Load += new System.EventHandler(this.PageClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaisonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomReferent;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceSpectacle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAPE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.TextBox textBoxRaisonSocial;
        private System.Windows.Forms.TextBox textBoxNomRef;
    }
}