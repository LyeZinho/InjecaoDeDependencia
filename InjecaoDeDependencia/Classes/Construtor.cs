﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjecaoDeDependencia.Classes
{
    public interface IDbconectConstruc
    {
        dynamic GetData();
    }

    public class XDatabase : IDbconectConstruc
    {
        public dynamic GetData()
        {
            return new { name = "XDatabase" };
        }
    }

    public class YDatabase : IDbconectConstruc
    {
        public dynamic GetData()
        {
            return new { name = "YDatabase" };
        }
    }

    public class DbOperationCon
    {
        private IDbconectConstruc _dbconect;

        public DbOperationCon (IDbconectConstruc dbconect)
        {
            _dbconect = dbconect;
        }

        public dynamic GetData()
        {
            return _dbconect.GetData();
        }
    }
}
/*
DbOperationCon db = new DbOperationCon(new YDatabase());
Console.WriteLine(db.GetData().name); 
*/
