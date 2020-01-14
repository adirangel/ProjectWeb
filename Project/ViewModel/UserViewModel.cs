using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.ViewModel
{
    public class UserViewModel
    {
        public Account userName { get; set; }
        public List<Account> usersName { get; set; }
    }
}