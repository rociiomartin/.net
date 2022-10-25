using ejercicios;
using Microsoft.Extensions.DependencyInjection;

//var proveedor = new ProveedorServicios();
//IServicioX servicio = proveedor.GetServicioX();
//servicio.Ejecutar();

//luego del comando -->dotnet add package Microsoft.Extensions.Hosting

//configurando las dependencias que voy a usar
var servicios = new ServiceCollection();
servicios.AddTransient<IServicioX, ServicioX>();// para el IServicioX me tiene q devolver un ServicioX (ya sabe como construirlo)
servicios.AddTransient<ILogger, LoggerConsola>();//para el ILogger me tiene q devolver un LoggerConsola
var proveedor =  servicios.BuildServiceProvider();

//uso el proveedor
IServicioX? servicio = proveedor?.GetService<IServicioX>();
servicio?.Ejecutar();
