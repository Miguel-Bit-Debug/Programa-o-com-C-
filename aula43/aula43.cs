using System;

public interface Veiculo {
    
    void Ligar();
    void Desligar();
    void info();
}

public interface Combate {
        void disparar();
}

public class Carro : Veiculo, Combate {

    public bool ligado;
    private int municao;
    public Carro() {
        setMunicao(100);
    }

    public void setMunicao(int qtde) {
        this.municao = qtde;
    }

    public void Ligar() {
        this.ligado = true;

    }

    public void Desligar() {
        this.ligado = false;
    }

    public void disparar() {

    }

    public void info() {

    }

        

}

public class Aula43 {
    static void Main() {

        Carro c1 = new Carro();
    }
}