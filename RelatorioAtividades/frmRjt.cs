using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BancoDados;
using System.Data.SqlServerCe;



namespace RelatorioAtividades
{
    public partial class frmRjt : Form
    {
        public frmRjt()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Valida Campos
            if (cbbRegularizando.Text == "Hora Extra")
            {
                if (txtChamado.Text == "")
                {
                    MessageBox.Show("Informe o Chamado");
                    this.txtChamado.Focus();
                    return;
                }

                if (dtpRegistroDataFim.Text != dtpRegistroDataInicio.Text)
                {
                    MessageBox.Show("A data final não pode ser diferente da data inicial");
                    dtpRegistroDataFim.Focus();
                    return;
                }
                if (mktHoraInicio.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora inicial");
                    mktHoraInicio.Focus();
                    return;
                }
                if (mktHoraFim.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora final");
                    mktHoraFim.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Atraso")
            {
                if (mktHoraInicio.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora inicial");
                    mktHoraInicio.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Saida Antecipada")
            {
                if (mktHoraInicio.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora inicial");
                    mktHoraInicio.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Saida Horario Expediente")
            {
                if (mktHoraInicio.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora inicial");
                    mktHoraInicio.Focus();
                    return;
                }
                if (mktHoraFim.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora final");
                    mktHoraFim.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Falta")
            {
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Falta Meio Periodo" || cbbRegularizando.Text == "Ausência Período Integral")
            {
                if (dtpRegistroDataFim.Text != dtpRegistroDataInicio.Text)
                {
                    MessageBox.Show("A data final não pode ser diferente da data inicial");
                    dtpRegistroDataFim.Focus();
                    return;
                }
                if (mktHoraInicio.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora inicial");
                    mktHoraInicio.Focus();
                    return;
                }
                if (mktHoraFim.Text == "  :")
                {
                    MessageBox.Show("Informe a Hora final");
                    mktHoraFim.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            if (cbbRegularizando.Text == "Hora Almoço")
            {
                if (mktHoraInicio.Text == "  :" && mktHoraFim.Text == "  :")
                {
                    MessageBox.Show("Informe a hora que deseja corrigir. Saída ou Retorno.");
                    mktHoraInicio.Focus();
                    return;
                }
                if (rtbMotivo.Text == "")
                {
                    MessageBox.Show("Informe o Motivo");
                    rtbMotivo.Focus();
                    return;
                }
            }
            #endregion
            var gravaDados = new Acesso();
            gravaDados.QueryInsert("rjt", ColunasTabela(), ValorQueryInsert());
            MessageBox.Show("Dados gravados com sucesso");
            LimpaCampos();
        }

        #region Eventos não utilizados
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void txtChamado_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtHoraFim_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmRjt_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos da class
        private string ColunasTabela() 
        {
            var colunaTabela = "Regularizando, Data,  Motivo, HoraInicio, HoraFim, DataFim, Chamado, NomeCli";
            return colunaTabela;
        }
        private void TrataValor()
        {
            switch (cbbRegularizando.Text)
            {
                case "":
                    cbbRegularizando.Text = null;
                    break;
            }
            switch (txtChamado.Text)
            {
                case "":
                    txtChamado.Text = null;
                    break;
            }
            switch (mktHoraInicio.Text)
            {
                case "":
                    mktHoraInicio.Text = null;
                    break;
            }
            switch (mktHoraFim.Text)
            {
                case "":
                    mktHoraFim.Text = null;
                    break;
            }
            switch (rtbMotivo.Text)
            {
                case"":
                    rtbMotivo.Text = null;
                    break;
            }


        }
        private string ValorQueryInsert()
        {
        //    System.Globalization.DateTimeFormatInfo dateInfoBr = new System.Globalization.DateTimeFormatInfo();
        //dateInfoBr.ShortDatePattern = "dd/MM/yyyy";

        string dataIni = dtpRegistroDataInicio.Value.Date.ToString("yyyyMMdd");
        string dataF = dtpRegistroDataFim.Value.Date.ToString("yyyyMMdd");


            TrataValor();
            var query = string.Format("'{0}', '{1} 00:00:00:000', '{2}', '{3}', '{4}', '{5} 00:00:00:000', '{6}','{7}'"
                , cbbRegularizando.Text, dataIni/*Convert.ToDateTime(dtpRegistroDataInicio.Text, dateInfoBr)*/, rtbMotivo.Text, mktHoraInicio.Text, mktHoraFim.Text
                , dataF /*Convert.ToDateTime( dtpRegistroDataFim.Text, dateInfoBr)*/, txtChamado.Text,txtNomeCliServExt.Text);
            return query;
        }
        private void LimpaCampos()
        {
            cbbRegularizando.Text = "";
            txtChamado.Text = "";
            dtpRegistroDataFim.Text = DateTime.Now.ToString();
            dtpRegistroDataInicio.Text = DateTime.Now.ToString();
            mktHoraInicio.Text = "";
            mktHoraFim.Text = "";
            rtbMotivo.Text = "";
            txtNomeCliServExt.Text = "";
        }
        #endregion

        private void btnRegistroPesquisaRjt_Click(object sender, EventArgs e)
        {
            Form pesquisa = new frmBuscaRjt();
            pesquisa.Show();
        }
    }
}