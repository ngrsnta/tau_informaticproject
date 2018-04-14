using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectAssistant
{
    class DataBase
    {
        static string connetionString = "server=localhost;database=ProjectSystemDB;uid=root;pwd=ngrsanta;";
        MySqlConnection conn = new MySqlConnection(connetionString);
        string query;
        MySqlCommand myCommand;
        MySqlDataReader myReader;

        public void set_studentId(int id , string pass)
        {
            try
            {
                query = "insert into students(studentId, studentPassword) values(' " + id + "','" + pass + "');";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                }
                myReader.Close();
                conn.Close();
            }
            catch (Exception)
            {
                return;
            }
        }
        public string get_studentPass(int id)
        {
            try
            {
                query = "select studentPassword from students where studentId = '"+id+"';";
                string a = "";
                myCommand = new MySqlCommand(query, conn);
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    a = (string)myReader["studentPassword"];
                }
                myReader.Close();
                conn.Close();
                return a;
            }
            catch(Exception)
            {
               string a = "asd";
               return a;
            }
        }
    }
}
