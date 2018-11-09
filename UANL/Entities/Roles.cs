using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UANL.Entities
{
    public class Roles
    {
        public int id { get; set; }
        public string description { get; set; }

        public Roles()
        {
            this.id = 0;
            this.description = "";
        }
    }
}