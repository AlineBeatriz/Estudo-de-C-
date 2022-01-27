//Lendo valores do teclado.
using System;
class Aula08{
    static void Main(){
        string nome;

        Console.WriteLine("Digite seu nome: ");
        nome=Console.ReadLine();
    //Para poder ler o que vem do teclado: Read(Ler) e ReadLine(Leia e quebre a linha)
        Console.WriteLine("Nome digitado; " + nome);
    }
}