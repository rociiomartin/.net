using ejercicios;
var servicios = new ServiceCollection();
servicios.AddTransient<IServicioX, ServicioX>();
servicios.AddTransient<ILogger, LoggerConsola>();
var proveedor =  servicios.BuildServiceProvider();
