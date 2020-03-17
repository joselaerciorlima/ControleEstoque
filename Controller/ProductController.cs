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
				string query = "INSERT INTO TBPRODUCT (typeproduct,modelproduct,providerproduct,sizeproduct,valueproduct,storageproduct,imageproduct,logproduct) VALUES(@typeproduct,@modelproduct,@providerproduct,@sizeproduct,@valueproduct,@storageproduct,@imageproduct,@logproduct)";

				SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

				command.Parameters.AddWithValue("@typeproduct", product.typeproduct);
				command.Parameters.AddWithValue("@modelproduct", product.modelproduct);
				command.Parameters.AddWithValue("@providerproduct", product.providerproduct);
				command.Parameters.AddWithValue("@sizeproduct", product.sizeproduct);
				command.Parameters.AddWithValue("@valueproduct", product.valueproduct);
				command.Parameters.AddWithValue("@storageproduct", product.storageproduct);
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

		public int GetNewCodProduct()
		{
			try
			{
				string query = "SELECT MAX(codproduct) AS codproduct FROM TBPRODUCT";

				SqlCommand command = new SqlCommand(query, connectionDataBase.Conect());

				return Convert.ToInt32(command.ExecuteScalar());
			}
			catch (Exception)
			{

				throw;
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

			}
		}

		/// <summary>
		/// Método responsável por fazer uma busca no banco de dados de acordo com o filtro ativado.
		/// </summary>
		public DataTable Search(string filter, string filterType)
		{
			try
			{
				DataTable dt = new DataTable();
				return dt;
			}
			catch (Exception error)
			{

				throw error;
			}
			finally
			{

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
