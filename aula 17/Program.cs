namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        int  n1, n2, n3, n4,   sr, NT;
       
        Console.WriteLine("Seja bem vindo!");
        
       
      
        Console.Write("Digite seu nome: ");
        string texto =    Console.ReadLine();
          
           
         
         Console.Write("Qual sua Série: ");
        sr = int.Parse( Console.ReadLine());
          
          int SR = (sr);
         
         Console.WriteLine("Agora vamos calcular suas notas!");

          Console.Write("Digite a nota da sua primeira prova: ");
          n1 = int.Parse(Console.ReadLine());
          
          Console.Write("Digite sua segunda nota: ");
          n2 = int.Parse(Console.ReadLine());

          Console.Write("Digite sua terceira nota: ");
          n3 = int.Parse(Console.ReadLine());

          Console.Write("Digite sua quarta nota: ");
          n4 = int.Parse(Console.ReadLine());

           int med = (n1 + n2 + n3 + n4 ) /4;
           
          Console.WriteLine("Muito Bem, estamos cauculando sua média aguarde....");
           Console.Write(texto );
         
           Console.Write(" Sua média é: ");
          Console.Write(med);
          
         
          bool res = (med>3) && (med<6);

          if  (med>6)
            
           { Console.Write(" Parabens, Aprovado com Louvor!!");}
             
            
          else 
          
          
          { Console.Write(" Desculpe, você ficou de recuperação!!");}
          

      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      
      // // Ex 2 OPERARADOR &&(AND)
      // Console.WriteLine("operador &&, se tier 1 falso sempre vai dar falso");
      // Console.WriteLine(true && true);
      // Console.WriteLine(true && false);
      // Console.WriteLine(false && true);
      // Console.WriteLine(false && false);
      
      // // OPERADOR (OU)
      // Console.WriteLine("operador OU, tem que ter 2 falso para ser falso ");
      // Console.WriteLine(true || true);
      // Console.WriteLine(true || false);
      // Console.WriteLine(false || true);
      // Console.WriteLine(false || false);
      
      // // OPERADOR (!=) DIERENTE (DE))
     
      // Console.WriteLine("operador NOT, trasforma o valor no oposto");
      // Console.WriteLine(!true);
      // Console.WriteLine(!false);
      


      






          
        









    }
}