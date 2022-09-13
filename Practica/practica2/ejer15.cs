/*
Escribir una función (método int Fib(int n)) que calcule el término n de la serie de
Fibonacci.
Fib(n) = 1, si n <=2
Fib(n) = Fib(n-1) + Fib(n-2), si n > 2
*/
static int Fib(int n)
{
    if(n<=2) return 1;
    else return Fib(n-1) + Fib(n-2);
}

int i=1;
Console.WriteLine(Fib(i));
Console.WriteLine(Fib(i+2));
