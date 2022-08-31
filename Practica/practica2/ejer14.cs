/*
Implementar un programa que muestre todos los números primos entre 1 y un número natural
dado (pasado al programa como argumento por la línea de comandos). Definir el método bool
EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es
divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d)
devuelve la raíz cuadrada de d)
*/
int numDado=Convert.ToInt32(args[0]);//como es un string tengo q pasarlo a int
Console.WriteLine("Numeros primos del 1 al " + numDado);
for (int i = 1; i <= numDado; i++) 
//for (int i = 1; i < 11; i++)
{
   if (EsPrimo(i))
   {
       Console.WriteLine(i);
   }
}

static bool EsPrimo(int n)
{
    bool EsP=false;
    if ( ( n % 2 != 0) && ( Math.Sqrt(n) % 2 != 0 ) )
    {
        EsP=true;
    }
    return EsP;
}

