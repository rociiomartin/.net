/*
2) Agregar a la clase Cuenta del ejercicio anterior un método estático GetCuentas() que devuelva
un List<Cuenta> con todas las cuentas creadas. Controlar que la modificación de la lista devuelta,
por ejemplo borrando algún elemento, no afecte el listado que internamente mantiene la clase
Cuenta. Sin embargo debe ser posible interactuar efectivamente con los objetos Cuenta de la lista
devuelta. Verificar que el siguiente código produzca la salida por consola que se indica:

new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas();
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.GetCuentas();
Console.WriteLine(cuentas.Count);
// se recupera nuevamente la lista de cuentas
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo

Salida por
consola

Se creó la cuenta Id=1
Se creó la cuenta Id=2
Se depositó 50 en la cuenta 1 (Saldo=50)
1
2
Se extrajo 30 de la cuenta 1 (Saldo=20)
*/
