using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace team_project
{
    public partial class Form1 : Form
    {
        BindingList<User> myUsersBSList = new BindingList<User>();
        BindingList<FoodEntry> myFoodEntriesBSList = new BindingList<FoodEntry>();

        public Form1()
        {
            InitializeComponent();
            UpdateUserDataSource();
        }

        private void UpdateUserDataSource()
        {
            comboBoxUser.DataSource = myUsersBSList;
            comboBoxUser.DisplayMember = "userName";

            
        }

        private void UpdateFoodDataSource()
        {
            comboBoxFoodEntry.DataSource = myFoodEntriesBSList;
            comboBoxFoodEntry.DisplayMember = "foodEntry";

            String userName = comboBoxUser.Text;

            for (int i = 0; i < myUsersBSList.Count; i++)
            {
                if (myUsersBSList[i].userName == userName)
                {
                    myFoodEntriesBSList = new BindingList<FoodEntry>(myUsersBSList[i].foodEaten);
                }
            }

            textBoxFoodEntry.Clear();
            calCount.Clear();
            foodEaten.Clear();

        }

        private void textBoxHeightFeet_Enter(object sender, System.EventArgs e)
        {
            if (textBoxHeightFeet.Text == "ft")
            {
                textBoxHeightFeet.Text = "";
            }
        }

        private void textBoxHeightFeet_Leave(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHeightFeet.Text) == true)
            {
                textBoxHeightFeet.Text = "ft";
            }
        }

        private void textBoxHeightInches_Enter(object sender, System.EventArgs e)
        {
            if (textBoxHeightInches.Text == "in")
            {
                textBoxHeightInches.Text = "";
            }
        }

        private void textBoxHeightInches_Leave(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHeightInches.Text) == true)
            {
                textBoxHeightInches.Text = "in";
            }
        }

        private void textBoxWeight_Enter(object sender, System.EventArgs e)
        {
            if (textBoxWeight.Text == "lbs")
            {
                textBoxWeight.Text = "";
            }
        }

        private void textBoxWeight_Leave(object sender, System.EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWeight.Text) == true)
            {
                textBoxWeight.Text = "lbs";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            labelUserError.Text = "";

            try
            {
                String userName = textBoxName.Text;
                int userHeightFt = int.Parse(textBoxHeightFeet.Text);
                int userHeightIn = int.Parse(textBoxHeightInches.Text);
                int userHeight = (userHeightFt * 12) + userHeightIn;
                int userWeight = int.Parse(textBoxWeight.Text);
                double userBMI = (703 * userWeight) / (Math.Pow(userHeight, 2));

                /* Implement update the myUsersBSList object with new data*/
                for (int i = 0; i < myUsersBSList.Count; i++)
                {
                    if (myUsersBSList[i].userName == userName)
                    {
                        myUsersBSList[i].userHeightFt = userHeightFt;
                        myUsersBSList[i].userHeightIn = userHeightIn;
                        myUsersBSList[i].userWeight = userWeight;
                    }
                }

                textBoxBMI.Text = userBMI.ToString("0.##");
            }

            catch (System.FormatException)
            {
                labelUserError.Text = "Invalid Inputs";
            }
           
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            labelUserError.Text = "";

            try
            {
                String userName = textBoxName.Text;
                int userHeightFt = int.Parse(textBoxHeightFeet.Text);
                int userHeightIn = int.Parse(textBoxHeightInches.Text);
                int userWeight = int.Parse(textBoxWeight.Text);

                User tempUser = new User(userName, userHeightFt, userHeightIn, userWeight);

                myUsersBSList.Add(tempUser);

            }

            catch (System.FormatException)
            {
                labelUserError.Text = "Invalid Inputs";
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.GetItemText(comboBoxUser.SelectedItem) != textBoxName.Text)
            {
                for (int i = 0; i < myUsersBSList.Count; i++)
                {
                    if (myUsersBSList[i].userName == comboBoxUser.Text)
                    {
                        int userHeight = (myUsersBSList[i].userHeightFt * 12) + myUsersBSList[i].userHeightIn;
                        int userWeight = myUsersBSList[i].userWeight;
                        double userBMI = (703 * userWeight) / (Math.Pow(userHeight, 2));

                        textBoxName.Text = myUsersBSList[i].userName;
                        textBoxHeightFeet.Text = myUsersBSList[i].userHeightFt.ToString();
                        textBoxHeightInches.Text = myUsersBSList[i].userHeightIn.ToString();
                        textBoxWeight.Text = myUsersBSList[i].userWeight.ToString();
                        textBoxBMI.Text = userBMI.ToString("0.##");
                        UpdateFoodDataSource();
                        break;
                    }
                }

            }
        }

        private void updatefood_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < myFoodEntriesBSList.Count; i++)
            {
                if (myFoodEntriesBSList[i].foodEntry == textBoxFoodEntry.Text)
                {
                    myFoodEntriesBSList[i].calCount = int.Parse(calCount.Text);
                    myFoodEntriesBSList[i].foodEaten = int.Parse(foodEaten.Text);
                }
            }
        }

        private void newfoodbutton_Click(object sender, EventArgs e)
        {
            try
            {
                String userName = comboBoxUser.Text;
                string foodEntry = textBoxFoodEntry.Text;
                double foodEaten = double.Parse(this.foodEaten.Text);
                double calCount = double.Parse(this.calCount.Text);
                DateTime eatingTime = dateTimePicker1.Value;

                FoodEntry tempFoodEntry = new FoodEntry(userName, foodEntry, foodEaten, calCount, eatingTime);

                for (int i = 0; i < myUsersBSList.Count; i++)
                {
                    if (myUsersBSList[i].userName == userName)
                    {
                        myUsersBSList[i].foodEaten.Add(tempFoodEntry);
                    }
                }

                UpdateFoodDataSource();

                //myFoodEntriesBSList.Add(tempFoodEntry);

            }

            catch (System.FormatException)
            {
                labelUserError.Text = "Invalid Inputs";
            }
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set food form entry fields back here when a new one is selected from the combo box
            if (comboBoxFoodEntry.GetItemText(comboBoxFoodEntry.SelectedItem) != textBoxFoodEntry.Text)
            {
                for (int i = 0; i < myFoodEntriesBSList.Count; i++)
                {
                    if (myFoodEntriesBSList[i].foodEntry == comboBoxFoodEntry.Text)
                    {
                        textBoxFoodEntry.Text = myFoodEntriesBSList[i].foodEntry;
                        calCount.Text = myFoodEntriesBSList[i].calCount.ToString();
                        foodEaten.Text = myFoodEntriesBSList[i].foodEaten.ToString();
                        break;
                    }
                }

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            UpdateFoodDataSource();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Food Entry"])
            {
                comboBoxFoodEntry.Items.Clear();

                //Need to assign the list of food, from the selected user, to the food combo box 
                for (int i = 0; i < myFoodEntriesBSList.Count; i++)
                {
                    if (myFoodEntriesBSList[i].userName == comboBoxUser.GetItemText(comboBoxUser.SelectedItem))
                    {
                        comboBoxFoodEntry.Items.Add(i);
                    }
                }
            }

            if (tabControl1.SelectedTab.Text == "Weekly Summary")
            {
                // display summary
                double totalCal = 0;
                var currentUser = comboBoxUser.GetItemText(comboBoxUser.SelectedItem);
                MessageBox.Show(currentUser);
                var userObj = myUsersBSList.SingleOrDefault(u => u.userName == currentUser);
                foreach(FoodEntry f in userObj.foodEaten)
                {
                    MessageBox.Show(f.foodEntry.ToString());
                    totalCal += f.calCount * f.foodEaten;
                }

                dataGridView1.Rows.Add(totalCal);



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
