# HomeController

`HomeController` es el controlador predeterminado de la aplicación ASP.NET Core.
Se encarga de entregar las vistas principales (`Index` y `Privacy`) y de manejar
la página de error.

## Acciones

| Acción    | Descripción                                                                      |
|-----------|----------------------------------------------------------------------------------|
| `Index`   | Devuelve la vista principal de la aplicación.                                    |
| `Privacy` | Devuelve la vista de política de privacidad.                                     |
| `Error`   | Genera la vista de error y agrega información sobre el identificador de solicitud. |

## Dependencias

El controlador recibe un `ILogger<HomeController>` a través de inyección de dependencias
para registrar eventos o diagnósticos.
