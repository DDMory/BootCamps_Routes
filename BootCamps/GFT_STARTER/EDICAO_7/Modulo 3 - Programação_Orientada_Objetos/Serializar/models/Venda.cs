using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace Serializar.models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public String Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        
    }
}