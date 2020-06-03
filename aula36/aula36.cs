using System;

public class Veiculo { // Base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax) {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado() {
        return ligado;
    }

    public int getVelMax() {
        return velMax;
    }
}

public class Carro: Veiculo {
    public string nome;
    public Carro(string nome, int vm) :base(vm){ //Derivada de Veiculo
            this.nome = nome;
            ligado = true;
    }

}


public class Aula36{
    public static void Main() {
            Carro carro = new Carro("Bonitão", 120);

            Console.WriteLine("Nome: .......{0}", carro.nome);
            Console.WriteLine("Vel. Maxima......: {0}", carro.getVelMax());
            Console.WriteLine("Ligado......: {0}", carro.getLigado());
    }
}