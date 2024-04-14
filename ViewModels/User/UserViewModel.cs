
namespace UiDesktopApp1.ViewModels.User
{
  public partial class UserViewModel : ObservableObject
  {
    [ObservableProperty]
    private int cnt = 0;
    [RelayCommand]
    private void onBtn()
    {
      Cnt++;
      MessageBox.Show("asdasd");
    }
  }
}
