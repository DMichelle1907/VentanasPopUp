using MauiPopup.Views;
using MauiPopup;
namespace VentanasPopUp;

public partial class Transacciones : BasePopupPage
{
	public Transacciones()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		PopupAction.ClosePopup(this);
    }
}