using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parks
{
    class Park
    {
        public String id { get; set; }
        public String name { get; set; }
        public String description{get; set;}
        public String addressNum { get; set;}
        public String addressStreet { get; set; }
        public String addressCity { get; set; }
        public String addressState { get; set; }
        public String addressZip { get; set; }
        public String image{get; set;}
        public Boolean visited { get; set; }
        public Boolean todo { get; set; }
        public String prettyAddress()
        {
          var  add = addressNum + " " + addressStreet + " " + addressCity + " " + addressState + " " + addressZip;
            return add;
        }
        // constructor for this class.
        public Park(String id, String name, String description,String image, String addressNum, String addressStreet, String addressCity, String addressState, String addressZip, String visited,String todo){
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.addressNum = addressNum;
            this.addressStreet = addressStreet;
            this.addressCity = addressCity;
            this.addressState = addressState;
            this.addressZip = addressZip;
            this.visited = System.Convert.ToBoolean(visited);
            this.todo = System.Convert.ToBoolean(todo);
        }
    }
}
