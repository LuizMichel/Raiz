using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dados
    {
        public static string StringConexao
        {
            get
            {
                return "Host=localhost;Username=postgres;Password=gervan001;Database=Cadastro";
            }
        }
    }
}
