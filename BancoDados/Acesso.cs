using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;


namespace BancoDados
{
    public class Acesso:IDisposable
    {
        #region Cria e Abre a conexão
        SqlCeConnection conexao = new SqlCeConnection();

        public Acesso()
        {
            string endAplicacao = Directory.GetCurrentDirectory() + @"\DbRegistroAtividade.sdf";
            conexao.ConnectionString = string.Format(@"data source={0}", endAplicacao);
            conexao.Open();
        }
        #endregion

        #region Recebe as Query CRUD
        public SqlCeDataReader QuerySelect(string campos, string tabela, string condicao)
        {
            var querySelect = string.Format("select {0} from {1} where {2}", campos, tabela, condicao);
            return ExecutaComandoComRetorno(querySelect);
        }

        public SqlCeDataReader QuerySelect(string campos, string tabela)
        {
            var querySelect = string.Format("select {0} from {1}", campos, tabela);
            return ExecutaComandoComRetorno(querySelect);
        }

        public void QueryInsert(string tabela, string campos, string valores)
        {
            var queryInsert = string.Format("insert into {0} ({1}) values ({2})", tabela, campos, valores);
            ExecutaComando(queryInsert);
        }

        public void QueryUpdate(string tabela, string campo, string valor, string colunaCondicao, string valorCondicao)
        {
            var queryUpdate = string.Format("Update {0} set {1} = {2} where {3} = {4}", tabela, campo, valor, colunaCondicao, valorCondicao);
            ExecutaComando(queryUpdate);
        }

        public void QueryDelete(string tabela, string condicao)
        {
            var queryDelete = string.Format("delete from {0} where {1}", tabela, condicao);
            ExecutaComando(queryDelete);
        }
        #endregion

        #region Executa a Query
        private void ExecutaComando(string strQuery)
        {
            try
            {
                SqlCeCommand cmdComando = new SqlCeCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = conexao;
                cmdComando.ExecuteNonQuery();
                conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
                conexao.Close();
            }

        }
        #endregion

        #region Executa a Query com retorno
        private SqlCeDataReader ExecutaComandoComRetorno(string strQuery)
        {
               SqlCeCommand cmdComando = new SqlCeCommand(strQuery, conexao);
               return cmdComando.ExecuteReader();
        }
        #endregion


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
