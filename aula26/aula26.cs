using System;

class Aula26 {

    static void Main() {

        int divid, divis, quoc, res;
        divid = 1250;
        divis = 13;
        quoc = Divide(divid, divis, out res);

        Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}", divid, divis, quoc, res);

    }

    static int Divide(int dividendo, int divisor, out int resto) {
        int quociente;
        quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }


}