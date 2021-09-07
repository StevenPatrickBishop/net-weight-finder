using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Weight_Finder
{
    class Container
    {
        //private list
        private List<Container> containerlist = new List<Container>();

        //class properties
        public string ContainerName { get; set; }
        public double TareWeight { get; set; }


        //class constructor
        public Container(string c_name, double t_weight)
        {
            ContainerName = c_name;
            TareWeight = t_weight;
        }

        //no argument constructor that populates container list
        public Container()
        {
            generateContainerList();
        }



        //accessor for the containerlist
        public List<Container> getContainerList() => containerlist;


        //method to fill initial containerList
        private void generateContainerList()
        {



            containerlist.Add(new Container("None", 0));
            //drums
            containerlist.Add(new Container("30 Open Head Drum + Liner & faucet", 15.9));
            containerlist.Add(new Container("55 Gal Plasic Drum", 10.0));
            containerlist.Add(new Container("55 Open Head Drum", 21.8));
            containerlist.Add(new Container("55 Closed Head Drum", 16.8));
            containerlist.Add(new Container("55 Open Head Drum + Liner & faucet", 23.6));


            //pails
            containerlist.Add(new Container("1 Gal Plastic Pail + Lid", 0.32));
            containerlist.Add(new Container("2 Gal Plastic Pail + Lid", 0.59));
            containerlist.Add(new Container("5 Gal Grey Plastic Pail + Lid", 1.40));
            containerlist.Add(new Container("5 Gal Black Straight Side Plastic Pail + Lid", 1.30));
            containerlist.Add(new Container("6 Gal White Plastic Pail + Lid", 1.68));

            //cans
            containerlist.Add(new Container("5 Gal Steel Pail + Lid", 1.66));
            containerlist.Add(new Container("5 Gal Closed Steel Can + Rieke Cap", 1.95));

            //jugs
            containerlist.Add(new Container("1 Gal Plastic Jug", 0.12));
            containerlist.Add(new Container("White Retain + Lid", 0.05));
            containerlist.Add(new Container("R0424 Plastic Container with Red Cap", 0.06));
            containerlist.Add(new Container("Black R0022 Drum with BUng Adapter and Fauset", 25.60));
            containerlist.Add(new Container("R0144 Jug", 1.25));

            //Other
            containerlist.Add(new Container("Light Blue 5 Gal Fixed Handle Plastic Jug", 2.0));
            containerlist.Add(new Container("Tall Dark Blue 5 Gallon White Handle Plastic Jug", 1.0));
            containerlist.Add(new Container("Tall Rectangle Tin Can (Corner Spout)", 1.11));
            containerlist.Add(new Container("Aldrich Brown Glass Jar (mini) with Red Cap", 0.06));
            containerlist.Add(new Container("Aldrich Brown Glass Jar (Small) with Red Cap", 0.47));
            containerlist.Add(new Container("Aldrich Brown Glass Jar (Medium) with Red Cap", 0.71));






            //P&F containers
            containerlist.Add(new Container("P3035 5 Gal Plastic ", 2.04));
            containerlist.Add(new Container("P3036 1 QT Can + Cap & Seal (F-Style)", 0.14));
            containerlist.Add(new Container("P3037 1 Gal Can + Cap & Seal (F-Style)", 0.36));
            containerlist.Add(new Container("P3215 1 Pint Can", 0.09));
            containerlist.Add(new Container("P3268 8 OZ Round Can + Cap & Seals", 0.05));
            containerlist.Add(new Container("P3342 1 Pint Round Can (Grey Lined) + Lid", 0.07));
            containerlist.Add(new Container("P3344 1 QT Round Can (Grey Lined)", 0.14));
            containerlist.Add(new Container("P3345 1 Gal Round Can (Grey Lined)", 0.32));


        }
    }
}
