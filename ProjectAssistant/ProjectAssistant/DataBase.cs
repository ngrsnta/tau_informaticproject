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
        static string connetionString = "server=localhost;database=ProjectSystemDB;uid=root;pwd=325630654Berk.;";
        MySqlConnection conn = new MySqlConnection(connetionString);
        string query;
        MySqlCommand myCommand;
        MySqlDataReader myReader;

        public void set_studentId(int id , string pass)
        {
            try
            {   
                //sadece select insert delete update vb gibiler için fonksiyon yazıp students(studentId)
                //ve sonrası hep variable olarak olarak alınıcak böylece totalde 5-6 fonksiyonda bu iş tamam.
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

        public void insert_toDatabase(string table, string coloumns, string values)
        {
            try
            {
                //sadece select insert delete update vb gibiler için fonksiyon yazıp students(studentId)
                //ve sonrası hep variable olarak olarak alınıcak böylece totalde 5-6 fonksiyonda bu iş tamam.
                query = "insert into ' " + table + "'(' " + coloumns + "') values(' " + values + "');";
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
        public string select_fromDatabase(string item, string table, string equal1, string equal2)
        {
            try
            {
                query = "select ' " + item + "' from ' " + table + "' where ' " + equal1 + "' = '" + equal2+"';";
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

        internal string get_studentPass(int v)
        {
            throw new NotImplementedException();
        }
    }
}
