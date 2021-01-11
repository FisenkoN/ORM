using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Models
{
    public interface ITable
    {
        public string TableName { get; set; }

        public int RowsCount { get; set; }
    }
}
