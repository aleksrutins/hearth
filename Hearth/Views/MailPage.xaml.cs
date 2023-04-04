using CommunityToolkit.WinUI.UI.Controls;

using Hearth.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Hearth.Views;

public sealed partial class MailPage : Page
{
    public MailViewModel ViewModel
    {
        get;
    }

    public MailPage()
    {
        ViewModel = App.GetService<MailViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
