using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta
{
    public class Ferramenta
    {
        public int Idferramenta { get; set; }
        public string Nome { get; set; }
        public string Fornecedor { get; set; }
        public char Distribuicao { get; set; }
        public DateTime Dtcadastro { get; set; }
        public string Siteoficial { get; set; }
        public int Categoria_idcategoria { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFerramenta;
            DataTable dtFerramenta = new DataTable();
            try
            {
                daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA", MainForm.conexao);
                daFerramenta.Fill(dtFerramenta);
                daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
                return dtFerramenta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand myCommand;

                myCommand = new SqlCommand(@"INSERT INTO FERRAMENTA VALUES(
                @nome,@fornecedor,@distribuicao,@dtcadastro,@siteoficial,@categoria_idcategoria)", MainForm.conexao);

                myCommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@fornecedor", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                myCommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@categoria_idcategoria", SqlDbType.Int));

                myCommand.Parameters["@nome"].Value = Nome;
                myCommand.Parameters["@fornecedor"].Value = Fornecedor;
                myCommand.Parameters["@distribuicao"].Value = Distribuicao;
                myCommand.Parameters["@dtcadastro"].Value = Dtcadastro;
                myCommand.Parameters["@siteoficial"].Value = Siteoficial;
                myCommand.Parameters["@categoria_idcategoria"].Value = Categoria_idcategoria;

                retorno = myCommand.ExecuteNonQuery();

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Alterar()
        {
            int retorno = 0;


            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE FERRAMENTA SET nome = @nome,fornecedor=@fornecedor,distribuicao=@distribuicao," +
                    "dtcadastro=@dtcadastro, siteoficial=@siteoficial, categoria_idcategoria=@categoria_idcategoria " +
                    " WHERE idferramenta = @idferramenta", MainForm.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@fornecedor", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@categoria_idcategoria", SqlDbType.Int));

                mycommand.Parameters["@idferramenta"].Value = Idferramenta;
                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@fornecedor"].Value = Fornecedor;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = Dtcadastro;
                mycommand.Parameters["@siteoficial"].Value = Siteoficial;
                mycommand.Parameters["@categoria_idcategoria"].Value = Categoria_idcategoria;

                retorno = mycommand.ExecuteNonQuery();

                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Excluir()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM FERRAMENTA WHERE idferramenta=@idferramenta", MainForm.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommand.Parameters["@idferramenta"].Value = Idferramenta;

                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

    }
}
