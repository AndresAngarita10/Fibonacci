// See https://aka.ms/new-console-template for more information
int Contador = 0; 
int NumeroAnterior = 0; 
int NumeroNuevo = 1; 
int suma = 0;
Console.WriteLine("Fibonacci!");
Console.WriteLine("Ingrese El limite a calcular el Fibonacci!");
int limite = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine(limite);
while (Contador <= limite)
{
    if (Contador > 1)
    {
        //Console.WriteLine("aaaaa Anterior: "+NumeroAnterior+" Nuevo: "+NumeroNuevo);
        suma = NumeroAnterior+NumeroNuevo;
        NumeroAnterior = NumeroNuevo;
        NumeroNuevo = suma;
        //Console.WriteLine("Suma: "+suma+" Antrior: "+NumeroAnterior+" Nuevo: "+NumeroNuevo);
    }
    Contador+=1;
}
Console.WriteLine("El numero Fibonacci: "+limite+", su resultado es: "+suma);