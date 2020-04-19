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
    public partial class planVisitControl : UserControl
    {

        public event EventHandler buttonClicked;
        protected virtual void onButtonClicked(EventArgs e)
        {
            buttonClicked?.Invoke(this, e);
        }
        public planVisitControl()
        {
            InitializeComponent();
        }




        private void planVisitControl_Load(object sender, EventArgs e)
        {
        }

        private void planButton_Click(object sender, EventArgs e)
        {
            onButtonClicked(EventArgs.Empty);

        }
    }
}
