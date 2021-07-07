using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using System.Collections;
using System.Net.Mail;
using System.IO;
using System.Data.SqlServerCe;
using BancoDados;

namespace RelatorioAtividades
{
    public partial class frmEnvioEmail : Form
    {
        Acesso AcessaBancoDados = new Acesso();
        //Instancia publica
        //Form1 RegAtividade = new Form1();

        //Variaveis da Classe
        private string nomeUsuario = "luiz.felipe@deak.com.br";
        private string senha = "Sabrina100207";
        private string emailDestino; //"owlflee@gmail.com";
        private string assunto;
        private string textoEmail;
        private string recuperaTexto;
        private string textoEmailTratado;
        private int totalAtividades;
        private string retorno;
        private string EmailArq;
        private string SenhaArq;
        private string campoNome;
        private string campoEmail;
        private string campoSenha;

        //Atributos da classe
        private ArrayList atRecuperaAtividade = new ArrayList();
        private ArrayList atTempoAtividade = new ArrayList();
        private ArrayList atJustificativa = new ArrayList();

        //Propriedades Classe
        private ArrayList PrRecuperaAtividade { get { return atRecuperaAtividade; } set { atRecuperaAtividade = value; } }
        private ArrayList PrTempoAtividade { get { return atTempoAtividade; } set { atTempoAtividade = value; } }
        private ArrayList PrJustificativa { get { return atJustificativa; } set { atJustificativa = value; } }

        //Metodo Construtor
        public frmEnvioEmail(ArrayList registro, ArrayList tempo, int TotalTemp, ArrayList Justificativa)
        {
            InitializeComponent();
            for (int conta = 0; conta < registro.Count; conta++)
            {
                PrRecuperaAtividade.Add(registro[conta]);
                PrTempoAtividade.Add(tempo[conta]);
                PrJustificativa.Add(Justificativa[conta]);
            }
            totalAtividades = TotalTemp;
            DadosEmail(AcessaBancoDados.QuerySelect("*", "Usuario"));
        }
        public frmEnvioEmail()
        {
        }

        //Metodos do Form
        //Descoberta automática Dominio
        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            // The default for the validation callback is to reject the URL.
            bool result = false;

            Uri redirectionUri = new Uri(redirectionUrl);

