/*
3) ¿Por qué no funciona el siguiente código? ¿Cómo se puede solucionar fácilmente?

class Auto
{
double velocidad;
public virtual void Acelerar()
=> Console.WriteLine("Velocidad = {0}", velocidad += 10);
}
class Taxi : Auto
{
public override void Acelerar()
=> Console.WriteLine("Velocidad = {0}", velocidad += 5);
}
*/
