namespace Teoria6;

class Automotor{
   
   public string Marca = "";
   private int _modelo;
   public virtual int Modelo{
       get=> _modelo;
       set=> _modelo = (value < 2005) ? 2005 :value;
   }
   public Automotor(String marca, int modelo)
   {
       this.Marca = marca;
       Modelo = modelo;
   }
   public virtual void Imprimir()
       => Console.WriteLine($"{Marca} {Modelo}");
}
