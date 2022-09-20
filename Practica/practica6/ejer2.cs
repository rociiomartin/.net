/*
2) Aunque consultar en el código por el tipo de un objeto indica habitualmente un diseño ineficiente,
por motivos didácticos vamos a utilizarlo. Completar el siguiente código, que utiliza las clases
definidas en el ejercicio anterior, para que se produzca la salida indicada:

A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector)
{
...
}

Salida por consola B_3 --> A_3
B_5 --> A_5

Es decir, se deben imprimir sólo los objetos cuyo tipo exacto sea B
a) Utilizando el operador is
b) Utilizando el método GetType() y el operador typeof() (investigar sobre éste último en
la documentación en línea de .net)
*/
