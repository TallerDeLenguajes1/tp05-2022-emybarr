Console.WriteLine("-----------------Punto 4 ------------- ");

Console.WriteLine("Ingrese un texto\n ");

string cadena = Console.ReadLine();

string parteCadena = cadena.Substring(0,6);

Console.WriteLine($"Parte de la cadema :  {parteCadena} \n");

Console.WriteLine($"Parte de la cadema :  {cadena.Length} \n");


Console.WriteLine("Concatenar (Unir) dos cadenas distintas ");
string cadena1= "Hola ";
Console.WriteLine($"Cadena 1:  {cadena1} \n");
string cadena2= "a todos ";
Console.WriteLine($"Cadena 1:  {cadena2} \n");
string cad= string.Concat(cadena1,cadena2);
Console.WriteLine($"Concatenacion de cadena :  {cad} \n");


Console.WriteLine("Extraer una subcadena ");
string subcadena = cad.Substring(6);
Console.WriteLine($"Substraer cadena  :  {subcadena} \n");

Console.WriteLine("Recorrer la cadena de texto con un ciclo Foreach ");
foreach(char letra in cad){
    Console.WriteLine(letra);
}

Console.WriteLine("Buscar la ocurrencia de una palabra determinada en la cadena ingresada ");
string cadena3= Console.ReadLine();
string palabra ="la";
Console.WriteLine($"La cantidad de veces que aparece una palabra es : {cadena3.Contains(palabra)}");


Console.WriteLine("Convierta la cadena a Mayúsculas y luego minúsculas");
string cadena4 = "rinoceROnTe";
Console.WriteLine($"Mayusculas {cadena4.ToUpper()}");
Console.WriteLine($"Minusculas {cadena4.ToLower()}");

Console.WriteLine("Ingrese una nueva cadena y luego compare los valores de ambas.");
string cadena5 = "Licenciatura en informática";
Console.WriteLine($"Comparar {String.Equals(cad,cadena5)}");

Console.WriteLine("Ingrese una cadena separada por caracteres que usted determine");
string cadena6= "Returns-a-value-indicating-whether";
string[] separar = cadena6.Split("-");
foreach( string frase in separar){
    Console.WriteLine(frase);
}


Console.WriteLine("ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva");
string ecuacion = Console.ReadLine();

double resultado = 0;
switch(ecuacion){
    case var s when ecuacion.Contains("+"):
    resultado = Convert.ToDouble(ecuacion.Split("+")[0]) + Convert.ToDouble(ecuacion.Split("+")[1]);
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case var s when ecuacion.Contains("-"):
    resultado = Convert.ToDouble(ecuacion.Split("-")[0]) - Convert.ToDouble(ecuacion.Split("-")[1]);
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case var s when ecuacion.Contains("*"):
    resultado = Convert.ToDouble(ecuacion.Split("*")[0]) * Convert.ToDouble(ecuacion.Split("*")[1]);
    Console.WriteLine($"El resultado es {resultado}");
    break;
    case var s when ecuacion.Contains("/"):
    if(Convert.ToDouble(ecuacion.Split("/")[1]) == 0){
        Console.WriteLine("ERROR");
    }else{
    resultado = Convert.ToDouble(ecuacion.Split("/")[0]) / Convert.ToDouble(ecuacion.Split("/")[1]);
    Console.WriteLine($"El resultado es {resultado}");
    }
    break;

}