using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using TestBinding.UI.TestWindow;
using TestBinding.ViewModel;

namespace TestWindowDLL
{
    internal class Test : Button
    {
        protected override void OnClick()
        {
            var window = new TestWindow();
            window.DataContext = new TestWindowViewModel
            {
                Title = TestSession.Title,
                Button1Command = new RelayCommand(() => ArcGIS.Desktop.Framework.Dialogs.MessageBox.Show("Hi 1")),
                Button2Command = new RelayCommand(() => ArcGIS.Desktop.Framework.Dialogs.MessageBox.Show("Hi 2"))
            };

            window.ShowDialog();
        }
    }
}
