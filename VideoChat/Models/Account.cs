using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VideoChat.Models
{
    [Table("Account")]
    public class Account
    {
        [Column("Password")]
        public string password { get; protected set; }

        [Column("Name")]
        public string userName { get; protected set; }

        [Column("Email")]
        public string email { get; protected set; }

        [Key]
        public int ID { get; protected set; }

        public Account(string password = "x", string username = "y", string email = "i", int id = 0)
        {
            this.password = password;
            this.userName = userName;
            this.email = email;
            this.ID = id;
        }

        public Account()
        { }
    }
}