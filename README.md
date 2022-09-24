# Challenge NET Back-end
Proyecto desarrollado para proceso de reclutamiento en Betterplan. 

## Descripción de la funcionalidad principal del proyecto

Se requiere mediante la creación de servicios Web en tecnologías Api-Rest o GRPC-
WEB, una aplicación que exponga a través de internet una serie de endpoints.

La aplicación debe estar en C#, .NET Core con EF Core utilizando LINQ o raw Sql.

Los endpoints necesarios son:
<ol>
  <li>
    <b> Traer un usuario:</b>
    <ul>
      <li> path : /users/{id}</li>
      <li> salida : Id, nombre completo , nombre completo del Advisor, Fecha de creación.</li>
    </ul>
  </li> 
  <li>
    <b>Traer el resumen del usuario actual (considerar moneda)*</b>
    <ul>
      <li>path: /users/{id}/summary</li>
      <li>salida: balance, aportes actuales</li>
    </ul>
  </li>
  <li>
    <b>Traer el resumen del usuario actual a una fecha (considerar moneda)*</b>
    <ul>
      <li>path: /users/{id}/summary/{dd-mm-yyyy}</li>
      <li>salida: balance, aportes totales.</li>
    </ul>
  </li>
  <li>
    <b>Traer metas de un usuario</b>
    <ul>
      <li>path: /users/{id}/goals</li>
      <li>salida: Titulo de meta, años, inversión inicial, aporte mensual, monto objetivo, Entidad financiera, portafolio completo, fecha de creación.</li>
    </ul>
  </li>
  <li>
    <b>Traer detalle de una meta</b>
    <ul>
      <li>path:/users/{id}/goals/{goalId}</li>
      <li>salida: Titulo de meta, años, inversión inicial, aporte mensual, monto objetivo, categoría de la meta, Entidad financiera, portafolio completo, total aportes, total retiro, porcentaje de cumplimiento de la meta.</li>
    </ul>
  </li>
</ol>  
 
## Estructura del proyecto
El proyecto está estructurado de la siguiente manera: 

![](./doc/project-structure.png)

Consta de las siguientes carpetas:

- Controllers:  En esta carpeta están los controladores que sirven los endpoints al usuario
- Data: Acá se realiza la interacción la base de datos, internamente tenemos las carpetas <i>Interfaces</i> y <i>Implementations</i>, en la primera tenemos la firma de los metodos a implemetar tanto para DataContext como para UserQueries. 
Esto con el fin de facilitar la inyección de dependencia.
- Models: Se definen las entidades que reprensentan las tablas de la base de datos en el proyecto. Adicionalmente, está la carpeta <i>DTOs</i> donde se encuentran las clases que con la estructura de los datos requeridos en los endpoints.
- Utils: Carpeta de utilitarios
 

## Como ejecturlo
