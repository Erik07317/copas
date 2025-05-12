using System.Security.Cryptography;

int naipe = RandomNumberGenerator.GetInt32(1, 5);
string nomeNaipe = naipe switch
{
    1 => "Copas",
    2 => "Espadas",
    3 => "Ouros",
    4 => "Paus",
    _ => ""
};
Console.WriteLine(nomeNaipe);