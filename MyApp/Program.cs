int continuar = 1, operador;

double n1= 0 ,n2= 0, resultado= 0;

do{
    Console.WriteLine("Elegir la Opecion a Realizar ");
    do{
        Console.WriteLine(" 1-SUMA\n 2-RESTA \n 3-MULTIPLICACION\n 4-DIVISION \n");
        operador=Convert.ToInt32(Console.ReadLine());
    }while(operador < 1 || operador > 4);

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
    
        }   
    }
    do{ 
        Console.WriteLine("Seguir usando la calculadoa 1-SI ");
        continuar=Convert.ToInt32(Console.ReadLine());

    }while(continuar == 0);

}while(continuar == 1 );


