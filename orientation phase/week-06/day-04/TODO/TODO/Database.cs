using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace TODO
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=database.sqlite3");
            if (!File.Exists(@"C:\Users\Alex_GR\Desktop\Green Fox Academy\greenfox\AlexThanasis\week-06\day-04\TODO\TODO\bin\Debug\netcoreapp2.0\database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
                Console.WriteLine("Database created");
            }
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public static void Complete(int input, Database dbinput)
        {
            string query = "UPDATE todos SET completedAt = (@date) WHERE id = (@id)";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbinput.myConnection);
            dbinput.OpenConnection();
            myCommand.Parameters.AddWithValue("@date", DateTimeSQLite(DateTime.Now));
            myCommand.Parameters.AddWithValue("@id", input);
            myCommand.ExecuteNonQuery();
            dbinput.CloseConnection();
        }

        public static void Adding(string input, Database dbinput)
        {
            string query = "INSERT INTO todos (`text`, `createdAt`) VALUES (@text, @createdAt)";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbinput.myConnection);
            dbinput.OpenConnection();
            myCommand.Parameters.AddWithValue("@text", input);
            myCommand.Parameters.AddWithValue("@createdAt", DateTimeSQLite(DateTime.Now));
            myCommand.ExecuteNonQuery();
            dbinput.CloseConnection();
        }

        public static void Removing(int num, Database dbinput)
        {
            string query = "DELETE FROM todos WHERE id = (@id)";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbinput.myConnection);
            dbinput.OpenConnection();
            myCommand.Parameters.AddWithValue("@id", num);
            myCommand.ExecuteNonQuery();
            dbinput.CloseConnection();
        }

        public static void Loading(Database dbinput)
        {
            string query = "SELECT * FROM todos WHERE completedAt IS NULL";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbinput.myConnection);
            dbinput.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine("ID: {0} - Content: {1} - Created at: {2}, Completed at: {3}", 
                        result["id"], result["text"], result["createdAt"], result["completedAt"]);
                }
            }
            dbinput.CloseConnection();
        }

        public static void Clear(Database dbinput)
        {
            string query = "DELETE FROM todos";
            SQLiteCommand myCommand = new SQLiteCommand(query, dbinput.myConnection);
            dbinput.OpenConnection();
            myCommand.ExecuteNonQuery();
            dbinput.CloseConnection();
        }

        public static string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}";
            return string.Format(dateTimeFormat, datetime.Year,
                                 datetime.Month, datetime.Day,
                                 datetime.Hour, datetime.Minute);
        }
    }
}
