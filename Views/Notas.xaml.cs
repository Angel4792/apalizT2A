namespace apalizT2A.Views;

public partial class Notas : ContentPage
{
    public Notas(string usuario)
    {
        InitializeComponent();
        DisplayAlert("Bienvenido", usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btbCalculo_Clicked(object sender, EventArgs e)
    {
        if (pkseleccion.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un estudiante", "Cerrar");
        }

        if (!double.TryParse(txtNota1.Text, out double nota1))
        {
            DisplayAlert("Error", "Por favor ingrese valores numericos", "Cerrar");

        }
        if (!double.TryParse(txtNota2.Text, out double nota2))
        {
            DisplayAlert("Error", "Por favor ingrese valores numericos", "Cerrar");
        }
        if (!double.TryParse(txtExamen1.Text, out double examen))
        {
            DisplayAlert("Error", "Por favor ingrese valores numericos", "Cerrar");
        }
        if (!double.TryParse(txtExamen1.Text, out double examen2))
        {
            DisplayAlert("Error", "Por favor ingrese valores numericos", "Cerrar");
        }

        //// Condicion si es menor a 0 o mayor que 10 al ingreso de datos
        //Prueba
        if (nota1 < 0 || nota1 > 10)
        {
            DisplayAlert("Error", "Los valores deben estar entre 0 y 10", "Cerrar");
        }
        if (nota2 < 0 || nota2 > 10)
        {
            DisplayAlert("Error", "Los valores deben estar entre 0 y 10", "Cerrar");
        }
        //Examen
        if (examen < 0 || examen > 10)
        {
            DisplayAlert("Error", "Los valores deben estar entre 0 y 10", "Cerrar");
        }
        if (examen2 < 0 || examen2 > 10)
        {
            DisplayAlert("Error", "Los valores deben estar entre 0 y 10", "Cerrar");
        }

        double parcial1 = (nota1 * 0.3) + (examen * 0.2);
        double parcial2 = (nota2 * 0.3) + (examen2 * 0.2);
        double notafinal = parcial1 + parcial2;

        string estado;
        if (notafinal >= 7)
        {
            estado = "Aprobado";
        }
        else if (notafinal >= 5 && notafinal <= 6.9)
        {
            estado = "Complementario";
        }
        else
        {
            estado = "Reprobado";
        } 



        
        
        DateTime currentTime = DateTime.Now; // Hora actual
        DateTime selectedDate = datePicker.Date;

        string nombre = pkseleccion.Items[pkseleccion.SelectedIndex].ToString();
        DisplayAlert("Notas", "Nombre: " + nombre + "\nFecha: " + selectedDate.ToString("dd/MM/yyyy") +
            "\nHora actual: " + currentTime.ToString("HH:mm") +
            "\nNota primer parcial: " + parcial1 + "\nNota segundo parcial: " 
            + parcial2 + "\nNota final: " + notafinal + "\nEstado: " + estado, "Aceptar");
    }


}