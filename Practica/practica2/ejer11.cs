/*
11. ¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
las palabras (una por línea) de una frase ingresada por consola por el usuario.

El método split() divide un objeto de tipo String en un array (vector) de cadenas mediante la separación de la cadena en subcadenas.

*/
String st = Console.ReadLine();
string[] mensaje = st.Split(' ');
foreach (var word in mensaje)
{
    Console.WriteLine($"{word}");
}
