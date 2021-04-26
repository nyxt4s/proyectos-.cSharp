using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo11form
{
    class Class1
    {
        public static String Digito(String rut, String verificador)
        {

            rut = rut.Replace(".", "");
            int rut2 = Convert.ToInt32(rut);
            String digito = verificador;
            int contardeuno = 0;
            int contar = 2;
            int acumulador = 0;
            int division = 0;
            int dig = 0;
            String dig2 = "";
            while (rut2 != 0)
            {
                contardeuno = (rut2 % 10) * contar;
                acumulador = +(acumulador + contardeuno);
                rut2 = rut2 / 10;
                contar = contar + 1;
                if (contar == 8)
                {
                    contar = 2;
                }
            }
            division = acumulador % 11;

            if (division == 0)
            {
                division = 11;
            }
            dig = 11 - division;
            dig2 = Convert.ToString(dig);
            if (dig2 == "11")
            {
                dig2 = "k";
            }
            if (dig2 == digito)
            {
                return "rut valido";  //.Text = "rut valido";

            }
            else
            {
                return "rut invalido"; // lblResultado.Text = "rut invalido";
            }
        }
    }
}
