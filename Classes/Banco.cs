using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Academy
{
    class Usuario
    {
        public static Int32 N_ID;
        public static string T_Username;
        public static string T_Password;
        public static string T_Displayname;
    }
    class Banco
    {
        private static SQLiteConnection conexao;
        #region MessageBox
        public static void MError(string error)
        {
            MessageBox.Show(error, "[Academy]", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MInformation(string message)
        {
           // MessageBox.Show(message, "[Academy]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool MQuestion(string question)
        {
            DialogResult dialog = MessageBox.Show(question, "[Academy]", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                return true;
            }else
            {
                return false;
            }
        }
        #endregion
        #region Basededados workout
        private static SQLiteConnection ConexaoBanco()
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent((Directory.GetParent(CurrentDirectory).ToString())).ToString();
            conexao = new SQLiteConnection("Data Source=" + path + "\\Basededados\\Database.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable dql(string sql) //Data Query Language (Select - Como é select é preciso dar return numa DataTable)
        {
            SQLiteDataAdapter da = null; // Serve para enviar comandos para a database (base de dados)
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt); // A table 'dt' vai ter todos os users da table tb_users
                    ConexaoBanco().Close();
                    return dt; //return da table 'dt'
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                ConexaoBanco().Close();
                return dt;

            }
        }

        public static void dml(string sql, string msgOK = null, string msgERRO = null) //Data Manipulation Language (insert, delete , update, replace - São comandos de alteração da database, por isso não é necessário dar return da DataTable)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                ConexaoBanco().Close();

                if (msgOK != null)
                {
                    //MessageBox.Show(msgOK, "Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }
        #endregion
        #region Users
        private static SQLiteConnection U_ConexaoBanco()
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent((Directory.GetParent(CurrentDirectory).ToString())).ToString();
            conexao = new SQLiteConnection("Data Source=" + path + "\\Basededados\\Database.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable U_dql(string sql) //Data Query Language (Select - Como é select é preciso dar return numa DataTable)
        {
            SQLiteDataAdapter da = null; // Serve para enviar comandos para a database (base de dados)
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = U_ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, U_ConexaoBanco());
                    da.Fill(dt); // A table 'dt' vai ter todos os users da table tb_users
                    U_ConexaoBanco().Close();
                    return dt; //return da table 'dt'
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                U_ConexaoBanco().Close();
                return dt;

            }
        }

        public static void U_dml(string sql, string msgOK = null, string msgERRO = null) //Data Manipulation Language (insert, delete , update, replace - São comandos de alteração da database, por isso não é necessário dar return da DataTable)
        {
            try
            {
                var cmd = U_ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                U_ConexaoBanco().Close();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }

        #endregion
    }
}
