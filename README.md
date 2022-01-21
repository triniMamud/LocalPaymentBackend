# LocalPaymentBackend

Se ha solicitado el diseño de un sistema para procesar operaciones con tarjetas de crédito para una organización. Dicho sistema debe disponer de un módulo que permita con las siguientes consideraciones desarrollar un aplicativo:
* :godmode:Una tarjeta se identifica de acuerdo a la marca, número de tarjeta, cardholder y fecha de vencimiento
* :godmode:Una operación es válida en el sistema si la persona que opera en el mismo consume menos de 100
* :godmode:Una tarjeta es válida para operar si su fecha de vencimiento es mayor al presente día
Hoy en día, existen tres marcas de tarjeta de crédito, a saber: “SQUA”, “SCO”, “PERE” y es posible que en los siguientes meses existan nuevas marcas. Cada marca tiene un modo de calcular una tasa por el servicio, a saber:
* :godmode:Tasa SQUA = año / mes
* :godmode:Tasa SCO    = dia del mes *0.5
* :godmode:Tasa PERE  = mes*0.1


 
### Parte 1
Dar de alta los usuarios en la tabla usuarios, el mismo cuenta con la estructura, id, nombre, usuario, password, teniendo en cuenta que esta tabla será utilizada por mas colaboradores, se debe genera un prefijo único para poder acceder a los datos insertados y ser validados, esto dara ingreso a la aplicación.
 
Se deberá dar de alta la tarjeta de crédito para ello deberá insertarse en la base de datos en la tabla tarjetas con la siguiente estructura, id, nombre,numero,titular,persona, limite, tasa. Siendo que en la columna persona debe guardada la persona física responsable para esta tarjeta
 
Los datos de la persona a insertar son id,nombre,apellido,dirección,tarjeta,dni de la tabla personas
 
Crea los objetos correspondiente que respeten la siguiente funcionalidad.

* :godmode:a)                    Invocar un método que devuelva toda la información de una tarjeta
* :godmode:b)                    Informar si una operación es valida
* :godmode:c)                    Informar si una tarjeta es válida para opera
* :godmode:d)                    Identificar si una tarjeta es distinta a otra
* :godmode:e)                    Obtener por medio de un método la tasa de una operación informando marca e importe
Los datos deben ser cargados por el responsable de cuenta
 
### Parte 2
Se debe mostrar todas las tarjetas que una persona ha solicitado
Generar seguridad para que no se pueda acceder a cualquier servlet si el usuario no esta autenticado
Mostrar todas las tarjetas que se han cargadado sin importar de que persona fuera,  sin mostrar las tarjetas repetidas

### Parte 3 
Los servicios deben tener unit test , si desea agregar automatización se vera como un plus.
 
### Parte 4 
El despliegue de la aplicación se debe generar via Docker o Docker-Compose  / kubernetes / o similares 

### Extras
Al momento de la entrega, deberá enviarnos el repositorio, github, bitbucket, gitlab, etc, se valora diagramas de clase, flujo etc

### Swagger
<img align="left" width="400" src="https://github.com/alexdeassis7/LocalPaymentBackend/blob/main/CardsAppBackEnd/5257dc04-aaef-4771-ae59-d0d49c4fbf2b.jpg">

