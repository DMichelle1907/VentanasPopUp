using MauiPopup;
using MauiPopup.Views;

namespace VentanasPopUp;

public partial class AlertError : BasePopupPage
{
	public AlertError()
	{
		InitializeComponent();
	}

    private void Button_Clicked4(object sender, EventArgs e)
    {
        PopupAction.ClosePopup(this);
    }
}