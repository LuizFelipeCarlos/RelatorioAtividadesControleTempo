using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDados;
using System.Data.SqlServerCe;

namespace RelatorioAtividades
{
    public partial class frmBuscaRjt : Form
    {
        Acesso acesso = new Acesso();

        public frmBuscaRjt()
        {
            InitializeComponent();
            dgvBuscaRjt.ColumnCount = 8;
            dgvBuscaRjt.Columns[0].Name = "Regularizando";
            dgvBuscaRjt.Columns[1].Name = "Data Inicio";
            dgvBuscaRjt.Columns[2].Name = "Data Fim";
            dgvBuscaRjt.Columns[3].Name = "Motivo";
            dgvBuscaRjt.Columns[4].Name = "Hora Inicio";
            dgvBuscaRjt.Columns[5].Name = "Hora Fim";
            dgvBuscaRjt.Columns[6].Name = "Chamado";
            dgvBuscaRjt.Columns[7].Name = "NomeCli";
            Load();

        }

        private void btnBuscaRjt_Click(object sender, EventArgs e)
        {
            LimpaDgv();
            if (Convert.ToInt64(dtpBuscaDataFim.Value.Date.ToString("yyyyMMdd")) < Convert.ToInt64(dtpBuscaDataInicio.Value.Date.ToString("yyyyMMdd")))
            {
                MessageBox.Show("A data fim não pode ser menor que a data inicio");
                dtpBuscaDataFim.Focus();
                return;
            }
            else
            {

                Recebe(acesso.QuerySelect(Campos(), "Rjt", Condicao()));
            };

        }

        #region Metodos

        private string Campos()
        {
            var campos = string.Format(" * ");
            return campos;
        }
        private string Condicao()
        {
            var condicao = string.Format("Data >= '{0}' and DataFim <= '{1}'", dtpBuscaDataInicio.Value.Date.ToString("yyyyMMdd")
                , dtpBuscaDataFim.Value.Date.ToString("yyyyMMdd"));
            return condicao;
        }
        private void Recebe(SqlCeDataReader Rc)
        {
            while (Rc.Read())
            {
                    try
                    {
                        dgvBuscaRjt.Rows.Add(Rc["Regularizando"], Rc["Data"], Rc["DataFim"], Rc["Motivo"], 
                            Rc["HoraInicio"], Rc["HoraFim"], Rc["Chamado"], Rc["NomeCli"]);
                    }
                    catch (Exception o)
                    {
                        MessageBox.Show(o.Message);
                    }
            }
        }
        private void Load()
        {
            var clausula = string.Format("data = '{0}' and datafim = '{1}'", dtpBuscaDataInicio.Value.Date.ToString("yyyyMMdd"), dtpBuscaDataFim.Value.Date.ToString("yyyyMMdd"));
            Recebe(acesso.QuerySelect(Campos(), "Rjt", clausula));
        }

        //Limpa Grid a cada pesquisa
        private void LimpaDgv()
        {
            dgvBuscaRjt.Rows.Clear() ;
        }

        #endregion

        private void btnGeraRjt_Click(object sender, EventArgs e)
        {
            if (dgvBuscaRjt.RowCount > 0)
            {
                frmRelatorioRJT abre = new frmRelatorioRJT(dgvBuscaRjt);
                abre.Show();
            }
            else
            {
                MessageBox.Show("Não existe RJT a ser gerado.");
                return;
            }
        }

    }
}


