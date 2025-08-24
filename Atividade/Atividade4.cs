using System;
using MinhaBiblioteca;

class Atividade4
{
    static int maiorElemento(int[] array)
    {
        int maiorElemento = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maiorElemento)
                maiorElemento = array[i];
        }
        return maiorElemento;
    }
    static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        Console.WriteLine($"\nMaior elemento do vetor: {maiorElemento(vetor)}");
    }
}