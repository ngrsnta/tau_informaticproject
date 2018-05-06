﻿using System;
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
        static string connectionString = "server=localhost;database=ProjectSystemDB;uid=root;pwd=ngrsnta;";
        MySqlConnection conn = new MySqlConnection(connectionString);
        string query;
        int anyInt;
        MySqlCommand myCommand;
        MySqlDataReader myReader;

        //Database'de yeni bir girdi oluşturma
        public void insert_toDatabase(string table, string columns, string values)
        {
            try
            {
                query = "insert into " + table + " (" + columns + ") values(" + values + ");";
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
                    if (myReader[item].GetType() == a.GetType() || myReader[item].GetType() == anyInt.GetType())
                    {
                        a = Convert.ToString(myReader[item]);
                    }
                    else
                    {
                        a = Convert.ToString(myReader[item]);
                    }
                }
                myReader.Close();
                conn.Close();
                return a;
            }
            catch(Exception e)
            {
               string a = e.Message;
               MessageBox.Show(e.Message +"\n"+ e.ToString());
                
               return a;
            }
        }

        public void update_toDatabase(string table, string item, string new_value, string equal1, string equal2)
        {
            try
            {
                query = "update " + table + " set " + item + " = " + new_value + " where " + equal1 +" = "+ equal2+ ";";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        public void delete_fromDatabase(string table, string column, string id)
        {
            try
            {
                query = "delete from " + table + " where " + column + " = " + id + ";";
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
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
