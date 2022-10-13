using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_OrdenaSegundaChava
{
    public class Dado
    {
        int chave1;

        public int Chave1 { get => chave1; set => chave1 = value; }

        public Dado(int chave1)
        {
            this.chave1 = chave1;
        }
    }
}
