using ORM.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class DbFramework
    {
        SqlConnection connection;

        Tables Tables;

        public string ConnectionString { get; init; }

        public DbFramework(string conStr)
        {
            ConnectionString = conStr;

            connection = new SqlConnection(ConnectionString);

            Tables = new Tables();
        }


        public void Open()
        {
            connection.Open();
        }

        public async Task OpenAsync()
        {
            await connection.OpenAsync();
        }

        public void Close()
        {
            connection.Close();
        }

        public async Task CloseAsync()
        {
            await connection.CloseAsync();
        }

        public void TestConnection()
        {
            try
            {
                // Открываем подключение
                Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                Close();
                Console.WriteLine("Подключение закрыто...");
            }
        }

        public async Task TestConnectionAsync()
        {
            try
            {
                // Открываем подключение
                await OpenAsync();
                Console.WriteLine("Подключение открыто асинхронно");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                await CloseAsync();
                Console.WriteLine("Подключение закрыто асинхронно...");
            }
        }

        public void GetInfoAboutDb()
        {
            Open();

            Console.WriteLine("Свойства подключения:");

            Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);

            Console.WriteLine("\tБаза данных: {0}", connection.Database);

            Console.WriteLine("\tСервер: {0}", connection.DataSource);

            Console.WriteLine("\tВерсия сервера: {0}", connection.ServerVersion);

            Console.WriteLine("\tСостояние: {0}", connection.State);

            Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);

            Close();
        }

        public async Task GetInfoAboutDbAsync()
        {
            await OpenAsync();

            Console.WriteLine("Свойства подключения:");

            Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);

            Console.WriteLine("\tБаза данных: {0}", connection.Database);

            Console.WriteLine("\tСервер: {0}", connection.DataSource);

            Console.WriteLine("\tВерсия сервера: {0}", connection.ServerVersion);

            Console.WriteLine("\tСостояние: {0}", connection.State);

            Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);

            await CloseAsync();
        }

        public void AddTable(string name, Dictionary<string, string> pairs)
        {
            Open();

            SqlCommand command = new SqlCommand();

            var com = "CREATE TABLE ";

            com += name;
            com += " (";


            foreach (var item in pairs)
            {
                com += item.Key;
                com += " ";

                com += item.Value;
                com += ", ";
            }
            
            com += ")";

            Console.WriteLine(com);

            command.CommandText = com;

            command.Connection = connection;

            command.ExecuteNonQuery();

            Close();
        }

        public void DeleteTable(string name)
        {
            Open();

            SqlCommand command = new SqlCommand();

            command.CommandText = "DROP TABLE " + name;

            command.Connection = connection;

            command.ExecuteNonQuery();

            Close();
        }

        public ICollection<Table> GetAll()
        {
            Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Table_1";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            var tables = new List<Table>();
            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                //Console.WriteLine("{0}\t{1}", reader.GetName(0), reader.GetName(1));
               
                while (reader.Read()) // построчно считываем данные
                {
                    
                    object id = reader.GetValue(0);
                    object name = reader.GetValue(1);
                    var table = new Table_1 { Id = (int)id, Name = name.ToString() };
                    tables.Add(table);
                    //Console.WriteLine("{0} \t{1}", id, name);
                }
            }

            reader.Close();
            Close();

            return tables;
        }
    }
}
