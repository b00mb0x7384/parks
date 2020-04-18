using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parks
{
    public partial class searchUserControl : UserControl  
    {
        public searchUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        //protected void searchButton_Click(object sender, EventArgs e)
        //{
        //    //bubble the event up to the parent
        //    if (this.ButtonClick != null)
        //        this.ButtonClick(this, e);
        //}

        
    }
}
