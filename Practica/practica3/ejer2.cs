/*
2.Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo
de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en
la misma línea en la consola.

void ImprimirMatriz(double[,] matriz)

Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la
dimensión i.
*/

void ImprimirMatriz(double[,] matriz)
{
    for (int i = 0; i < matriz.GetLength(0); i++)
    {   
        for (int j = 0; j < matriz.GetLength(1); j++)
        {   
          Console.Write(matriz[i,j]+ " ");
        }
        Console.WriteLine(); //todos los elementos de una fila en la misma línea en la consola.
    }
}

double [,] matriz= new double[2,4]; //2 filas con 4 columnas
for (int i = 0; i < matriz.GetLength(0); i++) 
{     
    for (int j = 0; j < matriz.GetLength(1); j++)
    { 
         matriz[i,j]=1.3; //siempre es el mismo numero
    }
}
/*
for (int i = 0; i <= 15; i++) //tiene 8, es hasta 7 porq inluimos el 0
{
    matriz[i / 4, i % 4] = i; //VALORES DEL 0 AL 15
}
*/
Console.WriteLine("Imprimir Matriz");
ImprimirMatriz(matriz);
