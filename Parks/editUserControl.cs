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
    public partial class editUserControl : UserControl
    {
        public event EventHandler updateButtonClicked;
        public event EventHandler deleteButtonClicked;
        public event EventHandler addButtonClicked;


        protected virtual void onUpdateButtonClicked(EventArgs e)

        {
            updateButtonClicked?.Invoke(this, e);
        }
        protected virtual void onDeleteButtonClicked(EventArgs e)
        {
            deleteButtonClicked?.Invoke(this, e);
        }
        protected virtual void onAddButtonClicked(EventArgs e)
        {
            addButtonClicked?.Invoke(this, e);
        }


        public editUserControl()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            onUpdateButtonClicked(e);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            onAddButtonClicked(e);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            onDeleteButtonClicked(e);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
