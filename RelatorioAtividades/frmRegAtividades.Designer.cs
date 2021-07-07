namespace RelatorioAtividades
{
    partial class frmRegAtividades
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
            this.rtbAtividade = new System.Windows.Forms.RichTextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.txtTempAtividade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDifTotal = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtTotalMinutos = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtTotalAtividade = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegRemetente = new System.Windows.Forms.ToolStripMenuItem();
            this.rJTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRJTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInfoProd = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtAjusteTemp = new System.Windows.Forms.TextBox();
            this.cbbJustifica = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbAtividade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição da Atividade";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtbAtividade
            // 
            this.rtbAtividade.Location = new System.Drawing.Point(6, 25);
            this.rtbAtividade.Name = "rtbAtividade";
            this.rtbAtividade.Size = new System.Drawing.Size(431, 89);
            this.rtbAtividade.TabIndex = 2;
            this.rtbAtividade.Text = "";
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(12, 183);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // txtTempAtividade
            // 
            this.txtTempAtividade.Enabled = false;
            this.txtTempAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempAtividade.Location = new System.Drawing.Point(6, 19);
            this.txtTempAtividade.Name = "txtTempAtividade";
            this.txtTempAtividade.Size = new System.Drawing.Size(107, 20);
            this.txtTempAtividade.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.btnCalculo);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 122);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculo de Tempo";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDifTotal);
            this.groupBox9.Location = new System.Drawing.Point(136, 69);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(112, 47);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Diferencia X Total";
            // 
            // txtDifTotal
            // 
            this.txtDifTotal.Location = new System.Drawing.Point(6, 19);
            this.txtDifTotal.Name = "txtDifTotal";
            this.txtDifTotal.Size = new System.Drawing.Size(100, 20);
            this.txtDifTotal.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtTotalMinutos);
            this.groupBox7.Location = new System.Drawing.Point(324, 69);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(112, 47);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Total em Minutos";
            // 
            // txtTotalMinutos
            // 
            this.txtTotalMinutos.Enabled = false;
            this.txtTotalMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMinutos.Location = new System.Drawing.Point(6, 19);
            this.txtTotalMinutos.Name = "txtTotalMinutos";
            this.txtTotalMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalMinutos.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTotalHoras);
            this.groupBox6.Location = new System.Drawing.Point(324, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 47);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Total em Horas";
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Enabled = false;
            this.txtTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHoras.Location = new System.Drawing.Point(6, 19);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHoras.TabIndex = 3;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.Location = new System.Drawing.Point(43, 85);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 5;
            this.btnCalculo.Text = "Calcular";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMinutos);
            this.groupBox5.Location = new System.Drawing.Point(136, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informe os Minutos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(6, 19);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtHoras);
            this.groupBox4.Location = new System.Drawing.Point(6, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 47);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe as Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(6, 19);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTempAtividade);
            this.groupBox3.Location = new System.Drawing.Point(103, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tempo da Atividade";
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(380, 183);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 7;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTotalAtividade);
            this.groupBox8.Location = new System.Drawing.Point(252, 219);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(122, 47);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Total das Atividades";
            // 
            // txtTotalAtividade
            // 
            this.txtTotalAtividade.Enabled = false;
            this.txtTotalAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAtividade.Location = new System.Drawing.Point(6, 19);
            this.txtTotalAtividade.Name = "txtTotalAtividade";
            this.txtTotalAtividade.Size = new System.Drawing.Size(110, 20);
            this.txtTotalAtividade.TabIndex = 3;
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.Location = new System.Drawing.Point(380, 236);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 8;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfig,
            this.rJTToolStripMenuItem,
            this.tsmSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmConfig
            // 
            this.tsmConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegRemetente});
            this.tsmConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmConfig.Name = "tsmConfig";
            this.tsmConfig.Size = new System.Drawing.Size(104, 21);
            this.tsmConfig.Text = "Configuração";
            // 
            // tsmRegRemetente
            // 
            this.tsmRegRemetente.Name = "tsmRegRemetente";
            this.tsmRegRemetente.Size = new System.Drawing.Size(222, 22);
            this.tsmRegRemetente.Text = "Registro de Remetente";
            this.tsmRegRemetente.Click += new System.EventHandler(this.tsmRegRemetente_Click);
            // 
            // rJTToolStripMenuItem
            // 
            this.rJTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.buscarRJTToolStripMenuItem});
            this.rJTToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rJTToolStripMenuItem.Name = "rJTToolStripMenuItem";
            this.rJTToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.rJTToolStripMenuItem.Text = "RJT";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registroToolStripMenuItem.Text = "Registrar RJT";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // buscarRJTToolStripMenuItem
            // 
            this.buscarRJTToolStripMenuItem.Name = "buscarRJTToolStripMenuItem";
            this.buscarRJTToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.buscarRJTToolStripMenuItem.Text = "Buscar RJT";
            this.buscarRJTToolStripMenuItem.Click += new System.EventHandler(this.buscarRJTToolStripMenuItem_Click);
            // 
            // tsmSobre
            // 
            this.tsmSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInfoProd});
            this.tsmSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmSobre.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tsmSobre.Name = "tsmSobre";
            this.tsmSobre.Size = new System.Drawing.Size(58, 21);
            this.tsmSobre.Text = "Sobre";
            // 
            // tsmInfoProd
            // 
            this.tsmInfoProd.Name = "tsmInfoProd";
            this.tsmInfoProd.Size = new System.Drawing.Size(207, 22);
            this.tsmInfoProd.Text = "Informações Produto";
            this.tsmInfoProd.Click += new System.EventHandler(this.tsmInfoProd_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtAjusteTemp);
            this.groupBox10.Location = new System.Drawing.Point(252, 166);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(122, 47);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ajuste Tempo";
            // 
            // txtAjusteTemp
            // 
            this.txtAjusteTemp.Location = new System.Drawing.Point(6, 19);
            this.txtAjusteTemp.Name = "txtAjusteTemp";
            this.txtAjusteTemp.Size = new System.Drawing.Size(110, 20);
            this.txtAjusteTemp.TabIndex = 3;
            // 
            // cbbJustifica
            // 
            this.cbbJustifica.FormattingEnabled = true;
            this.cbbJustifica.Items.AddRange(new object[] {
            "Ausência",
            "Férias",
            "Capacitação",
            "Gestão",
            "Reunião",
            "Outros"});
            this.cbbJustifica.Location = new System.Drawing.Point(6, 18);
            this.cbbJustifica.Name = "cbbJustifica";
            this.cbbJustifica.Size = new System.Drawing.Size(107, 21);
            this.cbbJustifica.TabIndex = 8;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbbJustifica);
            this.groupBox11.Location = new System.Drawing.Point(103, 219);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(119, 47);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Justificativa";
            // 
            // frmRegAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 403);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegAtividades";
            this.Text = "Registro de Atividades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegAtividades_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbAtividade;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtTempAtividade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtTotalMinutos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTotalAtividade;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtDifTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmRegRemetente;
        private System.Windows.Forms.ToolStripMenuItem tsmSobre;
        private System.Windows.Forms.ToolStripMenuItem tsmInfoProd;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtAjusteTemp;
        private System.Windows.Forms.ToolStripMenuItem rJTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarRJTToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbJustifica;
        private System.Windows.Forms.GroupBox groupBox11;
    }
}

