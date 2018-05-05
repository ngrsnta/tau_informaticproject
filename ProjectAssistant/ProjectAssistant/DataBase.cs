using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProjectAssistant
{
    class DataBase
    {
        static string connetionString = "server=localhost;database=ProjectSystemDB;uid=root;pwd=ngrsnta;";
        MySqlConnection conn = new MySqlConnection(connetionString);
        string query;
        MySqlCommand myCommand;
        MySqlDataReader myReader;


        public void insert_toDatabase(string table, string coloumns, string values)
        {
            try
            {
                //sadece select insert delete update vb gibiler için fonksiyon yazıp students(studentId)
                //ve sonrası hep variable olarak olarak alınıcak böylece totalde 5-6 fonksiyonda bu iş tamam.
                query = "insert into " + table + "(" + coloumns + ") values(" + values + ");";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                }
                myReader.Close();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public string select_fromDatabase(string item, string table, string equal1, string equal2)
        {
            try
            {
                query = "select " + item + " from " + table + " where " + equal1 + " = " + equal2+";";
                string a = "";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    a = (string)myReader[item];
                }
                myReader.Close();
                conn.Close();
                return a;
            }
            catch(Exception e)
            {
               string a = e.Message;
               MessageBox.Show(e.Message);
                
               return a;
            }
        }

        public void update_toDatabase(string table, string item, string new_value)
        {
            try
            {
                query = "update " + table + " set " + item + " = " + new_value + ";";
                myCommand = new MySqlCommand(query, conn);
                myCommand.Connection.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
