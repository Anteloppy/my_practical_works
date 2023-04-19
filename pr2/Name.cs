using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Names
    {
        private string _name;
        public string Name
        { get => _name;  private set => _name = value;}
        public Names(string Name)
        { _name = Name; }
    }
}
