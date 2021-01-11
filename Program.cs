using System;
using System.Collections.Generic;

namespace ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Data Source = DESKTOP-8TNDF2C\SQLEXPRESS; Initial Catalog = test_orm; Integrated Security = True";
            
            var db = new DbFramework(conStr);

            ////Work
            //Console.WriteLine(db.ConnectionString);

            ////Work
            //db.TestConnection();

            ////Work
            //db.TestConnectionAsync().GetAwaiter().GetResult();

            ////Work
            //db.GetInfoAboutDb();

            ////Work
            //db.GetInfoAboutDbAsync().GetAwaiter().GetResult();

            ////Work
            //var voc = new Voc();
            //var dic = new Dictionary<string, string>();
            //{


            //    dic.Add("Id", voc.Pairs.GetValueOrDefault(typeof(int).Name));

            //    dic.Add("Name", voc.Pairs.GetValueOrDefault(typeof(string).Name));

            //    dic.Add("Age", voc.Pairs.GetValueOrDefault(typeof(int).Name));

            //    dic.Add("Siw", voc.Pairs.GetValueOrDefault(typeof(int).Name));

            //    dic.Add("Ge", voc.Pairs.GetValueOrDefault(typeof(string).Name));
            //}
            //db.AddTable("Person33", dic);

            ////Work
            //db.DeleteTable("Person139");
        }
    }
}
