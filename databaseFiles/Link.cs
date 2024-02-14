using DatabazeMineraly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_database.databaseFiles
{
    public class Link : IBaseClass
    {
        private int id;
        private int CZid;
        private int ENid;

        public Link(int id, int cZid1, int eNid1)
        {
            Id = id;
            CZid1 = cZid1;
            ENid1 = eNid1;
        }

        public Link()
        { 
        }

        public int Id { get => id; set => id = value; }
        public int CZid1 { get => CZid; set => CZid = value; }
        public int ENid1 { get => ENid; set => ENid = value; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
