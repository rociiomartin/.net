/*
3.Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
parámetro más que representa la plantilla de formato que debe aplicarse a los números al
imprimirse. La plantilla de formato es un string de acuerdo a las convenciones de formato
compuesto, por ejemplo “0.0” implica escribir los valores reales con un dígito para la parte
decimal.

void ImprimirMatrizConFormato(double[,] matriz, string formatString)
*/
void ImprimirMatrizConFormato(double[,] matriz, string formatString)
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
Console.WriteLine("Imprimir Matriz");
string st= "uno";
ImprimirMatrizConFormato(matriz,st);

VEEEEEEEER
