/*
12. Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria
heap cuando la ejecución alcanza los puntos indicados (comentarios en el código)

using System.Text;
object[] v = new object[10];
v[0] = new StringBuilder("Net");
for (int i = 1; i < 10; i++)
{
v[i] = v[i - 1];
}
(v[5] as StringBuilder).Insert(0, "Framework .");
foreach (StringBuilder s in v)
Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución

v[5] = new StringBuilder("CSharp");
foreach (StringBuilder s in v)
Console.WriteLine(s);

//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución
*/
