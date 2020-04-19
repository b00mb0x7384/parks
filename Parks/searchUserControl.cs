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
        public event EventHandler buttonClicked;
        protected virtual void onButtonClicked(EventArgs e)
        {
            buttonClicked?.Invoke(this, e);
        }
        public searchUserControl()
        {
            InitializeComponent();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {

            onButtonClicked(EventArgs.Empty);
        }

        private void recCheckYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchUserControl_Load(object sender, EventArgs e)
        {

        }

        private void planCheckYes_CheckedChanged(object sender, EventArgs e)
        {



        }
    }
}
