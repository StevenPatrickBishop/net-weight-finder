using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Net_Weight_Finder
{
    public partial class frmCycleCounter : Form
    {
        Container container = new Container();
        


        public frmCycleCounter()
        {
            InitializeComponent();

            //makeFile();
            //addToFile();
            foreach (var item in container.getContainerList())
            {
                cbo_Container_List_Value.Items.Add(item.ContainerName);
                cbo_Container_List_2_Value.Items.Add(item.ContainerName);
            }

            
        }

        

        private void chk_Use_Custom_Tare_CheckedChanged(object sender, EventArgs e)
        {
            //if custom tare panel is not enabled
            //enable on check, also disable tare list
            if (!pnl_Custom_Tare.Enabled)
            {
                pnl_Custom_Tare.Enabled = true;
                pnl_Containers.Enabled = false;
            }

            //otherwise
            //disable on check, and enable tare list
            else
            {
                pnl_Custom_Tare.Enabled = false;
                pnl_Containers.Enabled = true;
            }
        }


        //parse string input into double, throws format exeption if input is non-numeric
        private double getWeight(string weightStringPassedIn)
        {

            double weight;

            if (!Double.TryParse(weightStringPassedIn, out weight))
            {
                throw new FormatException("You have to type a number");
            }

            return weight;
        }


        private void btn_Calculate_Net_Weight_Click(object sender, EventArgs e)
        {
            var grossWeight = 0.0;
            var tare1 = 0.0;
            var tare2 = 0.0;
            var tareWeight = 0.0;
            var netWeight = 0.0;
           



            //get gross weight
            AddExpression expression = new AddExpression();

            try
            {
                //grossWeight = getWeight(txt_Gross_Weight_Value.Text);
                grossWeight = expression.getListSum(txt_Gross_Weight_Value.Text);
            }
            catch (Exception exc)
            {
                txt_Gross_Weight_Value.Text = "";
                txt_Gross_Weight_Value.Focus();
                MessageBox.Show(exc.Message);
                return;
            }

            //-----------------------Calculate Net weight when using container list tare-----------------------

            if (pnl_Containers.Enabled)
            {

                //local copy of container list
                var containerList = container.getContainerList();

                //use linq query to get tare weight from container selected from the combo box
                var tare =
                    from containers in containerList
                    where containers.ContainerName == cbo_Container_List_Value.Text
                    select containers;

                foreach (var item in tare)
                {
                    tare1 = item.TareWeight;
                }

                   tare =
                   from containers in containerList
                   where containers.ContainerName == cbo_Container_List_2_Value.Text
                   select containers;

                foreach (var item in tare)
                {
                    tare2 = item.TareWeight;
                }

                tareWeight = tare1 + tare2;



                netWeight = grossWeight - tareWeight;

                txt_Net_Weight_Value.Text = $"{netWeight:0.00}";
            }

            //-------------------------Calculate Net weight when using Custom tare--------------------------------
            if (pnl_Custom_Tare.Enabled) {

                //get tare weight
                try
                {
                    tareWeight = getWeight(txt_Custom_Tare_Value.Text);
                }
                catch (FormatException Not_A_Number)
                {
                    MessageBox.Show(Not_A_Number.Message);
                    return;
                }

                //adjust tare weight if user indicates that the value is in pounds
                if (rad_Pounds.Checked) {
                    tareWeight = tareWeight / 2.204;
                }

                netWeight = grossWeight - tareWeight;

                txt_Net_Weight_Value.Text = $"{netWeight:0.00}";




            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Reset_Form_Click(object sender, EventArgs e)
        {
            txt_Custom_Tare_Value.Clear();
            txt_Gross_Weight_Value.Clear();
            txt_Net_Weight_Value.Clear();
            txt_Gross_Weight_Value.Focus();
            cbo_Container_List_Value.Text = "";
            
        }

        private void chk_Multi_Container_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void makeFile() {

        //    //set up initial file values;
        //    StreamWriter file = new StreamWriter("Tare_Weights.txt");
        //    foreach (var item in container.getContainerList())
        //    {
        //        file.Write($"{item.ContainerName},{item.TareWeight.ToString()}\r\n");
        //    }
        //    file.Close();
        //    MessageBox.Show("File Made");
        //}

        //private void addToFile() {

        //    var filePath = (@"C: \Users\sbish\Documents\visual studio 2017\Projects\Net_Weight_Finder\Net_Weight_Finder\bin\Debug\Test.txt");

        //    File.WriteAllText(filePath, "Another drum, 15.3");

        //}


    }

}
