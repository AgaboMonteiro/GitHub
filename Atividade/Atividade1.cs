using System;
using MinhaBiblioteca;

class Atividade1
{
   static void Main()
    {
        int n;
        Console.WriteLine("Tamanho do vetor");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
    }
}