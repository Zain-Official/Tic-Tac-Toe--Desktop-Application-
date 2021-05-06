using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__Desktop_Application_
{
    public partial class Form1 : Form
    {
        int plusone;
        Boolean Checker;

        public void Enable_False()
        {
            Btn_1.Enabled = false;
            Btn_2.Enabled = false;
            Btn_3.Enabled = false;
            Btn_4.Enabled = false;
            Btn_5.Enabled = false;
            Btn_6.Enabled = false;
            Btn_7.Enabled = false;
            Btn_8.Enabled = false;
            Btn_9.Enabled = false;
        }

        public void Score()
        {

            if(Btn_1.Text=="X" && Btn_2.Text=="X" && Btn_3.Text=="X")
            {
                Btn_1.BackColor = Color.PowderBlue;
                Btn_2.BackColor = Color.PowderBlue;
                Btn_3.BackColor = Color.PowderBlue;

             
                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_1.Text == "X" && Btn_4.Text == "X" && Btn_7.Text == "X")
            {
                Btn_1.BackColor = Color.PaleGreen;
                Btn_4.BackColor = Color.PaleGreen;
                Btn_7.BackColor = Color.PaleGreen;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_1.Text == "X" && Btn_5.Text == "X" && Btn_9.Text == "X")
            {
                Btn_1.BackColor = Color.AliceBlue;
                Btn_5.BackColor = Color.AliceBlue;
                Btn_9.BackColor = Color.AliceBlue;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_3.Text == "X" && Btn_5.Text == "X" && Btn_7.Text == "X")
            {
                Btn_3.BackColor = Color.AliceBlue;
                Btn_5.BackColor = Color.AliceBlue;
                Btn_7.BackColor = Color.AliceBlue;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_2.Text == "X" && Btn_5.Text == "X" && Btn_8.Text == "X")
            {
                Btn_2.BackColor = Color.Aqua;
                Btn_5.BackColor = Color.Aqua;
                Btn_8.BackColor = Color.Aqua;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (Btn_3.Text == "X" && Btn_6.Text == "X" && Btn_9.Text == "X")
            {
                Btn_3.BackColor = Color.Magenta;
                Btn_6.BackColor = Color.Magenta;
                Btn_9.BackColor = Color.Magenta;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_7.Text == "X" && Btn_8.Text == "X" && Btn_9.Text == "X")
            {
                Btn_7.BackColor = Color.Goldenrod;
                Btn_8.BackColor = Color.Goldenrod;
                Btn_9.BackColor = Color.Goldenrod;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_4.Text == "X" && Btn_5.Text == "X" && Btn_6.Text == "X")
            {
                Btn_4.BackColor = Color.ForestGreen;
                Btn_5.BackColor = Color.ForestGreen;
                Btn_6.BackColor = Color.ForestGreen;


                MessageBox.Show("The Winner Is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label2.Text);
                label2.Text = Convert.ToString(plusone+1);
                Enable_False();
            }


            //Condition for O Player
            if (Btn_7.Text == "O" && Btn_8.Text == "O" && Btn_9.Text == "O")
            {
                Btn_7.BackColor = Color.DarkOliveGreen;
                Btn_8.BackColor = Color.DarkOliveGreen;
                Btn_9.BackColor = Color.DarkOliveGreen;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_1.Text == "O" && Btn_2.Text == "O" && Btn_3.Text == "O")
            {
                Btn_1.BackColor = Color.Yellow;
                Btn_2.BackColor = Color.Yellow;
                Btn_3.BackColor = Color.Yellow;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_1.Text == "O" && Btn_4.Text == "O" && Btn_7.Text == "O")
            {
                Btn_1.BackColor = Color.YellowGreen;
                Btn_4.BackColor = Color.YellowGreen;
                Btn_7.BackColor = Color.YellowGreen;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_1.Text == "O" && Btn_5.Text == "O" && Btn_9.Text == "O")
            {
                Btn_1.BackColor = Color.LightYellow;
                Btn_5.BackColor = Color.LightYellow;
                Btn_9.BackColor = Color.LightYellow;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_3.Text == "O" && Btn_5.Text == "O" && Btn_7.Text == "O")
            {
                Btn_3.BackColor = Color.LightGoldenrodYellow;
                Btn_5.BackColor = Color.LightGoldenrodYellow;
                Btn_7.BackColor = Color.LightGoldenrodYellow;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_2.Text == "O" && Btn_5.Text == "O" && Btn_8.Text == "O")
            {
                Btn_2.BackColor = Color.Khaki;
                Btn_5.BackColor = Color.Khaki;
                Btn_8.BackColor = Color.Khaki;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }


            if (Btn_3.Text == "O" && Btn_6.Text == "O" && Btn_9.Text == "O")
            {
                Btn_3.BackColor = Color.CornflowerBlue;
                Btn_6.BackColor = Color.CornflowerBlue;
                Btn_9.BackColor = Color.CornflowerBlue;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (Btn_4.Text == "O" && Btn_5.Text == "O" && Btn_6.Text == "O")
            {
                Btn_4.BackColor = Color.DarkSalmon;
                Btn_5.BackColor = Color.DarkSalmon;
                Btn_6.BackColor = Color.DarkSalmon;


                MessageBox.Show("The Winner Is Player O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label3.Text);
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }




        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try { 
            Btn_1.Enabled = true;
            Btn_2.Enabled = true;
            Btn_3.Enabled = true;
            Btn_4.Enabled = true;
            Btn_5.Enabled = true;
            Btn_6.Enabled = true;
            Btn_7.Enabled = true;
            Btn_8.Enabled = true;
            Btn_9.Enabled = true;

            Btn_1.Text = "";
            Btn_2.Text = "";
            Btn_3.Text = "";
            Btn_4.Text = "";
            Btn_5.Text = "";
            Btn_6.Text = "";
            Btn_7.Text = "";
            Btn_8.Text = "";
            Btn_9.Text = "";

            label2.Text = "0";
            label3.Text = "0";

            Btn_1.BackColor = Color.WhiteSmoke;
            Btn_2.BackColor = Color.WhiteSmoke;
            Btn_3.BackColor = Color.WhiteSmoke;
            Btn_4.BackColor = Color.WhiteSmoke;
            Btn_5.BackColor = Color.WhiteSmoke;
            Btn_6.BackColor = Color.WhiteSmoke;
            Btn_7.BackColor = Color.WhiteSmoke;
            Btn_8.BackColor = Color.WhiteSmoke;
            Btn_9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if(Checker== false)
            {
                Btn_1.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_1.Text = "O";
                Checker = false;
            }
            Score();
            Btn_1.Enabled = false;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_2.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_2.Text = "O";
                Checker = false;
            }
            Score();
            Btn_2.Enabled = false;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_3.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_3.Text = "O";
                Checker = false;
            }
            Score();
            Btn_3.Enabled = false;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_4.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_4.Text = "O";
                Checker = false;
            }
            Score();
            Btn_4.Enabled = false;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_5.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_5.Text = "O";
                Checker = false;
            }
            Score();
            Btn_5.Enabled = false;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_6.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_6.Text = "O";
                Checker = false;
            }
            Score();
            Btn_6.Enabled = false;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_7.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_7.Text = "O";
                Checker = false;
            }
            Score();
            Btn_7.Enabled = false;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_8.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_8.Text = "O";
                Checker = false;
            }
            Score();
            Btn_8.Enabled = false;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (Checker == false)
            {
                Btn_9.Text = "X";
                Checker = true;
            }
            else
            {
                Btn_9.Text = "O";
                Checker = false;
            }
            Score();
            Btn_9.Enabled = false;
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            try { 
            Btn_1.Enabled = true;
            Btn_2.Enabled = true;
            Btn_3.Enabled = true;
            Btn_4.Enabled = true;
            Btn_5.Enabled = true;
            Btn_6.Enabled = true;
            Btn_7.Enabled = true;
            Btn_8.Enabled = true;
            Btn_9.Enabled = true;

            Btn_1.Text = "";
            Btn_2.Text = "";
            Btn_3.Text = "";
            Btn_4.Text = "";
            Btn_5.Text = "";
            Btn_6.Text = "";
            Btn_7.Text = "";
            Btn_8.Text = "";
            Btn_9.Text = "";

            new_Game.Enabled = true;

            Btn_1.BackColor = Color.WhiteSmoke;
            Btn_2.BackColor = Color.WhiteSmoke;
            Btn_3.BackColor = Color.WhiteSmoke;
            Btn_4.BackColor = Color.WhiteSmoke;
            Btn_5.BackColor = Color.WhiteSmoke;
            Btn_6.BackColor = Color.WhiteSmoke;
            Btn_7.BackColor = Color.WhiteSmoke;
            Btn_8.BackColor = Color.WhiteSmoke;
            Btn_9.BackColor = Color.WhiteSmoke;
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

}

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExist;
                iExist = MessageBox.Show("Confirm Do U Want To Exist", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(iExist==DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
