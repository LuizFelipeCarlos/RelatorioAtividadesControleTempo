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
using System.Collections;


namespace RelatorioAtividades
{
    public partial class frmRelatorioRJT : frmBuscaRjt
    {
        string campoNome;
        string campoEmail;
        string campoSenha;
        Acesso AcessaBancoDados = new Acesso();
        DataGridView PDgv;

        public frmRelatorioRJT(DataGridView RecebeDgv)
        {
            InitializeComponent();
            reportViewer1_Load(RecebeDgv);
        }
        private void frmRelatorioRJT_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'DataSet1.RJT' table. You can move, or remove it, as needed.
            //this.RJTTableAdapter.Fill(this.DataSet1.RJT);

            //this.reportViewer1.RefreshReport();
        }
        private void Recebe(SqlCeDataReader Rc)
        {
            while (Rc.Read())
            {
                try
                {
                    //dgvBuscaRjt.Rows.Add(Rc["Regularizando"], Rc["Data"], Rc["DataFim"], Rc["Motivo"],
                    //  Rc["HoraInicio"], Rc["HoraFim"], Rc["Chamado"]);
                    campoNome = Rc["Nome"].ToString();
                    campoEmail = Rc["Email"].ToString();
                    campoSenha = Rc["Senha"].ToString();
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.Message);
                }
            }
        }
        public void reportViewer1_Load(/*object sender, EventArgs e,*/ DataGridView recebGrid)
        {
            Recebe(AcessaBancoDados.QuerySelect("*", "Usuario"));
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ArrayList t = new ArrayList();
            //dt.Columns.Add("Id", typeof(Int16));
            dt.Columns.Add("Regularizando", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("DataFim", typeof(string));
            dt.Columns.Add("Motivo", typeof(string));
            dt.Columns.Add("HoraInicio", typeof(string));
            dt.Columns.Add("HoraFim", typeof(string));
            dt.Columns.Add("Chamado", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("NomeCli", typeof(string));
            ArrayList listaNome = new ArrayList();
            int conta = 0;

            foreach (DataGridViewRow dgr in recebGrid.Rows)
            {
                if (conta < recebGrid.Rows.Count)
                {
                    if (campoNome == null)
                    {
                        campoNome = "Preencha o campo nome em configuração.";
                    }
                    listaNome.Add(campoNome);
                }
                dt.Rows.Add(
                    dgr.Cells[0].Value,
                    dgr.Cells[1].Value,
                    dgr.Cells[2].Value,
                    dgr.Cells[3].Value,
                    dgr.Cells[4].Value,
                    dgr.Cells[5].Value,
                    dgr.Cells[6].Value,
                    listaNome[conta].ToString(),
                    dgr.Cells[7].Value
                    );
                conta++;
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("TabelaRjt.xml");
            RjtRelatorio cr = new RjtRelatorio();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }


        }
    }

