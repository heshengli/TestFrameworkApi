using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace _ComBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.AddRange(comList);
        }


        private object[] comList = new object[]
        {
            "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10",
            "A11", "A12", "A13", "A14", "A15", "A16", "A17", "A18", "A19", "A20", "A21", "A22", "A23", "A24", "A25",
            "A26", "A27", "A28", "A29", "A30", "A31", "A32", "A33", "A34", "A35", "A36", "A37", "A38", "A39", "A40",
            "A41", "A42", "A43", "A44", "A45", "A46", "A47", "A48", "A49", "A50",
            "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10",
            "B11", "B12", "B13", "B14", "B15", "B16", "B17", "B18", "B19", "B20", "B21", "B22", "B23", "B24", "B25",
            "B26", "B27", "B28", "B29", "B30", "B31", "B32", "B33", "B34", "B35", "B36", "B37", "B38", "B39", "B40",
            "B41", "B42", "B43", "B44", "B45", "B46", "B47", "B48", "B49", "B50",
            "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10",
            "C11", "C12", "C13", "C14", "C15", "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25",
            "C26", "C27", "C28", "C29", "C30", "C31", "C32", "C33", "C34", "C35", "C36", "C37", "C38", "C39", "C40",
            "C41", "C42", "C43", "C44", "C45", "C46", "C47", "C48", "C49", "C50",
            "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D10",
            "D11", "D12", "D13", "D14", "D15", "D16", "D17", "D18", "D19", "D20", "D21", "D22", "D23", "D24", "D25",
            "D26", "D27", "D28", "D29", "D30", "D31", "D32", "D33", "D34", "D35", "D36", "D37", "D38", "D39", "D40",
            "D41", "D42", "D43", "D44", "D45", "D46", "D47", "D48", "D49", "D50"
        };

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(comList);
                return;
            }
            string txt = comboBox2.Text;
            List<object> strList = new List<object>();
            foreach (var item in comList)
            {
                if (item.ToString().Contains(txt))
                {
                    strList.Add(item);
                }
            }
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(strList.ToArray());
            comboBox2.SelectionStart = comboBox2.Text.Length;
            comboBox2.DroppedDown = true;
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DropDownHeight = 200;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(comboBox2.Text))
            //{
            //    comboBox2.Items.Clear();
            //    comboBox2.Items.AddRange(comList);
            //    return;
            //}
            //string txt = comboBox2.Text;
            //List<object> strList = new List<object>();
            //foreach (var item in comList)
            //{
            //    if (item.ToString().Contains(txt))
            //    {
            //        strList.Add(item);
            //    }
            //}
            //comboBox2.Items.Clear();
            //comboBox2.Items.AddRange(strList.ToArray());
            //comboBox2.SelectionStart = comboBox2.Text.Length;
            //comboBox2.DroppedDown = true;
        }
    }
}
