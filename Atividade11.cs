using System;

class Atividade11
{
    static void Main()
    {
        string mensagem = Console.ReadLine();
        string resultado = "";

        for (int i = 0; i < mensagem.Length; i++)
        {
            if (mensagem[i] == 'p' && i + 1 < mensagem.Length && mensagem[i + 1] != ' ')
            {
                resultado = resultado + mensagem[i + 1];
                i++;
            }
            else if (mensagem[i] != 'p')
            {
                resultado = resultado + mensagem[i];
            }
        }

        Console.WriteLine(resultado);
    }
}