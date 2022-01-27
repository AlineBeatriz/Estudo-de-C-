//Conversões de tipos(typecast): é quando a gente precisa converter um tipo em outro.
using System;
class aula11
{
    static void Main(){
        //ex: 1º
        int n1=10; // n1 - tipo inteiro(int)
        float n2=n1; // n1 - tipo real(float)

        //ex: 2º
        float n3=10.5f;
        int n4=(int)n3;//(int) é o type cast

        //ex: 3º
        int vInt=10;
        short vshor=(short)vInt;



        Console.WriteLine(n2);
    }
}