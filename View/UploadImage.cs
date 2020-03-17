using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace View
{
   public class UploadImage
   {
		string newLocation;
		//=============================================================================================
		public void CreateFolder()
		{
			//Recupera o caminho de onde o programa está sendo executado.
			string caminhoApp = Assembly.GetExecutingAssembly().CodeBase;

			//Recupera o caminho do diretório que está o programa.
			caminhoApp = Path.GetDirectoryName(caminhoApp);

			//Junta o caminho do diretório que está o programa com o nome do diretório a ser criado.
			newLocation = Path.Combine(caminhoApp, "Imagens");

			//Recupera todo o texto a partir do caractere informado.
			newLocation = newLocation.Substring(newLocation.IndexOf("C"));

			//Instância a classe DirectoryInfo passando o novo caminho que deverá ser criado o diretório.
			DirectoryInfo directoryInfo = new DirectoryInfo(newLocation);
			try
			{
				//Verifica se o diretório já existe, caso positivo, sai do método.
				if (directoryInfo.Exists)
				{
					return;
				}

				//Cria o diretório no caminho informado caso ele não exista.
				directoryInfo.Create();
			}
			catch (Exception error)
			{
				throw error;
			}
		}
		//=============================================================================================
		public string Upload()
      {
			OpenFileDialog fileDialog = new OpenFileDialog();

			string imagePath = "";

			try
			{
				if (fileDialog.ShowDialog() == DialogResult.OK)
				{
					imagePath = fileDialog.FileName;
				}
				return imagePath;
			}
			catch (Exception error)
			{
				throw error;
			}
      }
		//=============================================================================================
		public string SaveImage(string codeProduct,string imageLocation)
		{
			string imageName = "CODPROD_" + codeProduct + ".jpg";

			try
			{
				string destinationPath = Path.Combine(newLocation, imageName);

				File.Copy(imageLocation, destinationPath);

				return destinationPath;
			}
			catch (Exception error)
			{
				throw error;
			}
		}
   }
}
