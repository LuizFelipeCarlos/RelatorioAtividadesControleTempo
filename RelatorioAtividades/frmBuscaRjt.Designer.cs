namespace RelatorioAtividades
{
    partial class frmBuscaRjt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBuscaDataInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpBuscaDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnBuscaRjt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBuscaRjt = new System.Windows.Forms.DataGridView();
            this.btnGeraRjt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaRjt)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpBuscaDataInicio);
            this.groupBox1.Location = new System.Drawing.Point(7, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Inicio";
            // 
            // dtpBuscaDataInicio
            // 
            this.dtpBuscaDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBuscaDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscaDataInicio.Location = new System.Drawing.Point(6, 19);
            this.dtpBuscaDataInicio.Name = "dtpBuscaDataInicio";
            this.dtpBuscaDataInicio.Size = new System.Drawing.Size(134, 20);
            this.dtpBuscaDataInicio.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpBuscaDataFim);
            this.groupBox2.Location = new System.Drawing.Point(159, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Fim";
            // 
            // dtpBuscaDataFim
            // 
            this.dtpBuscaDataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBuscaDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBuscaDataFim.Location = new System.Drawing.Point(6, 19);
            this.dtpBuscaDataFim.Name = "dtpBuscaDataFim";
            this.dtpBuscaDataFim.Size = new System.Drawing.Size(134, 20);
            this.dtpBuscaDataFim.TabIndex = 0;
            // 
            // btnBuscaRjt
            // 
            this.btnBuscaRjt.Location = new System.Drawing.Point(335, 35);
            this.btnBuscaRjt.Name = "btnBuscaRjt";
            this.btnBuscaRjt.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaRjt.TabIndex = 3;
            this.btnBuscaRjt.Text = "Pesquisar";
            this.btnBuscaRjt.UseVisualStyleBackColor = true;
            this.btnBuscaRjt.Click += new System.EventHandler(this.btnBuscaRjt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvBuscaRjt);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 203);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relação da Pesquisa";
            // 
            // dgvBuscaRjt
            // 
            this.dgvBuscaRjt.AllowUserToAddRows = false;
            this.dgvBuscaRjt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscaRjt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscaRjt.Location = new System.Drawing.Point(7, 20);
            this.dgvBuscaRjt.Name = "dgvBuscaRjt";
            this.dgvBuscaRjt.RowHeadersVisible = false;
            this.dgvBuscaRjt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscaRjt.Size = new System.Drawing.Size(619, 177);
            this.dgvBuscaRjt.TabIndex = 0;
            // 
            // btnGeraRjt
            // 
            this.btnGeraRjt.Location = new System.Drawing.Point(551, 35);
            this.btnGeraRjt.Name = "btnGeraRjt";
            this.btnGeraRjt.Size = new System.Drawing.Size(75, 23);
            this.btnGeraRjt.TabIndex = 5;
            this.btnGeraRjt.Text = "Gera RJT";
            this.btnGeraRjt.UseVisualStyleBackColor = true;
            this.btnGeraRjt.Click += new System.EventHandler(this.btnGeraRjt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGeraRjt);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btnBuscaRjt);
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(632, 72);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisar RJT";
            // 
            // frmBuscaRjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 294);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmBuscaRjt";
            this.Text = "Pesquisa de RJT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscaRjt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBuscaDataInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpBuscaDataFim;
        private System.Windows.Forms.Button btnBuscaRjt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBuscaRjt;
        private System.Windows.Forms.Button btnGeraRjt;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}