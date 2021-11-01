## Práctica: Introducción a los scripts de Unity

Nombre: Aram Pérez Dios  
Correo: alu0101244488@ull.edu.es  
Universidad: Universidad de La Laguna 
Asignatura: Interfaces Inteligentes
Grupo: PE102  


### Ejercicio 1

Lo primero que se nos pide es que si el jugador colisiona con un objeto, otro 
objeto mostrará texto a través de la ui y se incrementará la fuerza del objeto 
con el que se colisiona.

Esto se hace en los scripts **detectCollision.cs** en el que se implementa el 
delegado y la función 'OnTriggerEnter' donde se ejecutará el evento. Las funciones 
para mostrar el texto y aumentar la fuerza se encuentra en **acivateText.cs** y 
**increaseForce.cs** respectivamente.

Para el movimiento del jugador se emplea el script **characterController** que usa
las teclas wasd.


### Ejercicio 2

Lo siguiente es hacer que uno cilindros cambien de color cuando el jugador se 
acerque y que unas esferas roten en dirección al jugador. El delegado se implementa 
e **distanceTriggerEvent.cs** y los eventos a ejecutar en **ChangeProperties.cs** y 
**sphereOrientation.cs** respectivamente (la función empleada para la rotación es 
'lookAt()').


### Ejercicio 3

En la última parte se nos pide dibujar un rayo con la diracción e la que apuntan las 
esferas con fines de depuración. Esto se implementa en le mismo script (**ChangeProperties.cs**)
que la propia rotación mediante 'Debug.DrawRay()'.


### Ejecución del proyecto
Aquí se muestra una ejecución al compleo del proyecto:

![](https://github.com/alu0101244488/Interfaces-inteligentes-delegados-y-eventos/blob/master/img/introduccion%20a%20los%20scripts%20de%20unity%20-%20SampleScene%20-%20PC,%20Mac%20Linux%20Standalone%20-%20Unity%202021.1.24f1%20Personal%20_DX11_%202021-11-01%2020-07-01.gif?raw=true)