            // Validate the contents of the redirection URL. In this simple validation
            // callback, the redirection URL is considered valid if it is using HTTPS
            // to encrypt the authentication credentials. 
            if (redirectionUri.Scheme == "https")
            {
                result = true;
            }
            return result;
        }
        private void Envio()
        {
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013_SP1);
            service.Credentials = new WebCredentials(campoEmail, campoSenha/*EmailArq, SenhaArq*/);
            service.TraceEnabled = true;
            service.TraceFlags = TraceFlags.All;
            service.UseDefaultCredentials = false;
            service.AutodiscoverUrl(campoEmail, RedirectionUrlValidationCallback);
            EmailMessage email = new EmailMessage(service);
            email.ToRecipients.Add(emailDestino);
            email.Subject = assunto;
            email.Body = new MessageBody(textoEmail);
            email.Send();
        }
        private void RecuperaAtividades()
        {
            string textoCab = string.Format("Atividades Realizadas ou Justificativa de Horas:\n");

            string TextoCorpAuse = "";
            string titJustAuse = "";
            int totAtivAuse = 0;
            string totAtivAuseText = "";

            string TextoCorpFerias = "";
            string titJustFerias = "";
            int totAtivFerias = 0;
            string totAtivFeriasText = "";

            string TextoCorpCapac = "";
            string titJustCapac = "";
            int totAtivCapac = 0;
            string totAtivCapacText = "";

            string TextoCorpGest = "";
            string titJustGest = "";
            int totAtivGest = 0;
            string totAtivGestText = "";

            string TextoCorpReun = "";
            string titJustReun = "";
            int totAtivReun = 0;
            string totAtivReunText = "";

            string TextoCorpOut = "";
            string titJustOut = "";
            int totAtivOut = 0;
            string totAtivOutText = "";



            var text = "";

            for (int conta = 0; conta < PrRecuperaAtividade.Count; conta++)
            {
                switch (PrJustificativa[conta].ToString())
                {
                    case "Ausência":
                        TextoCorpAuse += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                    case "Férias":
                        TextoCorpFerias += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                    case "Capacitação":
                        TextoCorpCapac += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                    case "Gestão":
                        TextoCorpGest += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                    case "Reunião":
                        TextoCorpReun += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                    case "Outros":
                        TextoCorpOut += string.Format("{0}\nDuração: {1} min\n", PrRecuperaAtividade[conta], PrTempoAtividade[conta]);
                        break;
                }
                if (PrJustificativa[conta].ToString() == "Ausência")
                {
                    titJustAuse = string.Format("\n{0}\n\n", PrJustificativa[conta]);
                    totAtivAuse += Convert.ToInt16(PrTempoAtividade[conta]);
                    totAtivAuseText = totAtivAuse.ToString();
                }
                else
                    if (PrJustificativa[conta].ToString() == "Férias")
                    {
                        titJustFerias = string.Format("\n\n{0}\n\n", PrJustificativa[conta]);
                        totAtivFerias += Convert.ToInt16(PrTempoAtividade[conta]);
                        totAtivFeriasText = totAtivFerias.ToString();
                    }
                    else
                        if (PrJustificativa[conta].ToString() == "Capacitação")
                        {
                            titJustCapac = string.Format("\n\n{0}\n\n", PrJustificativa[conta]);
                            totAtivCapac += Convert.ToInt16(PrTempoAtividade[conta]);
                            totAtivCapacText = totAtivCapac.ToString();
                        }
                        else
                            if (PrJustificativa[conta].ToString() == "Gestão")
                            {
                                titJustGest = string.Format("\n\n{0}\n\n", PrJustificativa[conta]);
                                totAtivGest += Convert.ToInt16(PrTempoAtividade[conta]);
                                totAtivGestText = totAtivGest.ToString();
                            }
                            else
                                if (PrJustificativa[conta].ToString() == "Reunião")
                                {
                                    titJustReun = string.Format("\n\n{0}\n\n", PrJustificativa[conta]);
                                    totAtivReun += Convert.ToInt16(PrTempoAtividade[conta]);
                                    totAtivReunText = totAtivReun.ToString();
                                }
                                else
                                    if (PrJustificativa[conta].ToString() == "Outros")
                                    {
                                        titJustOut = string.Format("\n\n{0}\n\n", PrJustificativa[conta]);
                                        totAtivOut += Convert.ToInt16(PrTempoAtividade[conta]);
                                        totAtivOutText = totAtivOut.ToString();
                                    }
            }
            if (totAtivAuseText == "0")
            {
                totAtivAuseText = "";
            }
            else
                if (totAtivAuseText != "")
            {
                text += (titJustAuse + TextoCorpAuse + string.Format("Duração Total da Justificativa: {0} min", totAtivAuseText));
            }
            if (totAtivFeriasText == "0")
            {
                totAtivFeriasText = "";
            }
            else
                if (totAtivFeriasText != "")
            {
                text += (titJustFerias + TextoCorpFerias + string.Format("Duração Total da Justificativa: {0} min", totAtivFeriasText));
            }
            if (totAtivCapacText == "0")
            {
                totAtivCapacText = "";
            }
            else 
                if (totAtivCapacText != "")
            {
                text += (titJustCapac + TextoCorpCapac + string.Format("Duração Total da Justificativa: {0} min", totAtivCapacText));
            }
            if (totAtivGestText == "0")
            {
                totAtivGestText = "";
            }
            else
                if (totAtivGestText != "")
            {
                text += (titJustGest + TextoCorpGest + string.Format("Duração Total da Justificativa: {0} min", totAtivGestText));
            }
            if (totAtivReunText == "0")
            {
                totAtivReunText = "";
            }
            else
                if (totAtivReunText != "")
            {
                text += (titJustReun + TextoCorpReun + string.Format("Duração Total da Justificativa: {0} min", totAtivReunText));
            }
            if (totAtivOutText == "0")
            {
                totAtivOutText = "";
            }
            else
                if (totAtivOutText != "")
            {
                text += (titJustOut + TextoCorpOut + string.Format("Duração Total da Justificativa: {0} min", totAtivOutText));
            }
            //text += (titJustAuse + TextoCorpAuse + string.Format("Duração Total da Justificativa: {0}", totAtivAuseText)) + (titJustFerias + TextoCorpFerias + string.Format("Duração Total da Justificativa: {0}", totAtivFeriasText))
            //    + (titJustCapac + TextoCorpCapac + string.Format("Duração Total da Justificativa: {0}", totAtivCapacText)) + (titJustGest + TextoCorpGest + string.Format("Duração Total da Justificativa: {0}", totAtivGestText))
            //    + (titJustReun + TextoCorpReun + string.Format("Duração Total da Justificativa: {0}", totAtivReunText)) + (titJustOut + TextoCorpOut + string.Format("Duração Total da Justificativa: {0}", totAtivOutText));
            recuperaTexto = string.Format("{0}\n{1}\nDuração Total das Atividades Realizadas ou Justificativa de Horas: {2} min", textoCab, text, totalAtividades);
        }
        private void TrataTextoEmail()
        {
            textoEmailTratado = string.Format(@"<pre>{0}</pre><br><br><br><br><br><font size=""1"">Enviado via Registro de Atividades</font> 
                                                <br> <font size=""1"">Desenvolvedor: Luiz Felipe</font>
                                                <br> <font size=""1"">Contato: felipe_Luiz@icloud.com</font>", rtbTextoEmail.Text);
        }
        private void LeArquivo()
        {
            string EndAplicacao = Directory.GetCurrentDirectory() + @"\ArquivoConfig";
            StreamReader ArquivoConfig = new StreamReader(EndAplicacao);
            while (!ArquivoConfig.EndOfStream)
            {
                retorno = ArquivoConfig.ReadLine();
                bool continua = false;
                for (int conta = 0; conta < retorno.Length; conta++)
                {
                    if (Convert.ToString(retorno[conta]) == " ")
                    {
                        continua = true;
                    }
                    else if (Convert.ToString(retorno[conta]) != " " && continua == false)
                    {
                        EmailArq += retorno[conta];
                    }
                    else if (Convert.ToString(retorno[conta]) != " " && continua == true)
                    {
                        SenhaArq += retorno[conta];
                    }

                }
            }
        }
        private void DadosEmail(SqlCeDataReader Rc)
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


        //Eventos Do Form
        private void EnvioEmail_Load(object sender, EventArgs e)
        {
            RecuperaAtividades();
            rtbTextoEmail.Text = recuperaTexto;
            this.txtDestinatario.Focus();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                //Metodo LeArquivo Substituido pelo metodoDadosemail.
                //LeArquivo();
                TrataTextoEmail();
                if (this.txtDestinatario.Text == "" || !this.txtDestinatario.Text.Contains("@"))
                {
                    MessageBox.Show(string.Format("O E-mail {0}, digitado é invalido", this.txtDestinatario.Text));
                    this.txtDestinatario.Focus();
                    return;
                }
                emailDestino = this.txtDestinatario.Text;
                assunto = this.txtAssunto.Text;
                textoEmail = textoEmailTratado.ToUpper();
                Envio();
                MessageBox.Show("Email enviado com Sucesso");
                Close();
            }
            catch (Exception erroMail)
            {
                MessageBox.Show(erroMail.Message);
            }
        }

        private void txtDestinatario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
