using System;

class Aula24 {

    static void Main() {

        Console.Write("Digite um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        int num2 = int.Parse(Console.ReadLine());
        int r = soma(num1, num2);
        Console.WriteLine("{0} + {1} = {2}", num1, num2, r);

    }

    static int soma(int n1, int n2) {
        int res = n1 + n2;
        return res;

    }

}