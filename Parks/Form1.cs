using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;


namespace Parks
{
    public partial class MainForm : Form
    {
        public int selectedPark;
        List<Park> parksList = new List<Park>();

        private void getParks(){
            using (var reader = new StreamReader(@"./parks.csv"))
            {
                while (!reader.EndOfStream){
                    var parkRow = reader.ReadLine();
                    var parkRowArray = parkRow.Split(';');
                    // each park has col sorry for this long statement, it was here or in the parks.cs
                var  tempPark = new Park(parkRowArray[0],parkRowArray[1], parkRowArray[2],parkRowArray[3],parkRowArray[4],parkRowArray[5], parkRowArray[6],parkRowArray[7],parkRowArray[8],parkRowArray[9],parkRowArray[10]);
                    this.parksList.Add(tempPark);

                }
                mainDataGrid.DataSource = this.parksList;


            }

        }


        public MainForm()
        {
            var homeCustomControl = new homeCustomControl();
            InitializeComponent();
            this.getParks();
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
            //Create instance of home screen to instert into mainViewPanel
            var planVisitControl = new planVisitControl();

            //Navigation highlight
            navShowCurrent.Height = planButton.Height;
            navShowCurrent.Top = planButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(planVisitControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Select Park to Edit";

            //Changes dataGridView viewLabel
            viewLabel.Text = "";

            //Hide view button
            viewButton.Visible = false;

        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            //Create instance of home screen to instert into mainViewPanel
            var recVisitControl = new recVisitControl();

            //Navigation highlight
            navShowCurrent.Height = recordButton.Height;
            navShowCurrent.Top = recordButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(recVisitControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Select Park to Edit";

            //Changes dataGridView viewLabel
            viewLabel.Text = "";

            //Hide view button
            viewButton.Visible = false;

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
            this.selectedPark = mainDataGrid.CurrentRow.Index;
            viewParkControl.nameTextBox.Text = parksList[selectedPark].name;
            viewParkControl.descTextBox.Text = parksList[selectedPark].description;
            viewParkControl.addTextBox.Text = parksList[selectedPark].prettyAddress();
            // viewParkControl.planCheckYes.Checked = parksList[selectedPark].visited;
            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(viewParkControl);
            
                   }

        private void mainViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
