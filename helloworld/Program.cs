Console.Clear();

Console.WriteLine("ingrese su nombre");
Console.WriteLine();

string nombre = (Console.ReadLine());

Console.WriteLine("hola "  +  nombre);
Console.WriteLine("desea continuar? S para si N para no");

string opcionElegida = (Console.ReadLine());

if (opcionElegida.ToUpper()== "S")
{
    Console.Clear();

    Console.WriteLine("ingrese su nombre");
    Console.WriteLine();

    string nombree = (Console.ReadLine());

    Console.WriteLine("hola " + nombree);
    Console.WriteLine("desea continuar? S para si N para no");
        string opcionElegidaa =(Console.ReadLine());
}

if (opcionElegida.ToUpper() == "N")
{
    Console.WriteLine("programa finalizado correctamente");
}

else
{
    Console.WriteLine("opcion no valida");
}












