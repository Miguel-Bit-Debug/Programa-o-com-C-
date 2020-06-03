using System;

public class Base {
    public Base() {
        Console.WriteLine("Construtor da classe base");
    }
}

public class Derivada1:Base{
    public Derivada1() {
        Console.WriteLine("Contrutor da classe derivada1");
    }
}

public class Derivada2:Derivada1{
    public Derivada2() {
        Console.WriteLine("Contrutor da classe derivada2");
    }
}

public class Aula37 {
    public static void Main() {
            Derivada2 derivada2 = new Derivada2();
    }
}