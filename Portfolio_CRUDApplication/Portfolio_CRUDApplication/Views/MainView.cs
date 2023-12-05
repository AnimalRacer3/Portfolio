using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackageTracker.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btn_Packages.Click += delegate { ShowPackageView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowPackageView;
    }
}
