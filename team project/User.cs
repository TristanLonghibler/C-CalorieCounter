using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_project
{
    class User
    {
        public String userName { get; set; }
        public int userHeightFt { get; set; }
        public int userHeightIn { get; set; }
        public int userWeight { get; set; }
        public float BMI { get; set; }

        public List<FoodEntry> foodEaten { get; set; }

        public User(string userName, int userHeightFt, int userHeightIn, int userWeight)
        {
            this.userName = userName;
            this.userHeightFt = userHeightFt;
            this.userHeightIn = userHeightIn;
            this.userWeight = userWeight;
            this.foodEaten = new List<FoodEntry>();
        }

        //Had to make a property to return the name, instead of accessing the public member directly.
        //This is used in the binding data source for the user list combobox
        //public string NameProperty
        //{
        //    get
        //    {
        //        return userName;
        //    }
        //}
    }
}
