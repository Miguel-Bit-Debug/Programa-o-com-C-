using System;

public class Jogador {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string n) {
            nome = n;
            energia = 100;
            vivo = true;
        }

        ~Jogador() {
            Console.WriteLine("Jogador {0} foi deletado", nome);
        }
}

class Aula29 {
    static void Main() {

        Console.Write("Digite um nome para o jogador1: ");
        string nome1 = Console.ReadLine();

        Console.Write("Digite um nome para o jogador2: ");
        string nome2 = Console.ReadLine();


        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador(nome2);
        
        Console.WriteLine("Nome do jogador1 {0}", j1.nome);
        Console.WriteLine("Nome do jogador1 {0}", j2.nome);
        
    }
}