﻿using System;
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
            string query = "INSERT INTO TBPRODUCT (typeproduct,descriptionproduct,providerproduct,sizeproduct,valueproduct,storageproduct,imageproduct)" +
               "VALUES(@typeproduct,@descriptionproduct,@providerproduct,@sizeproduct,@valueproduct, @storageproduct,@imageproduct);" +
               "INSERT INTO TBLOG (datelog,userlog,descriptionlog) " +
               "VALUES (@datelog, @userlog,@descriptionlog)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
            command.Parameters.AddWithValue("@descriptionproduct", product.descriptionproduct);
            command.Parameters.AddWithValue("@providerproduct", product.providerproduct);
            command.Parameters.AddWithValue("@sizeproduct", product.sizeproduct);
            command.Parameters.AddWithValue("@valueproduct", product.valueproduct);
            command.Parameters.AddWithValue("@storageproduct", product.storageproduct);
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
               "descriptionproduct = @descriptionproduct, providerproduct = @providerproduct," +
               "sizeproduct = @sizeproduct, valueproduct = @valueproduct, storageproduct = @storageproduct, imageproduct = @imageproduct, statusproduct = @statusproduct WHERE codproduct = @codproduct ; INSERT INTO TBLOG (datelog,userlog,descriptionlog) VALUES (@datelog, @userlog, @descriptionlog)";

            SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

            command.Parameters.AddWithValue("@codproduct", product.codproduct);
            command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
            command.Parameters.AddWithValue("@descriptionproduct", product.descriptionproduct);
            command.Parameters.AddWithValue("@providerproduct", product.providerproduct);
            command.Parameters.AddWithValue("@sizeproduct", product.sizeproduct);
            command.Parameters.AddWithValue("@valueproduct", product.valueproduct);
            command.Parameters.AddWithValue("@storageproduct", product.storageproduct);
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
      public DataTable Search(string filter, string filterType)
      {
         //SqlCommand command = new SqlCommand("SELECT typeproduct,modelproduct,providerproduct,sizeproduct,valueproduct,imageproduct FROM TBPRODUCT WHERE " + filterType + " LIKE '%" + filter + "%' ORDER BY typeproduct", connectionDataBase.Conect());

         string query = "SELECT p.codproduct,p.typeproduct,p.descriptionproduct,p.providerproduct," +
            "p.sizeproduct,p.valueproduct,p.storageproduct,p.imageproduct,p.statusproduct, " +
            "o.amount, (p.valueproduct * o.amount) as total " +
            "FROM TBPRODUCT as p FULL JOIN TBOPERATION as o ON p.codproduct = o.codproduct " +
            "WHERE " + filterType + " LIKE '%" + filter + "%'ORDER BY p.typeproduct";

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
