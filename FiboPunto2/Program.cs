// See https://aka.ms/new-console-template for more information
int Contador = 0;
int NumeroAnterior = 0;
int NumeroNuevo = 1;
int suma = 0;
bool Salida = false;
int revision = 0;
int[] PuntosDeControl = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
Console.WriteLine("Fibonacci!");
Console.WriteLine("Ingrese el numero para validad si es Fibonacci!");
int Validar = Convert.ToInt16(Console.ReadLine());
while (Salida == false)
{
    if (revision == 10 || suma > Validar)
    {
        Console.WriteLine("El numero: "+Validar+" No es un numero Fibonacci!");
        Salida = true;
        return;
    }
    if (Contador > 1)
    {
        suma = NumeroAnterior + NumeroNuevo;
        NumeroAnterior = NumeroNuevo;
        NumeroNuevo = suma;
        if (Validar == suma)
        {
            Console.WriteLine("-----------> El numero " + Validar + " Si es un nuemro Fibonacci");
            Salida = true;
            return;
        }
    }
    if (Contador == PuntosDeControl[revision])
    {
        Console.WriteLine("No se ha encontrado el numero en el punto de control!");
        Console.WriteLine("Si desea para la busqueda presione Y, o enter para salir");
        string? seleccion = Console.ReadLine();
        if (seleccion.ToLower().Contains("y"))
        {
            revision += 1;
            Console.WriteLine("Punto de revision: " + revision);
        }
        else
        {
            Salida = true;
            return;
        }
    }
    Contador += 1;
}