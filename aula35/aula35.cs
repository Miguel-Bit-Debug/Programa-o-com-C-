using System;

public class Veiculo {

    private int rodas;
    public int VelMax;
    private bool ligado;

    public Veiculo(int rodas) {
        this.rodas = rodas;
    }
    public void Ligar() {
        ligado = true;
    }

    public void Desligar() {
        ligado = false;
    }

    public string getLigado() {
        return (ligado ? "Sim" : "Não");
    }

    

    public int getRodas() {
        return rodas;
    }

    public void setRodas(int rodas) {
            if(rodas < 0) {
                this.rodas = 0;
            }
            else if(rodas > 40) {
                this.rodas = 40;
            } else {
                this.rodas = rodas;
            }
        }
}

    

public class Carro:Veiculo {

        public string nome;
        public string cor;

        public Carro(string nome, string cor) :base(4){
            Desligar();
            // rodas = 4;
            VelMax = 120;
            this.nome = nome;
            this.cor = cor;

        }
}

public class CarroCombate:Carro {
    public int municao;
    public CarroCombate() : base("Carro de combate", "Verde"){
        municao = 100;

        setRodas(6);

    }
}

public class Aula35 {
    static void Main() {
            Carro c1 = new Carro("Rapidão", "Vermelho");
            CarroCombate cc1 = new Carro();

            

            c1.Ligar();

            Console.WriteLine("Cor: {0}", c1.cor);
            Console.WriteLine("Nome: {0}", c1.nome);
            Console.WriteLine("Rodas: {0}", c1.getRodas());
            Console.WriteLine("VelMax: {0}", c1.VelMax);
            Console.WriteLine("Ligado: {0}", c1.getLigado());
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Cor: {0}", cc1.cor);
            Console.WriteLine("Nome: {0}", cc1.nome);
            Console.WriteLine("Rodas: {0}", cc1.getRodas());
            Console.WriteLine("VelMax: {0}", cc1.VelMax);
            Console.WriteLine("Ligado: {0}", cc1.getLigado());
            Console.WriteLine("Monição: {0}: ", cc1.municao);
    }
}