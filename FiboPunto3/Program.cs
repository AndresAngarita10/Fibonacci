// See https://aka.ms/new-console-template for more information
int Contador = 0; 
int NumeroAnterior = 0; 
int NumeroNuevo = 1; 
int suma = 0;
string resultado = "";
Console.WriteLine("Fibonacci!");
Console.WriteLine("Ingrese la cantidad a calcular el Fibonacci!");
int limite = Convert.ToInt32(Console.ReadLine());
List<int> lista = new List<int>();
lista.Add(0); lista.Add(1);
//Console.WriteLine(lista[0]);
//Console.WriteLine(limite);
while (Contador < limite)
{
    if (Contador > 1)
    {
        suma = NumeroAnterior+NumeroNuevo;
        NumeroAnterior = NumeroNuevo;
        NumeroNuevo = suma;
        lista.Add(suma);
    }
    Contador+=1;
}
Console.WriteLine("Los numeros hasta el limite son: ");
foreach (int numero in lista)
{
    resultado += " " + numero;
}
Console.WriteLine(resultado);