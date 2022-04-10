using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_project
{
    class FoodEntry
    {
        public Guid uniqueFoodIdentifier { get; set; }
        public String userName { get; set; }
        public double foodEaten { get; set; }
        public double calCount { get; set; }
        public string foodEntry { get; set; }
        public DateTime eatingTime { get; set; }


        public FoodEntry(string name, string foodEntry, double foodEaten, double calCount, DateTime eatingTime)
        {
            this.uniqueFoodIdentifier = Guid.NewGuid();
            this.userName = name;
            this.eatingTime = eatingTime;
            this.foodEntry = foodEntry;
            this.foodEaten = foodEaten;
            this.calCount = calCount;

        }
        //Username, or Guid 

        //time of entry or time of eating 

        //food types: breakfast lunch dinner dessert veggies, pizza, chicken wings, 

        //callorie property


    }
}
