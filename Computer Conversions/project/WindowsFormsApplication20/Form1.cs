using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        //value number in (textbox1)
        String number;
        /*
        value to the base string in combox so ..
        example:
        >> if (ComboBox1.text == Hexa ) so frombase =16  ...etc
        */    
        int fromBase, toBase;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //take value in textbox1 to convert it 
            number = textBox1.Text;
            //to know the value to the base string which in comobox
            _Check_Base_String();
            //convert the string in textbox1 (number ) to 
            String result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            textBox2.Text = result;

        }
        private void  _Check_Base_String()
        {
            //take base string in each comobox.text
            string from_string = comboBox1.Text;
            string to_string = comboBox2.Text;
            //select the value to the base string
            fromBase = _Check_Base_Value(from_string);
            toBase = _Check_Base_Value(to_string);

        }
        private int _Check_Base_Value(string Base)
        {
             int value=0;
            switch (Base){
                case "Hexa":
                    value = 16;
                    break;
                case "Octal":
                    value = 16;
                    break;
                case "Decimal":
                    value = 10;
                    break;
                case "Binary":
                    value = 2;
                    break;
                default:
                    MessageBox.Show("please select base");
                    break;
            }
            return value;
        }
    }
}
