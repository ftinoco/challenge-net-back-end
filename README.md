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
 