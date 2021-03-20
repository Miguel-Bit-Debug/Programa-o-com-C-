
using System;

class Aula17
{

    static void Main()
    {

        //int n1, n2, n3, n4, n5;
        int[] n = new int[5];
        int[] num = new int[3] {11, 22, 33};
        int[] numerosArray = {1, 2, 3};

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        foreach(int numero in n) {
            Console.WriteLine(numero);
        }

        Console.WriteLine("\n\n");
        
        foreach(int numeros in num) {
            Console.WriteLine(numeros);
        }

        Console.WriteLine("\n\n");


        for(int i = 0; i < n.Length; i++) {
            Console.WriteLine(i);
        }


    }

}