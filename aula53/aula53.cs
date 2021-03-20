using System;

public class Area {

    public static float Quad(float base1, float altura){
            if(base1 == 0 || altura == 0) {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }

            return base1 * altura;
    }

}

public class Aula53 {
    public static void Main() {

        float area = 0;
        
        try{
                area = Area.Quad(5f, 5f);
                Console.WriteLine(area);
            } catch(Exception e){
                    Console.WriteLine("Erro {0}", e.Message);
            } finally {
                    Console.WriteLine("Fim do processo");   
            }
            
    }
}