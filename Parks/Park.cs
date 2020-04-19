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

        public String id { get; set; }
        public String name { get; set; }
        public String description{get; set;}
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

        public String address
        {
            get;
            set;
        }
        // constructor for this class.
        public Park(String id, String name, String description,String image, String address, String visited,String todo){
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.address = address;
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

        public String toCsv()
        {
            var intTodo = this.todo.Equals(true) ? 1 : 0;
            var intVisit = this.visited.Equals(true) ? 1 : 0;

            String legalString = this.id + ";" + this.name + ";" + this.description + ";" + this.image + ";" + this.address + ";" + intVisit + ";" + intTodo;
            return legalString;
        }
    }

}






