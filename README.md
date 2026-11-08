# MiPresentacion - Avalonia UI

Aplicación desarrollada en Avalonia UI para la gestión y validación de datos.

## Capturas de la Aplicación

### Estado Inicial
![Estado Inicial](inicial.png)

### Estado de Éxito
![Estado de Éxito](exito.png)

### Estado de Error
![Estado de Error](error.png)

## Pregunta de Reflexión

**¿Cuál es la función de MainWindow.axaml y MainWindow.axaml.cs, y cómo se relacionan mediante x:Name y los eventos Click para permitir que el usuario interactúe con la aplicación?**

* **MainWindow.axaml:** Es el archivo encargado de definir la estructura visual y el diseño de la interfaz gráfica de usuario utilizando etiquetas XAML (organizando los textos, campos de entrada y botones).
* **MainWindow.axaml.cs:** Contiene la lógica de programación en C# (el código detrás de la vista) que le da comportamiento a la aplicación, procesando las validaciones y las acciones.
* **Relación por x:Name y eventos Click:** El atributo `x:Name` permite etiquetar los elementos visuales del XAML para que el archivo de C# pueda reconocerlos y manipularlos directamente (por ejemplo, leer lo que el usuario escribe). Por su parte, los eventos `Click` conectan la acción física del usuario al presionar un botón con el método correspondiente en C#, permitiendo que la interfaz responda dinámicamente.
