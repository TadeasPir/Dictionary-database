﻿using DatabazeMineraly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_database.databaseFiles
{
    public class ENdictionary : IBaseClass
    {
        private int id;
        private string slovo;

        public ENdictionary()
        {
        }

        public ENdictionary(int iD, string slovo)
        {
            ID = iD;
            Slovo = slovo;
        }

        public int ID { get => id; set => id = value; }
        public string Slovo { get => slovo; set => slovo = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
