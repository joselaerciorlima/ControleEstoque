using System;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace Controller
{
   public class ConnectionDataBaseController
   {
      /// <summary>
      /// Carrega as configurações do banco de dados armazenadas no arquivo de configuração. Essas informações são passadas através de variáveis.
      /// </summary>
      string parameters = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
          Properties.Settings.Default.server,            //Endereço do servidor
          Properties.Settings.Default.dataBase,          //Nome do banco de dados
          Properties.Settings.Default.userDataBase,      //Usuário do banco de dados
          Properties.Settings.Default.passDataBase);     //Senha do banco de dados

      SqlConnection connection = null;

      /// <summary>
      /// Método responsável por carregar as informações salvas no objeto de configuração do banco de dados para dentro das variáveis do arquivo de configuração.
      /// </summary>
      public SettingsDataBaseModel LoadSettings()
      {
         SettingsDataBaseModel settingsDataBase = new SettingsDataBaseModel();
         settingsDataBase.Server = Properties.Settings.Default.server;
         settingsDataBase.DataBase = Properties.Settings.Default.dataBase;
         settingsDataBase.UserDataBase = Properties.Settings.Default.userDataBase;
         settingsDataBase.PassDataBase = Properties.Settings.Default.passDataBase;

         return settingsDataBase;
      }

      /// <summary>
      /// Método responsável por salvar os valores do objeto de configuração do banco de dados dentro do arquivo de configuração mesmo após o projeto ter sido compilado.
      /// </summary>
      public bool SaveSettings(SettingsDataBaseModel settingsDataBase)
      {
         try
         {
            Properties.Settings.Default.server = settingsDataBase.Server;
            Properties.Settings.Default.dataBase = settingsDataBase.DataBase;
            Properties.Settings.Default.userDataBase = settingsDataBase.UserDataBase;
            Properties.Settings.Default.passDataBase = settingsDataBase.PassDataBase;

            Properties.Settings.Default.Save();

            return true;
         }
         catch (Exception error)
         {
            throw error; //Em caso de erro, mostra a mensagem para quem o chamou.
         }
      }
      /// <summary>
      /// Método responsável por abrir a conexão com o banco de dados.
      /// </summary>
      public SqlConnection Conect()
      {
         try
         {
            connection = new SqlConnection(parameters);
            if (connection.State == ConnectionState.Closed)
            {
               connection.Open();
            }

            return connection;

         }
         catch (Exception error)
         {
            connection.Close();
            throw error;
         }
      }

      /// <summary>
      /// Método responsável por fechar a conexão com o banco de dados.
      /// </summary>
      public void Disconect()
      {
         connection.Close();
      }
   }
}
