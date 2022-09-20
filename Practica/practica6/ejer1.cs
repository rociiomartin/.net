/*
1) Sin borrar ni modificar ninguna línea, completar la definición de las clases B, C y D

class A
{
protected int _id;
public A(int id) => _id = id;
public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}
class B : A
{
. . .
}
class C : B
{
. . .
}
class D : C
{
. . .
public override void Imprimir()
{
. . .
base.Imprimir();
}
}

para que el siguiente código produzca la salida indicada:

A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector)
{
a.Imprimir();
}

Salida por consola A_3
B_5 --> A_5
C_15 --> B_15 --> A_15
D_41 --> C_41 --> B_41 --> A_41
*/
