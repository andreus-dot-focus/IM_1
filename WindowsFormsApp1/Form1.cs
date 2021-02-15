using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<CheckBox, Cell> field = new Dictionary<CheckBox, Cell>();

        private int money;
        public int Money
        {
            get 
            {
                return money;
            }
            set 
            {
                if (value < 0)
                    money = 0;
                else
                    money = value;
            }
        }   

        public Form1()
        {
            InitializeComponent();

            foreach (CheckBox cb in tableLayoutPanel1.Controls)
                field.Add(cb, new Cell());
            Money = 100;
            timer1.Interval = 500;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void Cut(CheckBox cb)
        {
            switch (field[cb].state)
            {
                case CellState.Green:
                    Money += 1;
                    break;
                case CellState.Yellow:
                    Money += 3;
                    break;
                case CellState.Red:
                    Money += 5;
                    break;
                case CellState.Overgrow:
                    Money -= 3;
                    break;
            }
            field[cb].Cut();
            UpdateBox(cb);
        }

        private void StartGrow(CheckBox cb)
        {
            Money -= 2;
            field[cb].StartGrow();
            UpdateBox(cb);
        }

        int day = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (CheckBox cb in tableLayoutPanel1.Controls)
            {
                field[cb].Step();
                UpdateBox(cb);
            }
            day++;
            labDay.Text = "Day: " + day;
            moneyLabel.Text = "Баксы: " + money.ToString();
        }

        private void UpdateBox(CheckBox cb)
        {
            Color c = Color.White;
            switch (field[cb].state)
            {
                case CellState.Growing:
                    c = Color.Black;
                    break;
                case CellState.Green:
                    c = Color.Green;
                    break;
                case CellState.Yellow:
                    c = Color.Yellow;
                    break;
                case CellState.Red:
                    c = Color.Red;
                    break;
                case CellState.Overgrow:
                    c = Color.Brown;
                    break;
            }
            cb.BackColor = c;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (sender as CheckBox);
            if (cb.Checked) StartGrow(cb);
            else Cut(cb);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int tickTime = 500 + trackBar1.Value * 500;
            timer1.Interval = tickTime;
        }
    }
}
