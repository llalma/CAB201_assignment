using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MRRCManagement;

namespace MRRC
{
    public partial class Form1 : Form
    {
        /* things to do 
            
            gps n sunroof make check boxes
            prevent errors when trying to remove no rows
        */
        
        private string[] customerColumns = new string[] { "ID", "First name", "Last name","Gender", "DOB" };
        private string[] fleetColumns = new string[] { "Rego", "Make", "Model", "Year", "Class", "Seats", "Transmission", "Fuel", "GPS", "Sun-Roof", "Daily Rate", "Colour" };

        Fleet fleet = new Fleet();
        List<Vehicle> v  = new List<Vehicle>();

        CRM crm = new CRM();
        List<Customer> c = new List<Customer>();

        private const int ID_COL = 0;

        // ----globals for AddButtonVehicle----
      
        private string sunroofcheck;
        private string gpscheck;
        // ------------------------------------


        public Form1()
        {
            InitializeComponent();
            
            SetupComponents();
        }

        private void SetupComponents()
        {
            SetupDataGridViewColumns();
        }

        private void SetupDataGridViewColumns()
        {
            dataGridViewCustomers.ColumnCount = customerColumns.Length;
            for (int i = 0; i < customerColumns.Length; i++)
            {
                dataGridViewCustomers.Columns[i].Name = customerColumns[i];
            }

            dataGridViewFleet.ColumnCount = fleetColumns.Length;
            for (int j = 0; j < fleetColumns.Length; j++)
            {
                dataGridViewFleet.Columns[j].Name = fleetColumns[j];
            }

            // USED TO LABEL THE COLUMNS AT THE TOP OF THE TABLE

            v = fleet.GetFleet();
     
            for (int k = 0; k < v.Count(); k++)
            {
                string[] vehicle = v[k].ToCSVString().Split(',');
                this.dataGridViewFleet.Rows.Add(vehicle[0], vehicle[1], vehicle[2], vehicle[3], vehicle[4], vehicle[5], vehicle[6], vehicle[7], vehicle[8], vehicle[9], vehicle[11], vehicle[10]);
            }

            c = crm.GetCustomers();
           
            for (int l = 0; l < c.Count(); l++)
            {
                string[] customer = c[l].ToCSVString().Split(',');
                this.dataGridViewCustomers.Rows.Add(customer[0], customer[1], customer[2], customer[3], customer[4], customer[5]);
            }
            
            //USED TO ADD CUSTOMERS AND VEHICLES TO THE TABLE

        }
        /* USED TO SETUP THE TABLE
        */  

        private void AddButton_Click(object sender, EventArgs e)
        {
            RemoveButton.Enabled = false;
            ModifyButton.Enabled = false;
            
            AddGroupBox.Visible = true;
            AddGroupBox.Enabled = true;
        }
        /*  BUTTON USED TO ADD CAR FROM DATAGRIDVIEW
           
            once pressed, it disables all the other buttons and shows a group 
            box with user input forms
        */



        private void AddData(string Rego, string Make, string Model, string Year, string Class, string Seats, string Transmission, string Fuel, string GPS, string SunRoof, string DailyRate, string Colour)
        {


            OptionalParam( Seats,  Transmission,  Fuel,  GPS,  SunRoof,  DailyRate,  Colour);
            // sets defaults      


            string [] addedcar = { Rego,  Make,  Model,  Year,  Class,  Seats,  Transmission,  Fuel,  gpscheck, sunroofcheck,  DailyRate,  Colour };
            // what ur adding 

            dataGridViewFleet.Rows.Add(addedcar);
            // add row of strings to table
        }
        /*  USED TO CREATE DATA TO TABLE
        */

