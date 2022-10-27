namespace AutomaticCV
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.logo = new System.Windows.Forms.PictureBox();
            this.pb_proximaAtualizacao = new System.Windows.Forms.ProgressBar();
            this.lbl_proximaAtualizacao = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gridLastSubmits = new System.Windows.Forms.DataGridView();
            this.EnvioCamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultadoCamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_titulo_bd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLastSubmits)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(1, 1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(567, 112);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // pb_proximaAtualizacao
            // 
            this.pb_proximaAtualizacao.Location = new System.Drawing.Point(12, 415);
            this.pb_proximaAtualizacao.Name = "pb_proximaAtualizacao";
            this.pb_proximaAtualizacao.Size = new System.Drawing.Size(396, 23);
            this.pb_proximaAtualizacao.TabIndex = 1;
            // 
            // lbl_proximaAtualizacao
            // 
            this.lbl_proximaAtualizacao.AutoSize = true;
            this.lbl_proximaAtualizacao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_proximaAtualizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.lbl_proximaAtualizacao.Location = new System.Drawing.Point(12, 393);
            this.lbl_proximaAtualizacao.Name = "lbl_proximaAtualizacao";
            this.lbl_proximaAtualizacao.Size = new System.Drawing.Size(129, 19);
            this.lbl_proximaAtualizacao.TabIndex = 2;
            this.lbl_proximaAtualizacao.Text = "Próxima atualização";
            this.lbl_proximaAtualizacao.Click += new System.EventHandler(this.lbl_proximaAtualizacao_Click);
            // 
            // gridLastSubmits
            // 
            this.gridLastSubmits.AllowUserToAddRows = false;
            this.gridLastSubmits.AllowUserToDeleteRows = false;
            this.gridLastSubmits.AllowUserToResizeColumns = false;
            this.gridLastSubmits.AllowUserToResizeRows = false;
            this.gridLastSubmits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLastSubmits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnvioCamp,
            this.NomeCamp,
            this.EmailCamp,
            this.ResultadoCamp});
            this.gridLastSubmits.Location = new System.Drawing.Point(12, 165);
            this.gridLastSubmits.MultiSelect = false;
            this.gridLastSubmits.Name = "gridLastSubmits";
            this.gridLastSubmits.ReadOnly = true;
            this.gridLastSubmits.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLastSubmits.RowTemplate.Height = 25;
            this.gridLastSubmits.Size = new System.Drawing.Size(943, 212);
            this.gridLastSubmits.TabIndex = 3;
            // 
            // EnvioCamp
            // 
            this.EnvioCamp.HeaderText = "Envio";
            this.EnvioCamp.MinimumWidth = 150;
            this.EnvioCamp.Name = "EnvioCamp";
            this.EnvioCamp.ReadOnly = true;
            this.EnvioCamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnvioCamp.Width = 150;
            // 
            // NomeCamp
            // 
            this.NomeCamp.HeaderText = "Nome";
            this.NomeCamp.MinimumWidth = 350;
            this.NomeCamp.Name = "NomeCamp";
            this.NomeCamp.ReadOnly = true;
            this.NomeCamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeCamp.Width = 350;
            // 
            // EmailCamp
            // 
            this.EmailCamp.HeaderText = "Email";
            this.EmailCamp.MinimumWidth = 250;
            this.EmailCamp.Name = "EmailCamp";
            this.EmailCamp.ReadOnly = true;
            this.EmailCamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmailCamp.Width = 250;
            // 
            // ResultadoCamp
            // 
            this.ResultadoCamp.HeaderText = "Resultado";
            this.ResultadoCamp.MinimumWidth = 150;
            this.ResultadoCamp.Name = "ResultadoCamp";
            this.ResultadoCamp.ReadOnly = true;
            this.ResultadoCamp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ResultadoCamp.Width = 150;
            // 
            // lbl_titulo_bd
            // 
            this.lbl_titulo_bd.AutoSize = true;
            this.lbl_titulo_bd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_titulo_bd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(91)))), ((int)(((byte)(126)))));
            this.lbl_titulo_bd.Location = new System.Drawing.Point(12, 143);
            this.lbl_titulo_bd.Name = "lbl_titulo_bd";
            this.lbl_titulo_bd.Size = new System.Drawing.Size(117, 19);
            this.lbl_titulo_bd.TabIndex = 4;
            this.lbl_titulo_bd.Text = "Ultimos cadastros";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.lbl_titulo_bd);
            this.Controls.Add(this.gridLastSubmits);
            this.Controls.Add(this.lbl_proximaAtualizacao);
            this.Controls.Add(this.pb_proximaAtualizacao);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutomaticCV";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLastSubmits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo;
        private ProgressBar pb_proximaAtualizacao;
        private Label lbl_proximaAtualizacao;
        private System.Windows.Forms.Timer timer2;
        private DataGridView gridLastSubmits;
        private Label lbl_titulo_bd;
        private DataGridViewTextBoxColumn EnvioCamp;
        private DataGridViewTextBoxColumn NomeCamp;
        private DataGridViewTextBoxColumn EmailCamp;
        private DataGridViewTextBoxColumn ResultadoCamp;
    }
}