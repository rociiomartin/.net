/*
9. Señalar errores de compilación y/o ejecución en el siguiente código
object obj = new int[10];
dynamic dyn = 13;
Console.WriteLine(obj.Length);//error de compilacion(*)
Console.WriteLine(dyn.Length);// error de ejecucion(-)
*/

/*
(*)Porque el tipo de dato object no tiene ".Length"
(-)Porque dependiendo que valor se le asigne sera error de compilacion, si hubiera sido--> dynamic dyn = "Hola" no es error porque el string si tiene .lenght;
*/
