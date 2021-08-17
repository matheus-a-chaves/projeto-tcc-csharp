using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // Biblioteca da conexão do SQL.
using MySql.Data.MySqlClient; // Biblioteca da conexão do SQL.
namespace Bly_enterprise
{
    class Orientacao : conexao
    {
        private string Senha;
        private string Email;
        private string Userfoto;
        private string codigodeExecu;

        private string Codexcluir;

        public string _senha
        {
            get
            {
                return Senha;
            }
            set
            {
                Senha = value;
            }
        }
        public string _email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
        public string _UserFoto
        {
            get
            {
                return Userfoto;
            }
            set
            {
                Userfoto = value;
            }
        }
        public string _Codexcluir
        {
            get
            {
                return  Codexcluir;
            }
            set
            {
                Codexcluir = value;
            }
        }

        public string _codigodeExecu
        {
            get
            {
                return codigodeExecu;
            }
            set
            {
                codigodeExecu = value;
            }
        }

        public void atualizar()
        {
            string query = "UPDATE login set Login_Senha ='" + _senha + "' Where Login_Email ='" + _email + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

            
        }

        public void atualizarFoto()
        {
            string query = "UPDATE usuario set Usuario_Foto ='" + _UserFoto + "' Where Usuario_CodLogin ='" + _email + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }

        }

        public void exluirRota()
        {

                
                
                
                    string query = "Delete from " + _codigodeExecu +"  = " + _Codexcluir;

                    if (this.abrirconexao() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conectar);
                    cmd.ExecuteNonQuery();
                    this.fecharconexao();
                    }
                



        }

 


    }
}