        private void OptionalParam(string Seats, string Transmission, string Fuel, string GPS, string SunRoof, string DailyRate, string Colour)
        {
            if (String.IsNullOrEmpty(ColourText.Text) || FuelCombo.SelectedIndex == -1 || TransmissionCombo.SelectedIndex == -1 || SeatsUpDown.Value == 0 || DailyRateUpDown.Value == 0 || GPSCheck.Checked == false || GPSCheck.Checked == false)
            {

                foreach (Control ctr in OptionalParamGroup.Controls)
                {
                    if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }
                    else if (ctr is CheckBox)
                    {
                        ((CheckBox)ctr).Checked = false;
                    }
                    else if (ctr is ComboBox)
                    {
                        ((ComboBox)ctr).SelectedIndex = 0;
                    }
                    else if (ctr is NumericUpDown)
                    {
                        ((NumericUpDown)ctr).Value = 0;
                    }
                }
                // resets all the inputs 

                //-----------SETTING DEFAULTS-------------------------------
                SeatsUpDown.Value = 4;
                TransmissionCombo.SelectedIndex = 1;
                FuelCombo.SelectedIndex = 1;
                GPSCheck.Checked = false;
                SunRoofCheck.Checked = false;
                ColourText.Text = "Black";
                
                // -----------CHECKING TO SEE WHICH CLASS IS SELECTED BEFORE SETTING PARAMS----------------
                if (ClassCombo.SelectedIndex == 1)
                {
                    DailyRateUpDown.Value = 50;
                }
                //economy
                else if (ClassCombo.SelectedIndex == 2)
                {
                    DailyRateUpDown.Value = 80;
                }
                //family
                else if (ClassCombo.SelectedIndex == 3)
                {
                    GPSCheck.Checked = true;
                    SunRoofCheck.Checked = true;
                    DailyRateUpDown.Value = 120;
                }
                //luxury
                else if (ClassCombo.SelectedIndex == 4)
                {
                    FuelCombo.SelectedIndex = 2; 
                    DailyRateUpDown.Value = 130;
                }
                //commercial 

            }
            /* set defaults 
             * if a class is chosen, change the according params 
            */

            //---------CHECK IF CHECKBOXES ARE CHECKED-------------------

            if (SunRoofCheck.Checked == true)
            {
                sunroofcheck = "True";
            }
            else
            {
                sunroofcheck = "False";
            }

            if (GPSCheck.Checked == true)
            {
                gpscheck = "True";
            }
            else
            {
                gpscheck = "False";
            }

        }

        private void AddAddButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            bool checkyear = false;
            int year2int = Convert.ToInt32(YearMaskedText.Text); // error when dont put anything


            if (year2int >= 1800 && year2int <= 2018)
            {
                checkyear = true;                
            }
            // checkyear = true, if valid year is inputed

            if (String.IsNullOrEmpty(RegoMaskedText.Text) || ClassCombo.SelectedIndex == -1 || checkyear == false)
            {
                MessageBox.Show("Must fill out mandatory sections!!!");
            }
            else
            {
                check = true;
            }
            // THIS CHECKS IF USER INPUT IS VALID      
        
            if (check == true)
            {
                AddData(RegoMaskedText.Text, MakeText.Text, ModelText.Text, YearMaskedText.Text, ClassCombo.Text, SeatsUpDown.Text, TransmissionCombo.Text, FuelCombo.Text, GPSCheck.Text, SunRoofCheck.Text, DailyRateUpDown.Text, ColourText.Text);
            }
            // ADD THE DATA         
        }

        /*  USED TO ADD DATA TO TABLE
        */
            



        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            RemoveButton.Enabled = true;
            ModifyButton.Enabled = true;
            
            AddGroupBox.Visible = false;
            AddGroupBox.Enabled = false;
        }
        /* CANCELES ADDING A CAR AND HIDES ADDCAR GROUP BOX,
         * RE-ENABLES HOME SCREEN BUTTONS
        */

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewFleet.CurrentCell.RowIndex;
            if (rowIndex == 0)
            {
                dataGridViewFleet.Rows.RemoveAt(rowIndex);
                //fleet.RemoveVehicle(rowIndex); i want to get the vehicle id of the row i selected so i can updatehte csv
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}