using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Security.Permissions;
using BancoDados;
using System.Data.SqlServerCe;


namespace RelatorioAtividades
{
    public partial class frmRegRemetente : Form
    {
        //Instancia Geral
        Acesso AcessaBancoDados = new Acesso();

        private string caminhoArq = @"C:\ArquivoConfig.txt";
        private string emailRemetente;
        private string senha;
        private string retorno;
        private string EmailArq;
        private string SenhaArq;
        private string nomeUsuario;
        private string campoNome;
        private string campoEmail;
        private string campoSenha;

        public frmRegRemetente()
        {
            InitializeComponent();
            Recebe(AcessaBancoDados.QuerySelect("*", "Usuario"));
            CampoRecebeValor();
            VerificaBotao(this.txtNomeUsuario.Text);
        }

        //Metodos da Classe
        //Metodo que pegara o valor digitado de email e senha
        private void RecebeRemetente()
        {
            emailRemetente = this.txtEmailRemetente.Text;
            senha = this.txtSenhaRemetente.Text;
            nomeUsuario = this.txtNomeUsuario.Text;
        }
        private void GravaArquivo(string Email, string Senha)
        {
            try
            {
                //Escreve ou cria Arquivo
                string EndAplicacao = Directory.GetCurrentDirectory() + @"\ArquivoConfig";
                //FileIOPermission FilePermission = new FileIOPermission(FileIOPermissionAccess.PathDiscovery, EndAplicacao);
                //FilePermission.Assert();
                StreamWriter ArquivoConfig = new StreamWriter(EndAplicacao);
                string Dados = string.Format("{0} {1}", Email, Senha);
                ArquivoConfig.WriteLine(Dados);
                ArquivoConfig.Close();
                MessageBox.Show("Gravado com sucesso!");
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }

        }
        private void LeArquivo(string Caminho)
        {
        }
        private void GravaDadosUsuario(string NomeUsuario, string Email, string Senha)
        {
            var stringValore = string.Format("'{0}', '{1}', '{2}'", NomeUsuario, Email, Senha);
            AcessaBancoDados.QueryInsert("Usuario", "Nome, Email, Senha", stringValore);
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
        private void CampoRecebeValor()
        {
            this.txtNomeUsuario.Text = campoNome;
            this.txtEmailRemetente.Text = campoEmail;
            this.txtSenhaRemetente.Text = campoSenha;
        }
        private void VerificaBotao(string valorCampoNome)
        {
            if (valorCampoNome != "")
            {
                this.btnSalvaRemetente.Text = "Alterar Dados";
            }
        }
        private void AtualizaCampos(string coluna, string novoValor, string colunaCondicao, string condicao)
        {
            AcessaBancoDados.QueryUpdate("usuario", coluna, novoValor, colunaCondicao, condicao);
        }

        public static void UpdateAppSettings(string chave, string valor)
        {

            // Open App.Config of executable

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Add an Application Setting.
            config.AppSettings.Settings.Remove(chave);

            config.AppSettings.Settings.Add(chave, valor);

            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void RetornaUsuario()
        {

            AcessaBancoDados.QuerySelect("*", "usuario");
        }




        private void btnSalvaRemetente_Click(object sender, EventArgs e)
        {
            if (this.btnSalvaRemetente.Text == "Alterar Dados")
            {
                var recebeValorAlterado = "";
                if (this.txtNomeUsuario.Text != campoNome)
                {
                    recebeValorAlterado = txtNomeUsuario.Text;
                    AtualizaCampos("Nome", recebeValorAlterado,"Nome", string.Format("'{0}'", campoNome));
                }
                else
                    if (this.txtEmailRemetente.Text != campoEmail)
                    {
                        recebeValorAlterado = this.txtEmailRemetente.Text;
                        AtualizaCampos("Email", recebeValorAlterado, "Nome", string.Format("'{0}'", campoNome));
                    }
                    else
                        if (this.txtSenhaRemetente.Text != campoSenha)
                        {
                            recebeValorAlterado = txtSenhaRemetente.Text;
                            AtualizaCampos("Senha", string.Format("'{0}'", txtSenhaRemetente.Text), "Nome", string.Format("'{0}'", campoNome));
                        }
            }
            else
            {
                //Verifica se o endereço de email tem @ e se a senha não esta vazia
                if (this.txtEmailRemetente.Text.Contains("@") && this.txtSenhaRemetente.Text != "")
                {
                    try
                    {
                        RecebeRemetente();
                        //GravaArquivo(emailRemetente, senha);
                        GravaDadosUsuario(nomeUsuario, emailRemetente, senha);
                        MessageBox.Show("Dados Gravados com Sucesso");
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show(Convert.ToString(Erro));
                    }
                }
                else
                {
                    //Verifica se o email é invalido
                    if (!this.txtEmailRemetente.Text.Contains("@"))
                    {
                        MessageBox.Show(string.Format(" O email {0} Digitado é invalido ", this.txtEmailRemetente.Text));
                        this.txtEmailRemetente.Focus();
                        return;
                    }
                    //Verifica se o campo senha foi preenchido.
                    if (this.txtSenhaRemetente.Text == "")
                    {
                        MessageBox.Show(string.Format("Digite sua senha"));
                        this.txtSenhaRemetente.Focus();
                        return;
                    }
                }
            }
            Close();
        }

        private void fmrRegRemetente_Load(object sender, EventArgs e)
        {



        }
    }
}
