//Campos constantes (const)

/*const string saludoDos = "Hola" + 2; 
no compila porque el compilador no sabe concatenar string con numeros, es una sobrecarga de la suma (run time si lo sabe hacer)*/

/*
static double tres = 3.0;
const double triplePI = PI * tres;
no compila porque no sabe el compilador que es "tres" porque no es una constante*/

/*
const DateTime dia = DateTime.Now;
no compila porque las constantes pueden definirse de los tipos numericos, char, bool o string*/

/*una variable que no va a ser modificada se suele usar readonly-->Se asignan en tiempo de ejecución, es decir los errores anteriores:
readonly string saludoDos = "Hola" + 2;
static readonly double triplePI = PI * tres;
readonly DateTime dia = DateTime.Now;
*/

//Encapsulamiento
using ejercicios;
//Acceso a miembros privados
Cuadrado c = new Cuadrado();
/*c.SetLado(2.5);
Console.WriteLine("Lado: {0} área: {1}",
                    c.GetLado(),
                    c.GetArea());*/
                    
//utilizando propiedades
c.Lado = 2.5;
Console.WriteLine("Lado: {0} área: {1}",
c.Lado,
c.Area);




