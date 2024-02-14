﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabazeMineraly
{
    public class MenuItem
    {
        private string description;
        private Action action;

        public MenuItem(string popis, Action akce)
        {
            this.description = popis;
            this.action = akce;
        }

        public override string ToString()
        {
            return description;
        }

        public void Execute()
        {
            action();
            //akce.Invoke();
        }
    }
}
