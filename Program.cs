Console.Clear();


Console.WriteLine("Escreva uma frase para o Cebolinha falar: ");

string frase = Console.ReadLine()!;
string cebolinha = frase.Replace("R","L").Replace("r","l");

Console.WriteLine($"Cebolinha: {cebolinha}");

