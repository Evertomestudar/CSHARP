namespace MyProject;
class Program
{
    static void Main(string[] args)
    {    


          // exemplo 1

        int c1, s ;

         Console.WriteLine("Bem Vindo ao Banco!!");

          Console.Write("Digite seu usuário: ");
          string texto = (Console.ReadLine());

           s = (212325);
           
           Console.Write("Digite sua Senha: ");
           s = int.Parse(Console.ReadLine());
            
            while (s != s){

                Console.Write("Digite sua senha novamente:");

            
            }





           Console.WriteLine("Verificando senha...... ");

           Console.WriteLine("Seu saldo é de 1000");


          Console.Write("QUAl VALOR DO SAQUE: ");
             c1 = int.Parse(Console.ReadLine());

          if (c1< 1000)
          { Console.WriteLine("Realizando saque....");

          }

          else
          {Console.WriteLine("Saldo Insuficiente");
          }

         int resto = (1000 - c1);

         Console.Write( texto + " Seu Saldo Restante é: ");
         Console.Write(resto);

        // Exemplo 2

        //   double valor = (1000);

        // Console.Write("Qual valor do seu saque: ");
        // double valorsaque = double.Parse(Console.ReadLine());

        // if (valor <= 1000)
        // {
        //     Console.WriteLine("REALIZANDO SAQUE.....");
        //     Console.Write("Saldo Restante: ");
        //     Console.Write( valor - valorsaque);
        
        // }
        //   else {
                
        //         Console.WriteLine("SALDO INSUFICIENTE!");


        //   }

           

       // exemplo 4

        //   int n1, n2, n3, n4;
        // n1 =int.Parse( Console.ReadLine());
        // n2 =int.Parse (Console.ReadLine());
        // n3 =int.Parse(Console.ReadLine());
        // n4 =int.Parse(Console.ReadLine());

        // double media =(n1 + n2 + n3 + n4) /4;

        // if (media>=7){

        //   Console.WriteLine("Aprovado");
        // }
        //     else {

        //         if (media<4)
        //         {
        //             Console.WriteLine("Reproado");
        //         }

        //          else
        //          {
        //            Console.WriteLine("Recuperação!");

        //          }

            
            // exemplo 5
            
            
            //  int n1 =int.Parse(Console.ReadLine());

            //  if ((n1 % 5 ) ==0){

            //     Console.WriteLine("SIM");

            //  }
            //    else{

            //     Console.WriteLine("NÃO");
            //    }
                 

             // exemplo 2

            //    int n1, n2 ,n3;
            //   n1  =int.Parse(Console.ReadLine());
            //   n2 =int.Parse(Console.ReadLine());
            //   n3 =int.Parse(Console.ReadLine());

            //   if (n1 < n2 && n1 < n3){

            //     Console.WriteLine("n1 é MENOR");

            //   }
            //   else{
            //         if (n2 < n3){

            //             Console.WriteLine("n2 é menor");


            //         }
            //           else{

            //             Console.WriteLine("n3 é menor");
            //           }
            //   }
               
                //exemplo 4

        //      Console.Write("INFORME O SEU SALÁRIO: ");
        //   double sal =double.Parse (Console.ReadLine());

        //     if (sal <= 500){
        //        sal =sal*1.10;
            
        //       Console.WriteLine("Seu novo salário " + sal);
        //         }
              
        //       else{
        //         Console.WriteLine("SEM AUMENTO!");
        //       }



                   //SISTEMA DE ENCADEAMENTO SIMPLES

                //    if (condição){

                //     (instrução)
                //    }

                //     else if (condição){
                      
                //       (instrução)

                //     }
                //           else {
                //             (instrição))
                //           }  





                   }
















            }

           // exemplo 3

        //     int n1, n2;

        //    Console.Write("Digite o primeiro número: ");
        //    n1 = int.Parse(Console.ReadLine());

        //    Console.Write("Digite  segundo número: ");
        //    n2 = int.Parse(Console.ReadLine());

        //    if ( n1 > n2)

        //    {Console.WriteLine("Sim é maior...."); }


        //    else {Console.WriteLine("Não é Maior...");}















    



// // Ex 2 OPERARADOR &&(AND)
//       Console.WriteLine("operador &&, se tier 1 falso sempre vai dar falso");
//       Console.WriteLine(true && true);
//       Console.WriteLine(true && false);
//       Console.WriteLine(false && true);
//       Console.WriteLine(false && false);

//       // OPERADOR (OU)
//       Console.WriteLine("operador OU, tem que ter 2 falso para ser falso ");
//       Console.WriteLine(true || true);
//       Console.WriteLine(true || false);
//       Console.WriteLine(false || true);
//       Console.WriteLine(false || false);

//       // OPERADOR (!=) DIERENTE (DE))

//       Console.WriteLine("operador NOT, trasforma o valor no oposto");
//       Console.WriteLine(!true);
//       Console.WriteLine(!false);

