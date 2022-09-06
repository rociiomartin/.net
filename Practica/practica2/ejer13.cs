/*
13. Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
noviembre, octubre ..., enero)
c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses
*/

namespace ejercicios;
//declarar antes del programa
enum Meses
{
    enero=1,febrero=2, marzo=3, abril=4, mayo=5, junio=6, julio=7,
    agosto=8, septiembre=9, octubre=10, noviembre=11, diciembre=12
}
//basta con poner enero=1 para que el resto quede 2,3,4,..,12
class Program
{
  static void Main(string[] args) //preguntar porq necesita el main
  {
      
    Console.WriteLine("Los meses en orden inverso ");
    for (Meses i = Meses.diciembre; i >= Meses.enero; i--)
    {
                    Console.WriteLine(i);
    }

    Console.WriteLine("Ingrese un mes");
    string st=Console.ReadLine();


    for (Meses i = Meses.diciembre; i >= Meses.enero; i--)
    {
        if(st.Equals(Meses.GetName(i) ) )
        {
            Console.WriteLine("Es un mes");
        }
    }

  }
}
