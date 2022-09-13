/* 16. Escribir una función (método int Fac(int n)) que calcule el factorial de un número n
pasado al programa como parámetro por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional
ternario)*/

/*a
static int Fac(int n)
{
    int factorial=1;
    for (int i = 1; i < n; i++)
    {
        factorial*=i;
    }
    return factorial;
}

int nro = int.Parse(args[0]); //numero pasado por argumento
Console.WriteLine("El factorial de " + nro + " es: "+ Fac(nro));
*/
