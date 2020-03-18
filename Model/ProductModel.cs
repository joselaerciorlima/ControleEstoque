namespace Model
{
   /// <summary>
   /// Classe responsável por criar o objeto produto.
   /// </summary>
   public class ProductModel
   {
      public int codproduct { get; set; } //Código do produto
      public string typeproduct { get; set; } //Tipo do produto
      public string descriptionproduct { get; set; } //Modelo do produto
      public string imageproduct { get; set; } //Endereço local da imagem
      public int statusproduct { get; set; } //Status do produto (ativo/inativo)


   }
}
