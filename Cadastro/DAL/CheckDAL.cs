using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Npgsql;
using System.Collections;

namespace DAL
{
    public class CheckDAL
    {
        public List<CheckModelo> Listar4(List<CheckModelo> lista)
        {
            NpgsqlConnection con = null;
            try
            {
                con = new NpgsqlConnection(Dados.StringConexao);
                string strCmd = "SELECT * FROM Cadastro ORDER BY Codigo";
                NpgsqlCommand cmd = new NpgsqlCommand(strCmd, con);
                con.Open();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {                   
                    CheckModelo list = new CheckModelo();
                    list.IdCodigo = Convert.ToInt32(dr[0]);
                    list.razaoSocial = dr[1].ToString();
                    list.endereco = dr[2].ToString();
                    lista.Add(list);
                }
         
                return lista;
                
            }
            catch (NpgsqlException ex)
            {
                throw new NpgsqlException("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    
        public ArrayList Listar()
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = Dados.StringConexao;

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Cadastro ORDER BY Codigo";
            con.Open();

            NpgsqlDataReader dr = cmd.ExecuteReader();

            ArrayList lista = new ArrayList();
            while (dr.Read())
            {
                CheckModelo check = new CheckModelo();

                check.IdCodigo = Convert.ToInt32(dr[0]);
                check.RazaoSocial = dr[1].ToString();
                check.Endereco = dr[2].ToString();

                lista.Add(check);
            }
            dr.Close();
            con.Close();

            return lista;
        }

        public void incluir(CheckModelo check, char verifica)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            try
            {
                con.ConnectionString = Dados.StringConexao;

                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Cadastro " + "(Codigo, RazaoSocial, Endereco)" + "VALUES " + "(@Codigo, @RazaoSocial, @Endereco);";

                if(verifica == 'S')
                {
                    cmd.CommandText = "UPDATE Cadastro SET RazaoSocial = @RazaoSocial, Endereco = @Endereco WHERE Codigo = @Codigo";
                }

                cmd.Parameters.AddWithValue("@Codigo", check.IdCodigo);
                cmd.Parameters.AddWithValue("@RazaoSocial", check.RazaoSocial);
                cmd.Parameters.AddWithValue("@endereco", check.Endereco);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("erro" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public ArrayList lista2(string razao)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            con.ConnectionString = Dados.StringConexao;

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Codigo, RazaoSocial, Endereco FROM Cadastro WHERE RazaoSocial Like '%" + razao + "%' " + "ORDER BY Codigo";
            con.Open();

            NpgsqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista2 = new ArrayList();



            while (dr.Read())
            {
                CheckModelo check = new CheckModelo();
                check.IdCodigo = Convert.ToInt32(dr["Codigo"]);
                check.RazaoSocial = dr["RazaoSocial"].ToString();
                check.Endereco = dr["Endereco"].ToString();

                lista2.Add(check);
            }
            dr.Close();
            con.Close();
            return lista2;
        }

        public CheckModelo lista3(CheckModelo cli)
        {
            NpgsqlConnection con = new NpgsqlConnection();
            try
            {
                con.ConnectionString = Dados.StringConexao;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Cadastro WHERE Codigo = " + cli.IdCodigo;
                con.Open();

                NpgsqlDataReader dr = cmd.ExecuteReader();
                cli.RazaoSocial = null;
                cli.Endereco = null;

                if (dr.Read())
                {
                    cli.IdCodigo = Convert.ToInt32(dr[0]);
                    cli.RazaoSocial = dr[1].ToString();
                    cli.Endereco = dr[2].ToString();
                }
                return cli;
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void excluir(CheckModelo cli)
        {
            NpgsqlConnection con = new NpgsqlConnection();

            try
            {
                con.ConnectionString = Dados.StringConexao;
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM CADASTRO WHERE CODIGO = " + cli.IdCodigo;
                con.Open();

                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

