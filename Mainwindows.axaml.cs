using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    private int _tipoSaludo = 1;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnPresentarme_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = TxtNombre.Text?.Trim() ?? string.Empty;
        string apellido = TxtApellido.Text?.Trim() ?? string.Empty;
        string edadTexto = TxtEdad.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(nombre))
        {
            TxtResultado.Text = "Advertencia: El campo 'Nombre' no puede estar vacío.";
            return;
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            TxtResultado.Text = "Advertencia: El campo 'Apellido' no puede estar vacío.";
            return;
        }

        if (!int.TryParse(edadTexto, out int edad))
        {
            TxtResultado.Text = "Advertencia: La edad debe ser un número entero válido.";
            return;
        }

        if (edad <= 0)
        {
            TxtResultado.Text = "Advertencia: La edad debe ser un número entero positivo mayor a cero.";
            return;
        }

        MostrarMensaje(nombre, apellido, edad);
    }

    private void BtnCambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        _tipoSaludo = _tipoSaludo == 1 ? 2 : 1;

        string nombre = TxtNombre.Text?.Trim() ?? string.Empty;
        string apellido = TxtApellido.Text?.Trim() ?? string.Empty;
        string edadTexto = TxtEdad.Text?.Trim() ?? string.Empty;

        if (!string.IsNullOrWhiteSpace(nombre) && 
            !string.IsNullOrWhiteSpace(apellido) && 
            int.TryParse(edadTexto, out int edad) && 
            edad > 0)
        {
            MostrarMensaje(nombre, apellido, edad);
        }
        else
        {
            TxtResultado.Text = $"Estilo de saludo cambiado al modo {_tipoSaludo}. Ingrese sus datos para visualizarlo.";
        }
    }

    private void BtnLimpiar_Click(object? sender, RoutedEventArgs e)
    {
        TxtNombre.Text = string.Empty;
        TxtApellido.Text = string.Empty;
        TxtEdad.Text = string.Empty;
        TxtResultado.Text = "Ingrese sus datos y presione Presentarme.";
        _tipoSaludo = 1;
        TxtNombre.Focus();
    }

    private void MostrarMensaje(string nombre, string apellido, int edad)
    {
        if (_tipoSaludo == 1)
        {
            TxtResultado.Text = $"¡Hola! Mi nombre es {nombre} {apellido},\ntengo {edad} años y estoy aprendiendo\na desarrollar interfaces gráficas con C#.";
        }
        else
        {
            TxtResultado.Text = $"¡Saludos! Soy {nombre} {apellido}.\nActualmente tengo {edad} años de edad y me encuentro explorando la creación de aplicaciones de escritorio con Avalonia UI.";
        }
    }
}
