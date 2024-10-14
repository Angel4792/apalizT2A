namespace apalizT2A.Views;

public partial class Login : ContentPage
{
    string[] usuarios = { "Luis", "Sandra", "Nicol", "Apaliz" };
    string[] contrasenas = { "luis1", "sandra2", "nicol3", "apaliz4" };

    public Login()
	{
		InitializeComponent();
	}
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuarioInput = txtUsuario.Text;
        string contrasenaInput = txtContrasena.Text;

        bool credencialesValidas = false;
        for (int i = 0; i < usuarios.Length; i++)
        {
            if (usuarios[i] == usuarioInput && contrasenas[i] == contrasenaInput)
            {
                credencialesValidas = true;
                break;
            }
        }

        if (credencialesValidas)
        {
            Navigation.PushModalAsync(new Notas(usuarioInput));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}

