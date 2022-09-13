namespace ejercicios;
class Familia
{
    public Persona? Padre { get; set; }
    public Persona? Madre {get; set; }
    public Persona? Hijo { get; set; }
    
     //Indizador de solo lectura. Para saber donde esta casa uno
    public Persona? this[int i]
    {
        get
        {
            if (i == 0) return Padre;
            else if (i == 1) return Madre;
            else if (i == 2) return Hijo;
            else return null;
        }
        
        /*Los indizadores no estan limitados a los numeros tmb puede hacer:
        get
        {
            if (Padre?.Nombre == st) return Padre;
            else if (Madre?.Nombre == st) return Madre;
            else if (Hijo?.Nombre == st) return Hijo;
            else return null;
        }
        Devuelve el miembro de la familia, si hay 2 que se llaman igual devuelve el primero que pregunto
        */
    }
        set
        {
            if (i == 0) Padre = value;
            else if (i == 1) Madre = value;
            else if (i == 2) Hijo = value;
        }
}
