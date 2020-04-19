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
using System.Text.RegularExpressions;

namespace Parks
{
    //TODO: add activeview to all of these methods below so that we dont get stuck on edit;
    public partial class MainForm : Form
    {
        editUserControl editUserControl;
        planVisitControl planVisitControl;
        recVisitControl recVisitControl;
        viewParkControl viewParkControl;
        searchUserControl searchUserControl;
        public int selectedPark;
        List<Park> parksList = new List<Park>();
        List<Park> matches = new List<Park>();
        List<Park> distinctList = new List<Park>();
        String activeView;


        private void getParks(){
            using (var reader = new StreamReader(@"../../parks.csv"))
            {
                while (!reader.EndOfStream){
                    var parkRow = reader.ReadLine();
                    var parkRowArray = parkRow.Split(';');
                    // each park has col sorry for this long statement, it was here or in the parks.cs
                var  tempPark = new Park(parkRowArray[0],parkRowArray[1], parkRowArray[2],parkRowArray[3],parkRowArray[4],parkRowArray[5], parkRowArray[6],parkRowArray[7],parkRowArray[8],parkRowArray[9],parkRowArray[10]);
                    this.parksList.Add(tempPark);

                }
                updateTheView();

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
            updateTheView();


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Create instance of home screen to instert into mainViewPanel
             this.searchUserControl = new searchUserControl();
            this.searchUserControl.buttonClicked += searchUserControl_buttonClicked;

            //Navigation highlight
            navShowCurrent.Height = searchButton.Height;
            navShowCurrent.Top = searchButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(this.searchUserControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Search Results";

            //Changes dataGridView viewLabel
            viewLabel.Text = "Select a park and press view to see more information.";

            //Show view button
            viewButton.Visible = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.activeView = "edit";
            //Create instance of home screen to instert into mainViewPanel
           this.editUserControl = new editUserControl();
            this.updateTheView();
            this.editUserControl.deleteButtonClicked += editUserControl_deleteButtonClicked;
            this.editUserControl.addButtonClicked += editUserControl_addButtonClicked;
            this.editUserControl.updateButtonClicked += editUserControl_updateButtonClicked;


            //Navigation highlight
            navShowCurrent.Height = editButton.Height;
            navShowCurrent.Top = editButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(this.editUserControl);

            //Changes dataGridView Label
            mainDataLabel.Text = "Select Park to Edit";

            //Changes dataGridView viewLabel
            viewLabel.Text = "Select Park to Update Information";

            //Hide view button
            viewButton.Visible = false;

        }

        private void planButton_Click(object sender, EventArgs e)
        {
            activeView ="plan";
            //Create instance of home screen to instert into mainViewPanel
           this.planVisitControl = new planVisitControl();

            //Navigation highlight
            navShowCurrent.Height = planButton.Height;
            navShowCurrent.Top = planButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(this.planVisitControl);

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
            this.recVisitControl = new recVisitControl();

            //Navigation highlight
            navShowCurrent.Height = recordButton.Height;
            navShowCurrent.Top = recordButton.Top;

            //Show the navigation logo
            logoPicBox.Visible = true;

            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(this.recVisitControl);

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
            this.viewParkControl = new viewParkControl();
            this.selectedPark = mainDataGrid.CurrentRow.Index;
            this.viewParkControl.nameTextBox.Text = parksList[selectedPark].name;
            this.viewParkControl.descTextBox.Text = parksList[selectedPark].description;
            this.viewParkControl.addTextBox.Text = parksList[selectedPark].address;
            this.viewParkControl.pictureBox1.ImageLocation = @"../../park_images/" + parksList[selectedPark].image;
            // TODO: see if we can add a trycatch here so it doesnt explode
           

            this.viewParkControl.planCheckYes.Checked = parksList[selectedPark].todo.Equals(true) ? true : false;
            this.viewParkControl.planCheckNo.Checked = parksList[selectedPark].todo.Equals(false) ? true : false;
            //Update the array of we click on this.

            parksList[selectedPark].visited = this.viewParkControl.planCheckYes.Checked;

            this.viewParkControl.recCheckYes.Checked = parksList[selectedPark].visited.Equals(true) ? true : false;
            this.viewParkControl.recCheckYes.Enabled = false;

            this.viewParkControl.recCheckNo.Checked = parksList[selectedPark].visited.Equals(false) ? true : false;
            this.viewParkControl.recCheckNo.Enabled = false;

            this.viewParkControl.planCheckNo.Enabled = false;
            this.viewParkControl.planCheckYes.Enabled = false;

            //this.visited = visited.Equals("1") ? true : false;



            //Clear the mainViewPanel and add the desired user control
            mainViewPanel.Controls.Clear();
            mainViewPanel.Controls.Add(this.viewParkControl);
            
                   }

        private void mainViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addMatch(Park x)
        {
            bool alreadyExist = this.matches.Contains(x);
            if (!alreadyExist)
            {
                Trace.WriteLine("adding park" + x.name);
                this.matches.Add(x);
            }
            else
            {
                Trace.Write("Already Exists not adding park " + x.name);
            }


        }
        private void searchUserControl_buttonClicked(object sender, EventArgs e)
        {
            
            this.matches.Clear();
            //mainDataGrid.DataSource = parksList;
            foreach (Park park in parksList)
            {
                if (park.name.ToUpper().Contains(this.searchUserControl.nameTextBox.Text.ToUpper()) && this.searchUserControl.nameTextBox.Text.ToUpper() != "")
                {
                    Trace.WriteLine("adding park from method name" + park.name);
                   addMatch(park);

                    
                }

                if (park.address.ToUpper().Contains(this.searchUserControl.addTextBox.Text.ToUpper()) && this.searchUserControl.addTextBox.Text.ToUpper() != "")
                {
                    
                    Trace.WriteLine("adding park from method adds" + park.name);
                   addMatch(park);

                }

                // i really dont like this functionality below 
                //if (park.todo.Equals(this.searchUserControl.planCheckYes.Checked))
                //{

                //    addMatch(park);

                //}
                //if (park.todo.Equals(!this.searchUserControl.planCheckNo.Checked))
                //{

                //    addMatch(park);

                //}



            }
            //this.distinctList = this.matches.Distinct().ToList();

            mainDataGrid.DataSource = null;
            mainDataGrid.DataSource = this.matches;
            mainDataGrid.Columns["image"].Visible = false;




            //var searchResults = parksList.Find(x => x.name.Contains(this.searchUserControl.nameTextBox.Text.ToUpper()));
            //MessageBox.Show(matchingvalues.ToString());


        }
        private void editUserControl_deleteButtonClicked(object sender, EventArgs e)
        {
            //MessageBox.Show("hit delete button");
            parksList.RemoveAt(selectedPark);
            updateTheView();
        }
        private void editUserControl_addButtonClicked(object sender, EventArgs e)
        {

            String parkName = editUserControl.nameTextBox.Text;
            String parkAddress = editUserControl.addTextBox.Text;
            String parkDesc = editUserControl.descTextBox.Text;
            String parkId = (this.parksList.Count + 1).ToString();
            Park newPark = new Park(parkId,parkName, parkDesc, "default.jpg","","","","","","","",parkAddress);
            Trace.WriteLine(newPark.name);
            this.parksList.Add(newPark);
            updateTheView();
            //MessageBox.Show("hit add button");
        }
        private void editUserControl_updateButtonClicked(object sender, EventArgs e)
        {
            String parkName = editUserControl.nameTextBox.Text;
            String parkAddress = editUserControl.addTextBox.Text;
            String parkDesc = editUserControl.descTextBox.Text;
            this.parksList[selectedPark].name = parkName;
            this.parksList[selectedPark].SetAddress(parkAddress);
            this.parksList[selectedPark].description = parkDesc;

            updateTheView();
        }

        private void mainDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPark = -1;
            selectedPark = mainDataGrid.CurrentRow.Index;
            MessageBox.Show("clicked on a cell" + parksList[selectedPark].name);
            switch (activeView)
            {
                case "edit":
                   
                    this.editUserControl.nameTextBox.Text = this.parksList[selectedPark].name;
                    this.editUserControl.descTextBox.Text = this.parksList[selectedPark].description;
                    this.editUserControl.addTextBox.Text = this.parksList[selectedPark].address;

                    break;

                case "plan":

                    this.planVisitControl.nameTextBox.Text = this.parksList[selectedPark].name;
                    this.planVisitControl.descTextBox.Text = this.parksList[selectedPark].description;
                    this.planVisitControl.addTextBox.Text = this.parksList[selectedPark].address;
                    this.planVisitControl.pictureBox1.ImageLocation = @"../../park_images/" + parksList[selectedPark].image;

                    break;

                default:
                    break;
            }
        }
        private void updateTheView()
        {
            mainDataGrid.DataSource = null;
            mainDataGrid.DataSource = this.parksList;
            mainDataGrid.Columns["image"].Visible = false;


        }
    }
   


}
