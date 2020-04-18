using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parks
{
    public class Park
    {
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private int v5;
        private int v6;
        private int v7;
        private int v8;
        private int v9;
        private int v10;

        public String id { get; set; }
        public String name { get; set; }
        public String description{get; set;}
        public String addressNum { get; set;}
        public String addressStreet { get; set; }
        public String addressCity { get; set; }
        public String addressState { get; set; }
        public String addressZip { get; set; }
        public String image { get; set; }
        //public Boolean visited { get; set; }
        //public Boolean todo { get; set; }

        public String visited { get; set; }
        public String todo { get; set; }

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
            this.visited = visited;
            this.todo = todo;
            Trace.WriteLine(visited);
            Trace.WriteLine(todo);
            //having an issue with these lines below commiting before adding the unit testing suite
            //this.visited = System.Convert.ToBoolean(visited);
            //this.todo = System.Convert.ToBoolean(todo);
        }

        public Park(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.v8 = v8;
            this.v9 = v9;
            this.v10 = v10;
        }
    }
}
