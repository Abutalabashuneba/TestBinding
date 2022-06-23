using ArcGIS.Core.CIM;
using ArcGIS.Core.Data;
using ArcGIS.Core.Geometry;
using ArcGIS.Desktop.Catalog;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Editing;
using ArcGIS.Desktop.Extensions;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;
using ArcGIS.Desktop.Framework.Dialogs;
using ArcGIS.Desktop.Framework.Threading.Tasks;
using ArcGIS.Desktop.Layouts;
using ArcGIS.Desktop.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBinding.UI.TestWindow
{
    internal class ShowTestWindow : Button
    {

        private TestWindow _testwindow = null;

        protected override void OnClick()
        {
            //already open?
            if (_testwindow != null)
                return;
            _testwindow = new TestWindow();
            _testwindow.Owner = FrameworkApplication.Current.MainWindow;
            _testwindow.Closed += (o, e) => { _testwindow = null; };
            _testwindow.Show();
            //uncomment for modal
            //_testwindow.ShowDialog();
        }

    }
}
