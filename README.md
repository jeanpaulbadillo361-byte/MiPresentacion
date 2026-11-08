# MiPresentacion

Aplicación de escritorio desarrollada en C# utilizando Avalonia UI 11, diseñada para capturar, validar y mostrar información personalizada de un usuario mediante una interfaz gráfica interactiva.

## 📋 Descripción de la Aplicación
`MiPresentacion` es un programa educativo que permite ingresar datos básicos (nombre, apellido y edad) a través de un formulario visual, validando que la información sea correcta antes de mostrar un saludo personalizado en pantalla. Además, incluye opciones para limpiar los campos y alternar entre distintos estilos de saludo.

## 🎛️ Controles Utilizados
- **Window**: Contenedor principal de la aplicación.
- **StackPanel**: Organiza visualmente los controles en formato vertical y horizontal, utilizando propiedades de distribución limpia.
- **TextBlock**: Se utiliza tanto para mostrar etiquetas descriptivas fijas como para renderizar el resultado o los mensajes de advertencia de validación (`TxtResultado`).
- **TextBox**: Cajas de texto interactivas identificadas mediante `x:Name` (`TxtNombre`, `TxtApellido`, `TxtEdad`) para capturar la entrada del usuario.
- **Button**: Botones interactivos que responden a eventos de clic para procesar la información.

## ⚡ Funcionamiento de los Eventos (`MainWindow.axaml.cs`)
La lógica de la aplicación se ejecuta mediante controladores de eventos asociados a los botones:
1. **Validación de datos**: Comprueba que los campos no estén vacíos usando `string.IsNullOrWhiteSpace()` y valida que la edad sea un número entero positivo válido mediante `int.TryParse()`.
2. **Interactividad**: Permite procesar los datos de entrada para generar dinámicamente un saludo personalizado o restablecer los campos al estado inicial mediante el botón de limpieza.

## 🚀 Instrucciones para Ejecutar
Asegúrate de tener instalado el SDK de .NET y abre una terminal en la carpeta raíz del proyecto:

```bash
dotnet run
