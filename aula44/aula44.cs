using System;

struct Carro {
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor) {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info() {
        Console.WriteLine("Marca: {0}", this.marca);
            Console.WriteLine("Modelo: {0}", this.modelo);
            Console.WriteLine("Cor: {0}", this.cor);
            Console.WriteLine("--------------------------");
    }
}

public class Aula44 {
    public static void Main() {

        Carro c1 = new Carro("Honda", "HRV", "PRATA");
        Carro c2 = new Carro("Honda", "HB20", "PRATA");
        Carro c3 = new Carro("Honda", "Onix", "PRATA");

            c1.info();
            c2.info();
            c3.info();
    }
}