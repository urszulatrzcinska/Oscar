﻿using Oscar.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscar.UI.WPF
{
    class DatabaseManager
    {
        private static readonly DatabaseManager _manager = new DatabaseManager();

        public static DatabaseManager Instance => _manager;

        //public UserRepository UserRepository => new UserRepository();

        private DatabaseManager()
        {
            Connection.Instance.SetConnection(@"server=localhost;Initial Catalog=Oscar;Integrated Security=True");
        }
    }
}