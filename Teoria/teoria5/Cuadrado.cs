namespace ejercicios;
class Cuadrado
{
    private double _lado; //La variable que se encuentra asociada para poder usar las propiedades(backing field)

    /* Declaracion para acceso a estos miembros privados
    public void SetLado(double value) => _lado = value;
    public double GetLado() => _lado;
    public double GetArea() => _lado * _lado;*/

    //Para utilizar las propiedades
    public double Lado
    {
        get 
        {
         return _lado;
        }
        set 
        {
         _lado = value;
        }
        
        //Una sintaxis mas reducida(expression bodied member)
        /*
        get => _lado;
        set => _lado = value;
        */ 
    }
    
     //Propiedades implementadas automáticamente
     /*
     public double Lado{get;set;}
     */
    
    //metodo de solo lectura
    public double Area {
        get
         {
            return _lado * _lado;
        }
    }
}
