﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parks
{
    public class Park
    {

        public String id { get; set; }
        public String name { get; set; }
        public String description{get; set;}
        public String addressNum { get; set;}
        public String addressStreet { get; set; }
        public String addressCity { get; set; }
        public String addressState { get; set; }
        public String addressZip { get; set; }
        public String image { get; set; }
        public Boolean visited
        {
            get; set;
        }
        public Boolean todo
        {
            get; set;
        }

        //public String visited { get; set; }
        //public String todo { get; set; }

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
            //this.visited = visited;
            //this.todo = todo;
            Trace.WriteLine(visited);
            Trace.WriteLine(todo);
            //having an iss-ue with these lines below commiting before adding the unit testing suite
            try{
                this.visited =  visited.Equals("1") ? true : false;
                this.todo = todo.Equals("1") ? true : false;

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(visited);
            }
        }

        
    }
}






