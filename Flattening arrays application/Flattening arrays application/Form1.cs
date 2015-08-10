using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flattening_arrays_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialisation of nested array
            //the array is made of 4 inner arrays and all array are of type integers
            int[][] nestedarray = new int[4][]
            {
                //inner arrays
                new int [] {2,4,8,9},
                new int [] {10,15,20,30,5,8,7,9},
                new int [] {14,13,7,1,6,11},
                new int [] {0,12,3,17}

            };

            //Display of elements of the nested array
            //beginning of loop to display each element
            for (int i = 0; i < nestedarray.Length; i++)
            {
                int[] innerArray = nestedarray[i];

                for (int j = 0 ; j < innerArray.Length ; j++)
                {
                    label2.Text +=  nestedarray [i][j].ToString() + " ";
                }

            }

            //Flattening array
            //
            //beginning of fltattening 
            //each element from the nested is extracted from the nestedarray 
            //each element is added to a new list
            //the list is then converted to a one dimensional array
            //each element of the one dimensional array is then printed
            //the array is then displayed in the label4.

            for (int i = 0; i < nestedarray.Length; i++)
            {
                int[] innerArray = nestedarray[i];

                for (int j = 0; j < innerArray.Length; j++)
                {
                    var valuelist = new List<int>();
                    valuelist.Add(nestedarray[i][j]);
                    int[] flattenarray = valuelist.ToArray();

                    for (int k = 0; k < flattenarray.Length; i++) 
                    {
                        label4.Text += flattenarray[k].ToString() + " ";

                    }



                    
                }

            }

        }
    }
}
