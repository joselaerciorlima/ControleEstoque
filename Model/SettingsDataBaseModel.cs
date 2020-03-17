/// <summary>
/// Classe responsável pelas configurações do banco de dados.
/// </summary>
namespace Model
{
  public class SettingsDataBaseModel
   {
      public string Server { get; set; } //Endereço do servidor
      public string DataBase { get; set; } //Nome do banco de dados
      public string UserDataBase { get; set; } //Nome do usuário do banco de dados
      public string PassDataBase { get; set; } //Senha do usuário do banco de dados
   }
}
