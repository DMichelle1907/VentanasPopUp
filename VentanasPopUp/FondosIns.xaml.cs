using MauiPopup;
using MauiPopup.Views;

namespace VentanasPopUp;

public partial class FondosIns : BasePopupPage
{
	public FondosIns()
	{
		InitializeComponent();
	}

    private void Button_Clicked6(object sender, EventArgs e)
    {
        PopupAction.ClosePopup(this);
    }
}