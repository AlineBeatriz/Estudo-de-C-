using System;

class Aula03{
    static void Main(){

    //tipos primitivos de dados:
        byte n1 = 10; //(byte) recebe valores inteiros, sem sinal.
        int num = 0; //o tipo (int) recebe valores Inteiros com sinal, o nome da variavel (num), atribuindo o valor a variavel (=0)
        double num2 = 10; //para números
        char letra = 'c';//(char) para armazenar caracter com '', só pode conter 1.
        float valor = 5.3f; //ponto flutuante, para valores Reias. Double também
        string nome = "Aline"; //conjunto de caracteres, pode conter varios.
        var aux = nome; //tipo de variavel não é expecifica.

        Console.WriteLine(aux, num , n1,num2 , letra, valor);



    }
}