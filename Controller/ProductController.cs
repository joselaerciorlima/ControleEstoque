using System;
using System.Data;
using System.Data.SqlClient;
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
            string query = "INSERT INTO TBPRODUCT (typeproduct,modelproduct,providerproduct,sizeproduct,valueproduct,imageproduct,logproduct) VALUES(@typeproduct,@modelproduct,@providerproduct,@sizeproduct,@valueproduct,@imageproduct,@logproduct)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
            command.Parameters.AddWithValue("@modelproduct", product.modelproduct);
            command.Parameters.AddWithValue("@providerproduct", product.providerproduct);
            command.Parameters.AddWithValue("@sizeproduct", product.sizeproduct);
            command.Parameters.AddWithValue("@valueproduct", product.valueproduct);
            command.Parameters.AddWithValue("@imageproduct", product.imageproduct);
            command.Parameters.AddWithValue("@logproduct", product.logproduct);

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
            string query = "SELECT MAX(codproduct) AS codproduct FROM TBPRODUCT";

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
            return 1;
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
      public DataTable Search(string filter, string filterType)
      {
         //SqlCommand command = new SqlCommand("SELECT typeproduct,modelproduct,providerproduct,sizeproduct,valueproduct,imageproduct FROM TBPRODUCT WHERE " + filterType + " LIKE '%" + filter + "%' ORDER BY typeproduct", connectionDataBase.Conect());

         SqlCommand command = new SqlCommand("SELECT p.codproduct,p.typeproduct,p.modelproduct,p.providerproduct,p.sizeproduct,p.valueproduct,p.imageproduct,p.statusproduct, w.amount, w.storage, (p.valueproduct * w.amount) as total FROM TBPRODUCT as p FULL JOIN TBWAREHOUSE as w ON p.codproduct = w.codproduct WHERE " + filterType + " LIKE '%" + filter + "%'ORDER BY typeproduct", connectionDataBase.Conect());

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
      public int Remove(int codproduct)
      {
         try
         {
            return 1;
         }
         catch (Exception error)
         {

            throw error;
         }
         finally
         {

         }
      }
   }
}
