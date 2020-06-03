using System;

public class Veiculo {

    public int rodas;
    public int VelMax;
    private bool ligado;
    public void Ligar() {
        ligado = true;
    }

    public void Desligar() {
        ligado = false;
    }

    public string getLigado() {
        if(ligado) {
            return "sim";
        } else {
            return "não";
        }
    }
}

public class Carro:Veiculo {

        public string nome;
        public string cor;

        public Carro(string nome, string cor) {
            Desligar();
            rodas = 4;
            VelMax = 120;
            this.nome = nome;
            this.cor = cor;

        }
}

public class Aula34 {
    static void Main() {
            Carro c1 = new Carro("Rapidão", "Vermelho");

            c1.Ligar();

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("Nome: {0}", c1.nome);
            Console.WriteLine("Rodas: {0}", c1.rodas);
            Console.WriteLine("VelMax: {0}", c1.VelMax);
            Console.WriteLine("Ligado: {0}", c1.getLigado());
    }
}