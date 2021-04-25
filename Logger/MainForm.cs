using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string userInput = userInputTextBox.Text;
            inputLogListView.Items.Add(userInput);

            int lastPosition = inputLogListView.Items.Count - 1;
            ListViewItem lastItem = inputLogListView.Items[lastPosition];
            
            string color = inputColorComboBox.Text; 
            switch (color)
            {
                case "Rojo":
                    lastItem.ForeColor = Color.Red;
                    break;
                case "Verde":
                    lastItem.ForeColor = Color.Green;
                    break;
                case "Azul":
                    lastItem.ForeColor = Color.Blue;
                    break;
                default:
                    lastItem.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
