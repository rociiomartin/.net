/*
12) Completar la clase Cuenta para que el siguiente código produzca la salida indicada:

Cuenta cuenta = new Cuenta();
cuenta.Imprimir();
cuenta = new Cuenta(30222111);
cuenta.Imprimir();
cuenta = new Cuenta("José Perez");
cuenta.Imprimir();
cuenta = new Cuenta("Maria Diaz", 20287544);
cuenta.Imprimir();
cuenta.Depositar(200);
cuenta.Imprimir();
cuenta.Extraer(150);
cuenta.Imprimir();
cuenta.Extraer(1500);

(monitor)

class Cuenta
{
private double _monto;
private int _titularDNI;
private string? _titularNobre;
. . .
}

Utilizar en la medida de lo posible la sintaxis :this en el encabezado de los constructores para invocar a otro
constructor ya definido.
*/
