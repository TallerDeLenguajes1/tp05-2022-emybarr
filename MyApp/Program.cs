int numero, ninverso = 0;

Console.WriteLine("Ingrese el número a invertir:");
numero= Convert.ToInt32(Console.ReadLine());

while(numero > 0 && numero != 0){
    ninverso = ninverso * 10 + (numero%10);
    numero= numero/10;
}
Console.WriteLine($"El numero invertido es {ninverso}");


