using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Configuration;

namespace BancoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlCeConnection cn = new SqlCeConnection( @"Data Source=c:\DbAplication.sdf; password=''");
            cn.Open();

            try
            {
                SqlCeCommand bc = new SqlCeCommand();
                bc.CommandText = (@"INSERT INTO Reg (Id, Regularizando, Data, Motivo, HoraInicio, HoraFim) 
                                VALUES (04, 'teste2', '09/09/2015', 'testes2', '11', '12')");
                bc.CommandType = CommandType.Text;
                bc.Connection = cn;
                bc.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception on)
            {
                MessageBox.Show(on.Message);
                cn.Close();
            }


            cn.Open();
            SqlCeCommand dc = new SqlCeCommand();
            try
            {

                dc.CommandText = "select * from reg";
                dc.CommandType = CommandType.Text;
                dc.Connection = cn;
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }

            SqlCeDataReader rd;
            rd = dc.ExecuteReader();


            while (rd.Read())
            {
                MessageBox.Show(string.Format(@"Regularizando:  {0}, Data:  {1}, Motivo:  {2}, Hora Inicio:    {3}, Hora Fim{4}", rd["Regularizando"], rd["Data"], rd["Motivo"], rd["HoraInicio"], rd["HoraFim"]));
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
