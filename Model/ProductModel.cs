﻿namespace Model
{
   /// <summary>
   /// Classe responsável por criar o objeto produto.
   /// </summary>
   public class ProductModel
   {
      public int codproduct { get; set; } //Código do produto
      public string typeproduct { get; set; } //Tipo do produto
      public string descriptionproduct { get; set; } //Modelo do produto
      public string providerproduct { get; set; } //Fornecedor do produto (marca)
      public string sizeproduct { get; set; } //Tamanho do produto
      public decimal valueproduct { get; set; } //Valor unitário do produto
      public string storageproduct { get; set; } //Local onde está o produto
      public string imageproduct { get; set; } //Endereço local da imagem
      public int statusproduct { get; set; } //Status do produto (ativo/inativo)


   }
}
