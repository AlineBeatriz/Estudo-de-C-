//Calculadora simples.
using System;
class calculadora{
    static void Main(){
        int v1,v2,soma;

        Console.Write("Digite o priemiro valor: " );
        v1=int.Parse(Console.ReadLine());
//O console.ReadLine(); esta retornando uma String e não Int.
//O Parse(Analisar) serve para converter a variável.
        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
//o Convert(Converter) é usado para converter a variável tbm. convert.ToInt32 <-indica pelo o que vc quer converter(de String para Int) e o 32 é tamanho do int-inteiro(aqui dentro do parêntese fica o que vc quer converter.)
        soma=v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}" ,v1,v2);
//Para poder ler o que vem do teclado: Read(Ler) e ReadLine(Leia e quebre a linha)
    }
}