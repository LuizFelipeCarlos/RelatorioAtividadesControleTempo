using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RelatorioAtividades
{
    public partial class frmRegAtividades : Form
    {
        //Atributos Privados da Classe
        private ArrayList atRegAtividades = new ArrayList();
        private ArrayList atTempAtividade = new ArrayList();
        private ArrayList atTotalAtividade = new ArrayList();
        private ArrayList atInfHoras = new ArrayList();
        private ArrayList atInfMinutos = new ArrayList();
        private ArrayList atDifTotal = new ArrayList();
        private ArrayList atTotalHoras = new ArrayList();
        private ArrayList atMinutos = new ArrayList();
        private ArrayList atJustifica = new ArrayList();

        //Propriedades Privados da classe
        public ArrayList PrRegAtividades { get { return atRegAtividades; } set { atRegAtividades = value; } }
        public ArrayList PrTempAtividade { get { return atTempAtividade; } set { atTempAtividade = value; } }
        private ArrayList PrTotalAtividade { get { return atTotalAtividade; } set { atTotalAtividade = value; } }
        private ArrayList PrInfHoras { get { return atInfHoras; } set { atInfHoras = value; } }
        private ArrayList PrInfMinutos { get { return atInfMinutos; } set { atInfMinutos = value; } }
        private ArrayList PrDifTotal { get { return atDifTotal; } set { atDifTotal = value; } }
        private ArrayList PrTotalHoras { get { return atTotalHoras; } set { atTotalHoras = value; } }
        private ArrayList PrMinutos { get { return atMinutos; } set { atMinutos = value; } }
        private ArrayList PrJustifica { get { return atJustifica; } set { atJustifica = value; } }

        //Variaveis Privadas da Classe
        private int pegaHora;
        private int PegaMinuto;
        private int pegaHoraFim;
        private int pegaMinutoFim;
        private int hora;
        private int minuto;
        private string texto;
        private double resultCalc;
        private double resultCalc2;
        private int totalAtiv = 0;

        //Metodos Privados Sem Retorno
        private void MtPegaHoraInicio()
        {
            pegaHora = DateTime.Now.Hour;
            PegaMinuto = DateTime.Now.Minute;
        }
        private void MtPegaHoraFim()
        {
            pegaHoraFim = DateTime.Now.Hour;
            pegaMinutoFim = DateTime.Now.Minute;
        }
        private void MtCalcHoraFimHoraInicio()
        {
            hora = pegaHoraFim - pegaHora;
            minuto = pegaMinutoFim - PegaMinuto;
        }
        private void MtRegistraAtividade(int Tempo, string Atividade, string Justifica)
        {
            PrTempAtividade.Add(Tempo);
            PrRegAtividades.Add(Atividade);
            PrJustifica.Add(Justifica);
        }
        private void MtZeraVariaveis()
        {
            pegaHora = 0;
            PegaMinuto = 0;
            pegaHoraFim = 0;
            pegaMinutoFim = 0;
            hora = 0;
            minuto = 0;
            texto = "";
            rtbAtividade.Text = "";
            txtTempAtividade.Text = "";
        }
        private double MtCalculaMinutos(double horas)
        {
            var minutos = 60;
            return resultCalc = horas * minutos;
        }
        private double MtCalculaHoras(double minutos)
        {
            var hora = 60;
            return resultCalc = minutos / hora;
        }
        private double MtCalculaDifHora(double hora, double totalMinAtiv)
        {
            var minutos = 60;
            var totalHorasTrab = hora * minutos;
            return resultCalc = ((totalHorasTrab - totalMinAtiv) / minutos);
        }
        private double MtCalculaDifMin(double hora, double totalMinAtiv)
        {
            var minutos = 60;
            var totalMinTrab = hora * minutos;
            return resultCalc2 = totalMinTrab - totalMinAtiv;

        }
        private int MtCalculaTotalAtiv(ArrayList TempoAtiv)
        {
            totalAtiv = 0;
            for (int conta = 0; conta < TempoAtiv.Count; conta++)
            {
                totalAtiv += Convert.ToInt32(TempoAtiv[conta]);
            }
            return totalAtiv;
        }
        private void MtPegaValorAjuste(int valorAjust)
        {
            if (valorAjust != null)
            {
                try
                {
                    minuto += valorAjust;
                }
                catch
                {
                    MessageBox.Show(string.Format("O valor {0} é Invalido", this.txtAjusteTemp.Text));
                }
            }

        }

        //Metodo de carregamento do Form
        public frmRegAtividades()
        {
            InitializeComponent();
        }

        //Eventos Criados
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rtbAtividade.Text == "")
                {
                    MessageBox.Show("Informe a Atividade");
                    rtbAtividade.Focus();
                    return;
                }
                else
                {
                    if(this.cbbJustifica.Text == "")
                    {
                        MessageBox.Show("Informe a Justificativa da Atividade ou Hora");
                        cbbJustifica.Focus();
                        return;
                    }
                }
                MtPegaValorAjuste(Convert.ToInt32(this.txtAjusteTemp.Text));
                MtRegistraAtividade(minuto, this.rtbAtividade.Text, cbbJustifica.Text);
                MtCalculaTotalAtiv(PrTempAtividade);
                this.txtTotalAtividade.Text = totalAtiv.ToString();
                MtZeraVariaveis();
            }
            catch
            {
                MessageBox.Show(string.Format("O valor '{0}' é Invalido.", this.txtAjusteTemp.Text.ToUpper()));
            }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.btnInicio.Text == "Inicio")
            {
                MtPegaHoraInicio();
            }
            if (this.btnInicio.Text == "Fim")
            {
                MtPegaHoraFim();
                MtCalcHoraFimHoraInicio();
                if (hora > 0)
                {
                    minuto += hora * 60;
                    this.txtTempAtividade.Text = string.Format("{0}", minuto);
                }
                else
                {
                    this.txtTempAtividade.Text = string.Format("{0}", minuto);
                }
            }
            if (this.btnInicio.Text == "Inicio")
            {
                this.btnInicio.Text = "Fim";
                this.btnSalva.Enabled = false;
                this.btnEmail.Enabled = false;
            }
            else
            {
                this.btnInicio.Text = "Inicio";
                this.btnSalva.Enabled = true;
                this.btnEmail.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtAjusteTemp.Text = "0";
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmEnvioEmail janelaEmail = new frmEnvioEmail(PrRegAtividades, PrTempAtividade, totalAtiv, PrJustifica);
            janelaEmail.Show();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txtDifTotal.Text != "" && Convert.ToDouble(this.txtDifTotal.Text) > 0) //&& txtTotalAtividade.Text != "" && Convert.ToDouble(this.txtTotalAtividade.Text) > 0)
                {
                    if (txtTotalAtividade.Text != "" && Convert.ToDouble(this.txtTotalAtividade.Text) > 0)
                    {
                        MtCalculaDifHora(Convert.ToDouble(this.txtDifTotal.Text), Convert.ToDouble(this.txtTotalAtividade.Text));
                        this.txtTotalHoras.Text = resultCalc.ToString();
                        MtCalculaDifMin(Convert.ToDouble(this.txtDifTotal.Text), Convert.ToDouble(this.txtTotalAtividade.Text));
                        this.txtTotalMinutos.Text = resultCalc2.ToString();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Verifique o valor total das atividades ou informe zero (0) ou retire o valor informado no campo Diferencia X Total \n").ToUpper());
                        return;
                    }
                }
                else
                {
                    if (this.txtHoras.Text != "" && Convert.ToDouble(this.txtHoras.Text) > 0)
                    {
                        MtCalculaMinutos(Convert.ToDouble(this.txtHoras.Text));
                        this.txtTotalMinutos.Text = resultCalc.ToString();
                    }
                    if (this.txtMinutos.Text != "" && Convert.ToInt32(this.txtMinutos.Text) > 0)
                    {
                        MtCalculaHoras(Convert.ToInt32(this.txtMinutos.Text));
                        this.txtTotalHoras.Text = resultCalc.ToString();
                    }
                }
            }
            catch (Exception or)
            {
                MessageBox.Show(string.Format("Verifique os valores Digitados \n{0}", or).ToUpper());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tsmInfoProd_Click(object sender, EventArgs e)
        {
            Form InfoProd = new frmAbertura();
            InfoProd.Show();
        }

        private void tsmRegRemetente_Click(object sender, EventArgs e)
        {
            Form RegRemet = new frmRegRemetente();
            RegRemet.Show();
        }

        private void frmRegAtividades_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Rjt = new frmRjt();
            Rjt.Show();
        }

        private void buscarRJTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form BuscaRjt = new frmBuscaRjt();
            BuscaRjt.Show();
        }

    }
}
