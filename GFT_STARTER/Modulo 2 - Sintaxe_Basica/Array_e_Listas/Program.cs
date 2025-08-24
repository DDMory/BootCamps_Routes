/* Array */
//Criar uma array
int[] numerosPare = new int[] { 2, 4, 6, 8, 10, 12 };

//percorrer esse vetor
//FOR
Console.WriteLine($"METODO FOR PARA PERCORRER ARRAYS");
for (int i = 0; i < numerosPare.Length; i++)
    Console.WriteLine($"[{i}] = {numerosPare[i]}");

//FOREACH
Console.WriteLine($"METODO FOREACH PARA PERCORRER ARRAYS");
foreach (var valor in numerosPare)
{
    Console.WriteLine(valor);
}

/* Lista */
List<String> listaPlavras = new List<String>();

//adicionar dados à lista
listaPlavras.Add("Arte");
listaPlavras.Add("Volei");
listaPlavras.Add("Ida");
listaPlavras.Add("Vinda");

//percorrer a lista
//For

Console.WriteLine($"METODO FOR PARA PERCORRER LISTAS");
for (int i = 0; i < listaPlavras.Count; i++)
    Console.WriteLine($"Palavra {i} = {listaPlavras[i]}");

//ForEach
Console.WriteLine($"METODO FOREACH PARA PERCORRER LISTAS");
foreach (string item in listaPlavras)
    Console.WriteLine($"Palavra = {item}");