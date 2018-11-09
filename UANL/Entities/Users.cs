using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UANL.Entities
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public Roles role { get; set; }

        public Users()
        {
            this.id = 0;
            this.name = "";
            this.username = "";
            this.pass = "";
            this.email = "";
            this.status = (int)DefaultValues.Status.Inactive;
            this.role = new Roles();
        }
    }
}