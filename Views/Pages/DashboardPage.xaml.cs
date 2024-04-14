using UiDesktopApp1.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace UiDesktopApp1.Views.Pages
{
  public partial class DashboardPage : INavigableView<DashboardViewModel>
  {
    public DashboardViewModel ViewModel { get; }

    public DashboardPage(DashboardViewModel viewModel)
    {
      try
      {
        ViewModel = viewModel;
        DataContext = this;

        InitializeComponent();
      }
      catch(Exception ex)
      {
        System.Windows.MessageBox.Show(ex.Message);
      }
    }
  }
}
