int continuar = 1, operador;

double n1= 0 ,n2= 0, resultado= 0;

do{
    Console.WriteLine("Elegir la Opecion a Realizar ");
    do{

        Console.WriteLine(" 1-SUMA\n 2-RESTA \n 3-MULTIPLICACION\n 4-DIVISION \n 5-Valor absoluto\n 6-Cuadrado \n 7-Raíz cuadrada\n 8-Seno \n 9-Coseno\n 10-Parte Entera\n");
        operador=Convert.ToInt32(Console.ReadLine());
    }while(operador < 0 || operador > 10);

    Console.WriteLine("Ingreser un numero : ");
    n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingreser un numero : ");
    n2 = Convert.ToDouble(Console.ReadLine());

    if(operador != 0 ){
        switch(operador){
            case 1 : 
            resultado = n1 + n2 ;
            Console.WriteLine($"{n1} + {n2} = {resultado}\n");
            break;
            case 2 : 
            resultado = n1 - n2 ;
            Console.WriteLine($"{n1} - {n2} = {resultado}\n");
            break;
            case 3 : 
            resultado = n1 * n2 ;
            Console.WriteLine($"{n1} * {n2} = {resultado}\n");
            break;
            case 4 : 
            if( n2 == 0){
                Console.WriteLine("error\n");
            }else{
                resultado = n1 / n2 ;
            Console.WriteLine($"{n1} / {n2} = {resultado}\n");
            }
            break;
            case 5 : 
            resultado = Math.Abs(n1);
            Console.WriteLine($"El valor Absoluto {n1} es {resultado}\n");
            break;
            case 6 : 
            resultado = Math.Pow(n1,2) ;
            Console.WriteLine($"Potencia de {n1} es {resultado}\n");
            break;
            case 7 : 
            resultado = Math.Sqrt(n1) ;
            Console.WriteLine($" La raiz Cuadrada {n1} es  {resultado}\n");
            break;
            case 8 : 
            resultado = Math.Sin(n1 * Math.PI /180) ;
            Console.WriteLine($" El seno {n1} es  {resultado}\n");
            break;
            case 9 : 
            resultado = Math.Cos(n1 * Math.PI /180) ;
            Console.WriteLine($" El coseno {n1} es  {resultado}\n");
            break;
            case 10 : 
            resultado = Math.Truncate(n1) ;
            Console.WriteLine($" La parte entera {n1} es  {resultado} \n");
            break;
        }
        Console.WriteLine($"Numero Maximo : {Math.Max(n1,n2)}");
        Console.WriteLine($"Numero Minimo : {Math.Min(n1,n2)}");
    
    }


    do{ 
        Console.WriteLine("Seguir usando la calculadoa 1-SI ");
        continuar=Convert.ToInt32(Console.ReadLine());

    }while(continuar == 0);

}while(continuar == 1 );

 