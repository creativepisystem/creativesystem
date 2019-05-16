using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    public static class Validator
    {
        public static bool IsValidCpf(string cpf)
            {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
        public static bool IsValidCnh(string cnh)
        {
            cnh = cnh.Replace(" ", "");
            cnh = cnh.Replace("-", "");
            cnh = cnh.Replace(".", "");
            if(!new Regex("[0-9]").IsMatch(cnh))
            {
                return false;
            }
            if (cnh.Equals("11111111111") || cnh.Equals("22222222222") || cnh.Equals("33333333333")
                || cnh.Equals("44444444444") || cnh.Equals("55555555555") || cnh.Equals("66666666666")
                || cnh.Equals("77777777777") || cnh.Equals("88888888888") || cnh.Equals("99999999999")
                || cnh.Equals("00000000000"))
            {
                return false;
            }
            int acumulador = 0;
            int inc = 2;
            for( int i = 0; i < 9; i++)
            {
                acumulador = Math.Abs(Convert.ToInt32(cnh.Substring(i, 1))) * inc;
                inc++;
            }

            int d1 = (acumulador % 11 > 1 ? 11 - acumulador % 11 : 0);
            acumulador = d1 * 2;
            inc = 3;
            for (int i = 0; i < 9; i++)
            {
                acumulador += (Math.Abs(Convert.ToInt32(cnh.Substring(i, 1)))) * inc;
                inc++;
            }
            int d2 = (acumulador % 11 > 1 ? 11 - acumulador % 11 : 0);
            return (d1 == Math.Abs(Convert.ToInt32(cnh.Substring(9, 1)))
                && d2 == Math.Abs(Convert.ToInt32(cnh.Substring(10, 1))));
        }
        public static bool IsValidEmail(string email)
        {
            return (new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").IsMatch(email));
        }
    }
}
