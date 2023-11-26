

void calcIMC ()
{
    Console.WriteLine(" ------ Calculo de IMC ------\n**  Para encerrar o programa digite 0  **");
    Console.WriteLine("Digite a sua Altura:");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o seu Peso:");
    double peso = Convert.ToDouble(Console.ReadLine());


   if (peso != 0 && altura != 0){
    
    double IMC = peso / Math.Pow(altura,2);

    Console.WriteLine("***********************");

    Console.WriteLine("Total de IMC:" + IMC );
    Console.WriteLine("***********************");

    Console.WriteLine("Classificação de IMC:");

    if (IMC < 18.5){Console.WriteLine(Graus.MAGREZA);}

    else if (IMC > 18.5 && IMC < 24.9){Console.WriteLine(Graus.NORMAL);}
    else if (IMC > 25 && IMC < 29.9){Console.WriteLine(Graus.SOBREPESO);}
    else if (IMC > 30 && IMC < 39.9){Console.WriteLine(Graus.OBESIDADE);}
    else {Console.WriteLine(Graus.OBESIDADEGRAVE);}

    
    calcIMC ();}
    else{
        Console.WriteLine(" ******** Programa Finalizado ******** ");
    }
}

calcIMC ();



enum Graus { MAGREZA, NORMAL, SOBREPESO, OBESIDADE, OBESIDADEGRAVE} 