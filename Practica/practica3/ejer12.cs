/*
Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un
carácter una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por
ejemplo: para la siguiente tabla de caracteres:

(ver)

Si la clave es {5,3,9,7} y el mensaje a cifrar “HOLA MUNDO”
Se cifra de la siguiente manera:

(ver)

A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que
la suma fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola
con los números de la clave encolados y a medida que se desencolen para utilizarlos en el
cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar y
otro para descifrar.
*/
