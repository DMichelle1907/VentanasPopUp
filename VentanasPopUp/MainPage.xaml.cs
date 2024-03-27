using MauiPopup;
namespace VentanasPopUp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTransacciones_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new Transacciones());
        }
        private void BtnServicios_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new Servicios());
        }
        private void BtnError_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new AlertError());
        }

        private void BtnUsuario_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new UsuarioCreado());
        }

        private void BtnFondos_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new FondosIns());
        }

    }

}
