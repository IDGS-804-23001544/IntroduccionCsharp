using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroCsharp.Models
{
    public class MultSumas
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Res { get; set; }

        public string Procedimiento { get; set; }

        public void Multiplicar()
        {
            Res = 0;
            Procedimiento = "";

            for (int i = 0; i < B; i++)
            {
                Res += A;

                Procedimiento += A.ToString();

                if (i < B - 1)
                {
                    Procedimiento += "+";
                }
            }

            Procedimiento += " = " + Res;
        }
    }
}