/*
1.Ejecutar y analizar cuidadosamente el siguiente programa:

Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true);
}
Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera
se puede acceder a esta información en el código del programa.


Lo que hace es esperar que aprete una tecla y mostrar en pantalla cual es la tecla y 2 digitos que identifican esa letra. Con alt sale
*/
