using ejercicios;
var proveedor = new ProveedorServicios();
IServicioX servicio = proveedor.GetServicioX();
servicio.Ejecutar();

// hay que poner eso en la consola dotnet add package Microsoft.Extensions.Hosting
