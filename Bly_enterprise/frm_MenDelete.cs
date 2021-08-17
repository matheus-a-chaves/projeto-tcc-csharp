using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bly_enterprise
{
    public partial class frm_MenDelete : Form
    {
        public frm_MenDelete()
        {
            InitializeComponent();
            
        }
        public static string atualizar; 
        
        private void button2_Click(object sender, EventArgs e)
        {
                 
            if (TelaRotDel.banco == "rota")
            {
               
                Orientacao R = new Orientacao();

                R._codigodeExecu = " rota where codigo_rota ";
                R._Codexcluir = TelaRotDel.codigo;
                R.exluirRota();
                atualizar = "0";
         
            }
            else if (TelaSaldoDel.banco == "saldo")
            {
                Orientacao R = new Orientacao();

                R._codigodeExecu = "saldo where Saldo_Codigo";
                R._Codexcluir = TelaSaldoDel.codigo;
                R.exluirRota();
                atualizar = "0";
          
            }
            else if (TelaUsuarioDel.banco == "usuario")
            {
                Orientacao R = new Orientacao();

                R._codigodeExecu = "usuario where Usuario_Codigo" ;
                R._Codexcluir = TelaUsuarioDel.codigo;
                R.exluirRota();
                atualizar = "0";

            }
           
            Close();
               

               

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
