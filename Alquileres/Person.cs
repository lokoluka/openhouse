using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres
{
    
    class Person
    {
        [BsonId]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public string Comments { get; set; }

        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Id = "";
            this.Comments = "";
        }
    }
}
