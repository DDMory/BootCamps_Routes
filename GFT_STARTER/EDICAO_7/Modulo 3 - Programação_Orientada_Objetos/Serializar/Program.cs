using Serializar.models;
using Newtonsoft.Json;

/*
    CONCEITOS:
    =================================================================================================================
    A serialização consiste na ideia de transformar objetos em fluxos de bytes para um armazenamento ou tramissão, 
    enquanto isso a deserialização é o inverso da serialização 
    
    JavaScript Notation Object (JSON): fromato de texto que segue sintaxe JavaScript, usado comumente para tramissão
    de dados entre aplicações.

*/

/*
============================
        SERIALIZAÇÃO
============================
*/

Console.WriteLine("\n\t\tSERIALIZAÇÃO\n\n");
Venda v1 = new Venda(1, "Refrigerante", 12.32M, DateTime.Now);
Venda v2 = new Venda(2, "Pipoca-doce", 7.5M, DateTime.Now);
Venda v3 = new Venda(3, "Caderno", 23.32M, DateTime.Now);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
File.WriteAllText("arquivos/venda.json", serializado);

Console.WriteLine(serializado);


List<Venda> vendasSerialização = new List<Venda>();

vendasSerialização.Add(v1);
vendasSerialização.Add(v2);
vendasSerialização.Add(v3);

string serializados = JsonConvert.SerializeObject(vendasSerialização, Formatting.Indented);
File.WriteAllText("arquivos/outrasVendas.json", serializados);

foreach (var item in vendasSerialização)
{
    Console.WriteLine($" {{ {item.Id}, {item.Produto}, {item.Preco}, {item.DataVenda} }}");
}
/*
============================
        DESERIALIZAÇÃO
============================
*/


Console.WriteLine("\n\t\tDESERIALIZAÇÃO\n\n");
string conteudoAruqivo = File.ReadAllText("arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoAruqivo);

foreach (Venda item in listaVenda)
{
    Console.WriteLine(
        $"ID: {item.Id}, " +
        $"PRODUTO: {item.Produto}, " +
        $"PRECO: {item.Preco}, " +
        $"DATA VENDA: {item.DataVenda}, " 
    );
}
