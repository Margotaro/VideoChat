using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VideoChat.Models
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(string name)
        : base(name)
        {
        }

        public IDbSet<Account> accounts { get; set; }
    }
}