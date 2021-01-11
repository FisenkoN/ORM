using ORM.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Tables
    {
        public ArrayList List { get; set; }

        public void Add(ITable table)
        {
            List.Add(table);
        }

        public ArrayList GetAll()
        {
            return List;
        }

        public void Delete(Table table)
        {
            List.Remove(table);
        }

    }
}
