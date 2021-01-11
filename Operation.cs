using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Operation<Entity>
    {
        SqlConnection connection;

        public Operation(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Entity entity)
        {
            throw new NotImplementedException();
        }

        //public ICollection<Entity> GetEntities()
        //{
            
        //}

        public Entity GetEntity()
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
