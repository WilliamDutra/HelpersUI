using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpersUI.WindowsForms.UCS
{
    public partial class UCGrid : UserControl
    {
        public object DataSource
        {
            get { return Grid.DataSource; }
            set { Grid.DataSource = value; }
        }

        public UCGrid()
        {
            InitializeComponent();
        }
    }
}
