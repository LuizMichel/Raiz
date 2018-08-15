using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using DAL;
using System.Collections;

namespace BLL
{
    public class CheckBLL
    {

        public List<CheckModelo> listar4(List<CheckModelo> lista)
        {
            CheckDAL obj = new CheckDAL();
            List<CheckModelo> lista2 = new List<CheckModelo>();
            lista2 = obj.Listar4(lista2);
            return lista2;
        }


        public ArrayList Listar()
        {
            CheckDAL obj = new CheckDAL();
            return obj.Listar();
        }

        public ArrayList listar2(string razao)
        {
            
            CheckDAL obj = new CheckDAL();
            return obj.lista2(razao);
        }

        public void listar3(CheckModelo codigo)
        {
            CheckDAL obj = new CheckDAL();
            obj.lista3(codigo);
        }

        public void excluir(CheckModelo cli)
        {
            CheckDAL obj = new CheckDAL();
            obj.excluir(cli);
        }

        public void incluir(CheckModelo check, char verifica)
        {
            if (check.RazaoSocial.Trim().Length == 0)
            {
                throw new Exception("Preencher o campo 'Razao Social' Corretamente!");
            }

            if (check.Endereco.Trim().Length == 0)
            {
                throw new Exception("Preencher o campo 'Endereço' Corretamente!");
            }

            CheckDAL obj = new CheckDAL();
            obj.incluir(check, verifica);
        }
    }
}
