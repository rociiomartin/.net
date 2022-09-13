using ejercicios;
//Indizadores, son solo de instancia.
Familia f = new Familia();
f.Padre = new Persona("Juan", 50);
f.Madre = new Persona("María", 40);
f.Hijo = new Persona("José", 15);
//f.Madre.Imprimir(); Indizador de tipo familia de la madre (uno en particular) de lectura
f[1] = new Persona("María", 40);//2 indizadores de escritura
f[2] = new Persona("José", 15);
for (int i = 0; i < 3; i++)
{
  f[i]?.Imprimir(); //Indizador que esta declarado en tipo familia(todos o hasta donde diga el for) de lectura
}
//los indizadores no estan limitados a los numeros --> f["María"]?.Imprimir(); //es de lectura
