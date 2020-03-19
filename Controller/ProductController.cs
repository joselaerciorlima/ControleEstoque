using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Model;

namespace Controller
{
   public class ProductController
   {
      ConnectionDataBaseController connectionDataBase = new ConnectionDataBaseController();

      /// <summary>
      /// Método responsável por salvar os valores dentro do objeto Produto no banco de dados para cadastrar.
      /// </summary>
      public int Register(ProductModel product)
      {
         try
         {
            string query = "INSERT INTO TBPRODUCT (typeproduct,descriptionproduct,imageproduct)" +
               "VALUES(@typeproduct,@descriptionproduct,@imageproduct);" +
               "INSERT INTO TBLOG (datelog,userlog,descriptionlog) " +
               "VALUES (@datelog, @userlog,@descriptionlog)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
            command.Parameters.AddWithValue("@descriptionproduct", product.descriptionproduct);
            command.Parameters.AddWithValue("@imageproduct", product.imageproduct);

            command.Parameters.AddWithValue("@datelog", DateTime.Now);
            command.Parameters.AddWithValue("@userlog", "GESTOR");
            command.Parameters.AddWithValue("@descriptionlog", "CADASTRO DO PRODUTO");

            return Convert.ToInt32(command.ExecuteNonQuery());
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            connectionDataBase.Disconect();
         }
      }

      /// <summary>
      /// Método que retorna o último código cadastrado.
      /// </summary>
      /// <returns></returns>
      public int GetNewCodProduct()
      {
         try
         {
            string query = "SELECT IDENT_CURRENT('TBPRODUCT')";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            return Convert.ToInt32(command.ExecuteScalar());
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            connectionDataBase.Disconect();
         }
      }

      /// <summary>
      /// Método responsável por salvar os valores dentro do objeto Produto no banco de dados para atualizar de acordo com o código.
      /// </summary>
      public int Modify(ProductModel product)
      {
         try
         {
            string query = "UPDATE TBPRODUCT SET typeproduct = @typeproduct, " +
               "descriptionproduct = @descriptionproduct, imageproduct = @imageproduct, statusproduct = @statusproduct WHERE codproduct = @codproduct ; INSERT INTO TBLOG (datelog,userlog,descriptionlog) VALUES (@datelog, @userlog, @descriptionlog)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@codproduct", product.codproduct);
            command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
            command.Parameters.AddWithValue("@descriptionproduct", product.descriptionproduct);
            command.Parameters.AddWithValue("@imageproduct", product.imageproduct);
            command.Parameters.AddWithValue("@statusproduct", product.statusproduct);

            command.Parameters.AddWithValue("@datelog", DateTime.Now);
            command.Parameters.AddWithValue("@userlog", "GESTOR");
            command.Parameters.AddWithValue("@descriptionlog", "ATUALIZAÇÃO DO CADASTRO");

            return Convert.ToInt32(command.ExecuteNonQuery());
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            connectionDataBase.Disconect();
         }
      }

      /// <summary>
      /// Método responsável por fazer uma busca no banco de dados de acordo com o filtro ativado.
      /// </summary>
      public DataTable Search(string filter, string filterType,int operation)
      {
         string query;

         if (operation == 0)
         {
            query = "SELECT M.codmovement,O.typeoperation,M.dateoperation,ST.descriptionstorage,P.typeproduct,P.descriptionproduct,S.descriptionsize,M.amount,PR.descriptionprovider, M.valuetotal " +
            "FROM TBMOVEMENT AS M " +
            "INNER JOIN TBSTORAGE AS ST ON ST.codstorage = M.codstorage " +
            "INNER JOIN TBPRODUCT AS P  ON M.codproduct = P.codproduct " +
            "INNER JOIN TBSIZE AS S ON S.codsize = M.codsize " +
            "INNER JOIN TBPROVIDER AS PR ON PR.codprovider = M.codprovider " +
            "INNER JOIN TBOPERATION AS O ON O.codoperation = M.codoperation " +
            "WHERE " + filterType + " LIKE '%" + filter + "%'";
         }
         else
         {
            query = "SELECT M.codmovement,O.typeoperation,M.dateoperation,ST.descriptionstorage,P.typeproduct,P.descriptionproduct,S.descriptionsize,M.amount,PR.descriptionprovider, M.valuetotal " +
            "FROM TBMOVEMENT AS M " +
            "INNER JOIN TBSTORAGE AS ST ON ST.codstorage = M.codstorage " +
            "INNER JOIN TBPRODUCT AS P  ON M.codproduct = P.codproduct " +
            "INNER JOIN TBSIZE AS S ON S.codsize = M.codsize " +
            "INNER JOIN TBPROVIDER AS PR ON PR.codprovider = M.codprovider " +
            "INNER JOIN TBOPERATION AS O ON O.codoperation = M.codoperation " +
            "WHERE " + filterType + " LIKE '%" + filter + "%' AND O.codoperation = " + operation;
         }
         

         SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());
         
         try
         {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            connectionDataBase.Disconect();
         }
      }

      /// <summary>
      /// Método responsável por deletar o registro no banco de dados de acordo com o código.
      /// </summary>
      public int Remove(int codproduct,string imagePath)
      {
         try
         {
            string query = "DELETE FROM TBPRODUCT WHERE (codproduct = @codproduct); INSERT INTO TBLOG (datelog,userlog,descriptionlog) VALUES (@datelog, @userlog, @descriptionlog)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@codproduct", codproduct);

            command.Parameters.AddWithValue("@datelog", DateTime.Now);
            command.Parameters.AddWithValue("@userlog", "GESTOR");
            command.Parameters.AddWithValue("@descriptionlog", "PRODUTO DELETADO");

            if (File.Exists(imagePath))
            {
               File.Delete(imagePath);
            }

            return Convert.ToInt32(command.ExecuteNonQuery());
         }
         catch (Exception error)
         {
            throw error;
         }
         finally
         {
            connectionDataBase.Disconect();
         }
      }
   }
}
