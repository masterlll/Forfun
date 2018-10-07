using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_FunCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reference type
            var tet = new test02();
            //tet.name = 0 | 2 | 5 | 4|1000|156566;

            tet.name = 0;

            tet.score = new int[4];

            tet.score[0] = 0;
            tet.score[1] = 12;


            var test02 = new test02();
            test02 = tet;
            test02.name = 10000000;

            // 

            // int aand duble  ValueTuple 
            //int number = 1;
            //int num2;


            //num2 = number;
            //num2 = 100;

            MessageBox.Show("number" + tet.name);
        }
    }
    public class test02
    {
        internal int name;
        public int Hp { get=> 1 *10  ; set => name = value; }
        public int[] score;
    }







}
