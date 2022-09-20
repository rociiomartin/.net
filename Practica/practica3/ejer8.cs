/*
8. ¿Qué líneas del siguiente método provocan error de compilación y por qué?
var a = 3L;
dynamic b = 32;
object obj = 3;
a = a * 2.0;
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11;
obj = obj + 11;
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22;
d = c;
e = d;
f = e;
*/

/*
Linea 4: porque quiere multiplicar un double con un long(*)
Linea 9: El operador + no soporta la suma entre una variable de tipo obj e int
Linea 14: NO puede asignarle un valor de esa manera a f.
Linea 16: No puede asignarle lo mismo que "d" porque la variable e tiene Nombre y Edad.
Linea 17: No puede asignarle lo mismo que "e" porque la variable f tiene Edad y Nombre no Nombre y Edad,
los tipos etan invertidos.

(*)L_Long -->Las variables de tipo entero grandes o long son aquellas que almacenan un número (ya sea
positivo o negativo) no decimal 
*/
