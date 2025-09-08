using System;

class Program
{
    static string decodificar(string fraseCodificada)
    {
        int n = fraseCodificada.Length;
        int pos = 0;
        char[] decodifica = new char[n];

        for (int i = 0; i < n; i++)
        {
            if (fraseCodificada[i] == 'p' && i + 1 < n && fraseCodificada[i + 1] != ' ')
            {
                
                decodifica[pos] = fraseCodificada[i + 1];
                pos++;
                i++; 
            }
            else if (fraseCodificada[i] != 'p')
            {
                decodifica[pos] = fraseCodificada[i];
                pos++;
            }
        }

        // Cria a string só com os caracteres válidos
        return new string(decodifica, 0, pos);
    }

    static void Main()
    {
        Console.WriteLine("Entre com uma frase codificada:");
        string frase = Console.ReadLine();
        Console.WriteLine("Frase decodificada: " + decodificar(frase));
    }
}
