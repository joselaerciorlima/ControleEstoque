using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controller
{
  public class ProductController
   {
		/// <summary>
		/// Método responsável por salvar os valores dentro do objeto Produto no banco de dados para cadastrar.
		/// </summary>
      public int Register(ProductModel product)
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
