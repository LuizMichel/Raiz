using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class CheckModelo
    {
        private int Codigo;
        public int IdCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public string razaoSocial;
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
