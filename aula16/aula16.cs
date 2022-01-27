//Comando goto(ir para): gera um desvio no nosso programa para um ponto determinado pelo LABEL.
/*onde destino pode ser um label (rótulo ou nome de um endereço) ou um número, que representa um determinado endereço. As instruções passam a ser executadas no endereço apontado por destino.*/
using System;

class aula16{
    static void Main(){
        int tempo;
        char escolha;
//usando o comando goto: o inicio
        //1º cria um label
        inicio:

        //para limpar o console.
        Console.Clear();

        Console.WriteLine("PE a MG");
        Console.WriteLine("Escolha o transporte:[a]Avião | [c]Carro | [o]Ônibus");

        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
                tempo=50;
                break;
            case 'c':
                tempo=480;
                break;
            case 'o':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte indisponivel");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos ",tempo);
        }
//dando a opção com o comando goto:
    console.Write("\nCalcular outro transporte?[s/n]")
    //opção:
    escolha=char.Parse(console.ReadLine());
    if(escolha=='s' || escola=='S'){
        goto inicio;
    }else{
        console.Clear();
        console.WriteLine("Fim do programa");
    }
}