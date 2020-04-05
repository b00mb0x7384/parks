using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parks
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            var homeCustomControl = new homeCustomControl();


            InitializeComponent();

            //Navigation highlight default position
            navShowCurrent.Height = homeButton.Height;
            navShowCurrent.Top = homeButton.Top;

            mainViewPanel.Controls.Add(homeCustomControl);

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //Create instance of home screen to instert into mainViewPanel
            var homeCustomControl = new homeCustomControl();

            //Navigation highlight
            navShowCurrent.Height = homeButton.Height;
            navShowCurrent.Top = homeButton.Top;

            //Hide the navigation logo
            logoPicBox.Visible = false;

            //Main display area for user controls
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(homeCustomControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "All State Parks";

            //Changes dataGridView viewLabel
            viewLabel.Text = "Select a park and press view to see more information.";

            //Show view button
            viewButton.Visible = true;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Create instance of home screen to instert into mainViewPanel
            var searchUserControl = new searchUserControl();

            //Navigation highlight
            navShowCurrent.Height = searchButton.Height;
            navShowCurrent.Top = searchButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(searchUserControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Search Results";

            //Changes dataGridView viewLabel
            viewLabel.Text = "Select a park and press view to see more information.";

            //Show view button
            viewButton.Visible = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Create instance of home screen to instert into mainViewPanel
            var editUserControl = new editUserControl();

            //Navigation highlight
            navShowCurrent.Height = editButton.Height;
            navShowCurrent.Top = editButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(editUserControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Select Park to Edit";

            //Changes dataGridView viewLabel
            viewLabel.Text = "Select Park to Update Information";

            //Hide view button
            viewButton.Visible = false;

        }

        private void planButton_Click(object sender, EventArgs e)
        {
            //Navigation highlight
            navShowCurrent.Height = planButton.Height;
            navShowCurrent.Top = planButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;
            
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            //Navigation highlight
            navShowCurrent.Height = recordButton.Height;
            navShowCurrent.Top = recordButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();

            //TODO add save and prompt message
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //TODO will need to add code that takes selected row from dataviewgrid and populates the viewParkControl fields.
        
            //Create instance of viewParkControl screen to instert into mainViewPanel
            var viewParkControl = new viewParkControl();

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(viewParkControl);

                   }
    }
}
