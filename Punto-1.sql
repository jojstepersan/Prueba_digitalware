--Obtener la lista de precios de todos los productos
SELECT p.Nombre 
      ,p.Precio 
      ,b.CantidadExistente 
FROM dbo.Productos p 
JOIN dbo.Bodegas b ON p.ProductoId = b.ProductoId 

--Obtener la lista de productos cuya existencia en el inventario haya 
--llegado al mínimo permitido (5 unidades)
SELECT p.Nombre 
      ,p.Precio 
      ,b.CantidadExistente 
FROM dbo.Productos p 
JOIN dbo.Bodegas b ON p.ProductoId = b.ProductoId 
WHERE b.CantidadExistente <=5

--Obtener una lista de clientes no mayores de 35 años que 
--hayan realizado compras entre el
--1 de febrero de 2000 y el 25 de mayo de 2000
SELECT p.* 
FROM Clientes c 
JOIN Personas p ON c.PersonaId = p.PersonaId 
JOIN Venta v ON c.ClienteId = v.ClienteId 
WHERE DATEDIFF(YEAR, p.FechaNacimiento ,GETDATE())  < 35
AND  CAST( v.Fecha AS Date ) AS date 
   BETWEEN CAST( '2000-02-01' AS Date ) AND CAST( '2000-04-25' AS Date )
   
---Obtener el valor total vendido por cada producto en el año 2000
SELECT SUM(p.Precio) 
     , p.Nombre 
FROM Venta v 
JOIN Ordenes o ON v.VentaId  = o.VentaId 
JOIN Productos p ON o.ProductoId = p.ProductoId 
WHERE CAST( v.Fecha AS Date ) AS date 
   BETWEEN CAST( '2000-01-01' AS Date ) AND CAST( '2000-12-31' AS Date )
   
   
---Obtener la última fecha de compra de un cliente y 
---según su frecuencia de compra estimar
--en qué fecha podría volver a comprar.
   
SELECT * 
FROM Clientes c 
JOIN Personas p ON c.PersonaId = p.PersonaId 
JOIN Venta v ON c.ClienteId = v.ClienteId 
GROUP BY c.ClienteId ,p.Nombres, v.Fecha  


--Obtener la última fecha de compra de un cliente y 
--según su frecuencia de compra estimar
--en qué fecha podría volver a comprar.
SELECT p.*
     , v.Fecha 
FROM Personas p
JOIN Venta v ON p.PersonaId = v.ClienteId 
   (SELECT 
         p2.PersonaId 
        ,max(v2.Fecha) AS ultima_fecha 
      FROM Personas p2 
      JOIN Venta v2 ON p2.PersonaId = v2.ClienteId 
      GROUP BY p2.PersonaId) per
WHERE p.PersonaId = per.PersonaId
AND v.Fecha = per.ultima_fecha;
