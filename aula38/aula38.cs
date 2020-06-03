using System;

public class Base {
    public Base() {
        Console.WriteLine("Construtor da classe base");
    }

    virtual public void info() {
        Console.WriteLine("Base");
    }
}

public class Derivada1:Base{
    public Derivada1() {
        Console.WriteLine("Contrutor da classe derivada1");
    }

    override public void info() {
        Console.WriteLine("Derivada 1");
    }
}

public class Derivada2:Derivada1{
    public Derivada2() {
        Console.WriteLine("Contrutor da classe derivada2");
    }

    override public void info() {
        Console.WriteLine("Derivada 2");
    }
}

public class Aula38 {

    Base Ref;
    public static void Main() {
            Derivada2 derivada1 = new Derivada2();
            Derivada1 derivada2 = new Derivada1();
            
            Ref = derivada1;

            Ref.info();            
    }
}