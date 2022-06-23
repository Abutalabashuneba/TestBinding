using ArcGIS.Desktop.Framework;
using System;
using System.Windows.Input;

namespace TestBinding.ViewModel
{
    public class TestWindowViewModel
    {
        public TestWindowViewModel()
        {
            Button1Command = new RelayCommand(() => throw new NotImplementedException());
            Button2Command = new RelayCommand(() => throw new NotImplementedException());
        }

        public string Title { get; set; }

        public ICommand Button1Command { get; set; }
        public ICommand Button2Command { get; set; }
    }
}
