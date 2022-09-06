/*
Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
implementados en el ejercicio anterior.

El módulo datetime proporciona clases para manipular fechas y horas. Si bien la implementación permite operaciones aritméticas con fechas y horas, 
su principal objetivo es poder extraer campos de forma eficiente para su posterior manipulación o formateo.

/*

using System.Text;
// Inicia el contador:
DateTime tiempo1 = DateTime.Now;
 
// Código del programa a medir tiempo de ejecución (ejercicio 9)
{
 String myString = "Hola";
 for (int i = 0; i < 1000; i++)
     myString += "I"; // poner 100 I en el string
 Console.WriteLine("String: " + myString);
 
 StringBuilder myStringBuilder = new StringBuilder();
 for (int i = 0; i < 1000; i++)
     myStringBuilder.Append('I'); 
 Console.WriteLine("String Builder: " + myStringBuilder);
}

// Para el contador e imprime el resultado:
DateTime tiempo2 = DateTime.Now;
TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
Console.Write( "TIEMPO: " + total.ToString() ); 
//Para el String tardo : 00:00:00.1020014
//Para el StringBuilder: 00:00:00.1018641
//Los 2 juntos: 00:00:00.1039235

