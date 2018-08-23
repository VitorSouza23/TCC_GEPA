﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepa.DAO
{
    public abstract class AbstractDAO
    {
        protected DbConnection DbConnectioOject { get; set; }

        protected AbstractDAO(DbConnection dbConnectioOject)
        {
            DbConnectioOject = dbConnectioOject;
        }
    }
}
