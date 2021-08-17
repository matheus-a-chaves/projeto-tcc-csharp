using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Biblioteca da conexão do SQL.
using MySql.Data.MySqlClient; // Biblioteca da conexão do SQL.

namespace Bly_enterprise
{
    public partial class TelaRotDel : UserControl
    {
        public TelaRotDel()
        {
            InitializeComponent();

        }


        private void TelaRotDel_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select * from rota ";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MySqlConnection conn1 = null;
            string strConn1 = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
            conn1 = new MySqlConnection(strConn1);
            conn1.Open();
            string mSQL1 = "Select count(*) from rota ";
            MySqlCommand cmd1 = new MySqlCommand(mSQL1, conn1);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
            cmd1.Dispose();
            int registro;
            registro = count;





            string Cod, localS, localC, horarioS, horarioC, preco, empresa;
            int R = 0;
            int n = 0;
            for (int i = 0; i < registro; i++)
            {

                Cod = dt.Rows[R]["Codigo_rota"].ToString();
                localS = dt.Rows[R]["local_saida"].ToString();
                localC = dt.Rows[R]["local_destino"].ToString();
                horarioS = dt.Rows[R]["horario_saida"].ToString();
                horarioC = dt.Rows[R]["horario_chegada"].ToString();
                preco = dt.Rows[R]["preco"].ToString();
                empresa = dt.Rows[R]["empresa"].ToString();



                n = dgv_deletar.Rows.Add();
                dgv_deletar.Rows[n].Cells[0].Value = Cod;
                dgv_deletar.Rows[n].Cells[1].Value = localS;
                dgv_deletar.Rows[n].Cells[2].Value = localC;
                dgv_deletar.Rows[n].Cells[3].Value = horarioS;
                dgv_deletar.Rows[n].Cells[4].Value = horarioC;
                dgv_deletar.Rows[n].Cells[5].Value = preco;
                dgv_deletar.Rows[n].Cells[6].Value = empresa;
                R = R + 1;
            }


          
           

            dgv_deletar.BorderStyle = BorderStyle.None;
            dgv_deletar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_deletar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_deletar.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv_deletar.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgv_deletar.EnableHeadersVisualStyles = false;
            dgv_deletar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_deletar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_deletar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        public static string codigo, banco;
          public void excluirRegistro(int i)
          {   
                codigo = "" + dgv_deletar[0, i].Value;
                banco = "rota";
                frm_MenDelete MenDel = new frm_MenDelete();

                MenDel.Show();

               
          }

        

          private void exluir(object sender, EventArgs e)
          {
              excluirRegistro(dgv_deletar.CurrentRow.Index);
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
              if (frm_MenDelete.atualizar == "0")
              {
                 
            dgv_deletar.Rows.Clear();
            MySqlConnection conn = null;
            string strConn = @"Server=localhost;Database=tcc;Uid=root;Pwd='';Connect Timeout=30;";
            conn = new MySqlConnection(strConn);
            conn.Open();
            string mSQL = "Select * from rota ";
            MySqlCommand cmd = new MySqlCommand(mSQL, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); 

            MySqlConnection conn1 = null;
            string strConn1 = @"Server = localhost; Database=tcc; Uid=root;Pwd=''; Connect Timeout=30;";
            conn1 = new MySqlConnection(strConn1);
            conn1.Open();
            string mSQL1 = "Select count(*) from rota ";
            MySqlCommand cmd1 = new MySqlCommand(mSQL1, conn1);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
            cmd1.Dispose();
            int registro;
            registro = count;





            string Cod, localS, localC, horarioS, horarioC, preco, empresa;
            int R = 0;
            int n = 0;
            for (int i = 0; i < registro; i++)
            {

                Cod = dt.Rows[R]["Codigo_rota"].ToString();
                localS = dt.Rows[R]["local_saida"].ToString();
                localC = dt.Rows[R]["local_destino"].ToString();
                horarioS = dt.Rows[R]["horario_saida"].ToString();
                horarioC = dt.Rows[R]["horario_chegada"].ToString();
                preco = dt.Rows[R]["preco"].ToString();
                empresa = dt.Rows[R]["empresa"].ToString();



                n = dgv_deletar.Rows.Add();
                dgv_deletar.Rows[n].Cells[0].Value = Cod;
                dgv_deletar.Rows[n].Cells[1].Value = localS;
                dgv_deletar.Rows[n].Cells[2].Value = localC;
                dgv_deletar.Rows[n].Cells[3].Value = horarioS;
                dgv_deletar.Rows[n].Cells[4].Value = horarioC;
                dgv_deletar.Rows[n].Cells[5].Value = preco;
                dgv_deletar.Rows[n].Cells[6].Value = empresa;
                R = R + 1;
                frm_MenDelete.atualizar = "7";
            }
            
                
          }

          }

          
    }
}
