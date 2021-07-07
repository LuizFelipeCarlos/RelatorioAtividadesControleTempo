namespace RelatorioAtividades
{
    partial class frmRjt
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
            this.cbbRegularizando = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mktHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mktHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rtbMotivo = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtpRegistroDataInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtChamado = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtpRegistroDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnRegistroPesquisaRjt = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtNomeCliServExt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbRegularizando);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regularizando";
            // 
            // cbbRegularizando
            // 
            this.cbbRegularizando.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbRegularizando.FormattingEnabled = true;
            this.cbbRegularizando.Items.AddRange(new object[] {
            "Hora Extra",
            "Atraso",
            "Saida Antecipada",
            "Falta",
            "Falta Meio Periodo",
            "Hora Almoço",
            "Ausência durante expediente",
            "Ausência Período Integral"});
            this.cbbRegularizando.Location = new System.Drawing.Point(6, 19);
            this.cbbRegularizando.Name = "cbbRegularizando";
            this.cbbRegularizando.Size = new System.Drawing.Size(224, 21);
            this.cbbRegularizando.TabIndex = 0;
            this.cbbRegularizando.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mktHoraInicio);
            this.groupBox2.Location = new System.Drawing.Point(9, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora";
            // 
            // mktHoraInicio
            // 
            this.mktHoraInicio.Location = new System.Drawing.Point(7, 20);
            this.mktHoraInicio.Mask = "00:00";
            this.mktHoraInicio.Name = "mktHoraInicio";
            this.mktHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.mktHoraInicio.TabIndex = 0;
            this.mktHoraInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mktHoraFim);
            this.groupBox3.Location = new System.Drawing.Point(130, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hora Fim";
            // 
            // mktHoraFim
            // 
            this.mktHoraFim.Location = new System.Drawing.Point(7, 20);
            this.mktHoraFim.Mask = "00:00";
            this.mktHoraFim.Name = "mktHoraFim";
            this.mktHoraFim.Size = new System.Drawing.Size(100, 20);
            this.mktHoraFim.TabIndex = 0;
            this.mktHoraFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mktHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rtbMotivo);
            this.groupBox4.Location = new System.Drawing.Point(9, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 125);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motivo";
            // 
            // rtbMotivo
            // 
            this.rtbMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMotivo.Location = new System.Drawing.Point(6, 19);
            this.rtbMotivo.Name = "rtbMotivo";
            this.rtbMotivo.Size = new System.Drawing.Size(361, 100);
            this.rtbMotivo.TabIndex = 0;
            this.rtbMotivo.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(301, 90);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtpRegistroDataInicio
            // 
            this.dtpRegistroDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegistroDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistroDataInicio.Location = new System.Drawing.Point(6, 19);
            this.dtpRegistroDataInicio.Name = "dtpRegistroDataInicio";
            this.dtpRegistroDataInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpRegistroDataInicio.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpRegistroDataInicio);
            this.groupBox5.Location = new System.Drawing.Point(9, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(115, 49);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data";
            // 
            // txtChamado
            // 
            this.txtChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChamado.Location = new System.Drawing.Point(9, 20);
            this.txtChamado.Name = "txtChamado";
            this.txtChamado.Size = new System.Drawing.Size(100, 20);
            this.txtChamado.TabIndex = 0;
            this.txtChamado.TextChanged += new System.EventHandler(this.txtChamado_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtChamado);
            this.groupBox6.Location = new System.Drawing.Point(267, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(115, 53);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chamado";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtpRegistroDataFim);
            this.groupBox7.Location = new System.Drawing.Point(130, 70);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(115, 49);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data Fim";
            // 
            // dtpRegistroDataFim
            // 
            this.dtpRegistroDataFim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpRegistroDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegistroDataFim.Location = new System.Drawing.Point(6, 19);
            this.dtpRegistroDataFim.Name = "dtpRegistroDataFim";
            this.dtpRegistroDataFim.Size = new System.Drawing.Size(103, 20);
            this.dtpRegistroDataFim.TabIndex = 0;
            // 
            // btnRegistroPesquisaRjt
            // 
            this.btnRegistroPesquisaRjt.Location = new System.Drawing.Point(301, 143);
            this.btnRegistroPesquisaRjt.Name = "btnRegistroPesquisaRjt";
            this.btnRegistroPesquisaRjt.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroPesquisaRjt.TabIndex = 8;
            this.btnRegistroPesquisaRjt.Text = "Pesquisar";
            this.btnRegistroPesquisaRjt.UseVisualStyleBackColor = true;
            this.btnRegistroPesquisaRjt.Click += new System.EventHandler(this.btnRegistroPesquisaRjt_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtNomeCliServExt);
            this.groupBox8.Location = new System.Drawing.Point(9, 184);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(373, 50);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nome Cliente - Serviço Externo";
            // 
            // txtNomeCliServExt
            // 
            this.txtNomeCliServExt.Location = new System.Drawing.Point(7, 19);
            this.txtNomeCliServExt.Name = "txtNomeCliServExt";
            this.txtNomeCliServExt.Size = new System.Drawing.Size(360, 20);
            this.txtNomeCliServExt.TabIndex = 0;
            // 
            // frmRjt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 377);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnRegistroPesquisaRjt);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRjt";
            this.Text = "Registro de RJT";
            this.Load += new System.EventHandler(this.frmRjt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbRegularizando;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox rtbMotivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtpRegistroDataInicio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtChamado;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker dtpRegistroDataFim;
        private System.Windows.Forms.Button btnRegistroPesquisaRjt;
        private System.Windows.Forms.MaskedTextBox mktHoraInicio;
        private System.Windows.Forms.MaskedTextBox mktHoraFim;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtNomeCliServExt;
    }
}