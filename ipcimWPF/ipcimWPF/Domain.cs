using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipcimWPF
{
    internal class Domain
    {
        public Domain(string sor)
        {
            nev = sor.Split(';')[0];
            ip = sor.Split(';')[1];
        }

        public string nev { get; set; }
        public string ip { get; set; }
    }
}
