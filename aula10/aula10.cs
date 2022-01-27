//Enumeradores(enum): premite a gente criar um tipo proprio com valores pre definidos.
using System;
class aula10
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
    static void Main(){
        DiasSemana ds = DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)3; usando o int 3 para chamar o dia da semana Quarta.
        //int ds=(int)DiasSemana.Sexta; nomeia o dia da semana em numeros inteiros.
        Console.Write(ds);
    }
}