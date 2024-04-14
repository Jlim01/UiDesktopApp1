using UiDesktopApp1.ViewModels.User;
using Wpf.Ui.Controls;


namespace UiDesktopApp1.Views.User
{
  /// <summary>
  /// Interaction logic for User.xaml
  /// </summary>
  public partial class User : INavigableView<UserViewModel>
  {
    public UserViewModel ViewModel { get; }
    //public User(UserViewModel viewModel)
    //{
    //  ViewModel = viewModel;
    //  DataContext = this;

    //  InitializeComponent();
    //}
    public User()
    {
      InitializeComponent();
    }
  }
}
