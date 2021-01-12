using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
    class Table_1: ITable
    {
        public int Id { get; set; }
            
        public string Name { get; set; }

        [NotMapped]
        public string TableName { get; set; }

        [NotMapped]
        public int RowsCount { get; set; }

        public Table_1(List<object> objs)
        {
            Id = Convert.ToInt32(objs[0]);

            Name = Convert.ToString(objs[1]);

            //TableName = Convert.ToString(objs[2]);

            //RowsCount = Convert.ToInt32(objs[3]);
        }
    }
}
