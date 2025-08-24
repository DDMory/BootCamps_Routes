Dictionary<String, string> dicionario = new Dictionary<String, string>();

dicionario.Add("SP", "São Paulo");
dicionario.Add("BA", "Bahia");
dicionario.Add("MG", "Minas Gerais");

foreach (KeyValuePair<String, String> item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Removendo a chave: BA");
dicionario.Remove("BA");

Console.WriteLine("Alterando Valor da chave: SP");
dicionario["SP"] = "São Paulino";

foreach (KeyValuePair<String, String> item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


string chave = "BA";
if (dicionario.ContainsKey(chave))
    Console.WriteLine($"Chave encontrada!!!!\nValor da chave: {dicionario[chave]}");
else
    Console.WriteLine("Chave não encontrada!!!!");