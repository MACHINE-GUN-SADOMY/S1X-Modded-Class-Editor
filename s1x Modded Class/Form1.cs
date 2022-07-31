using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Memory;

namespace s1x_Modded_Class
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("s1x.exe");
        }

        // CLASS NAME EDITOR // 

        private void metroButton2_Click(object sender, EventArgs e) // SYMBOLS HELP
        {
            MessageBox.Show("Colors: ^1(Red) ^ 2(Green) ^ 3(Yellow) ^ 4(Blue) ^ 5(Light Purple) ^ 6(Purple) ^ 7(White) ^ 8(Light Green) ^ 9(Grey) ^ 0(Black)");
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e) // SELECT CLASS
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e) // CUSTOM NAME
        {

        }

        private void metroButton1_Click(object sender, EventArgs e) // SET CUSTOM NAME
        {
            if (metroComboBox1.Text == "Class #1")
            {
                m.WriteMemory("0x147B29BD1", "string" , "" + metroTextBox1.Text + "\0" );
            }
            else if (metroComboBox1.Text == "Class #2")
            {
                m.WriteMemory("147B29C51", "string", "" + metroTextBox1.Text + "\0");
            }
            else if (metroComboBox1.Text == "Class #3")
            {
                m.WriteMemory("s1_mp64_ship.exe+7B29CD1", "string", "" + metroTextBox1.Text + "\0");
            }
            else if (metroComboBox1.Text == "Class #4")
            {
                m.WriteMemory("s1_mp64_ship.exe+7B29D51", "string", "" + metroTextBox1.Text + "\0");
            }
            else if (metroComboBox1.Text == "Class #5")
            {
                m.WriteMemory("s1_mp64_ship.exe+7B29DD1", "string", "" + metroTextBox1.Text + "\0");
            }
            else if (metroComboBox1.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("0x147B29BD1", "string", "" + metroTextBox1.Text + "\0"); // 1
                m.WriteMemory("147B29C51", "string", "" + metroTextBox1.Text + "\0"); // 2
                m.WriteMemory("s1_mp64_ship.exe+7B29CD1", "string", "" + metroTextBox1.Text + "\0"); // 3
                m.WriteMemory("s1_mp64_ship.exe+7B29D51", "string", "" + metroTextBox1.Text + "\0"); // 4
                m.WriteMemory("s1_mp64_ship.exe+7B29DD1", "string", "" + metroTextBox1.Text + "\0"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        // MODDED CLASSES // 

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e) // TACTICAL INSERTION
        {
            if (metroComboBox2.Text == "Class #1") 
            {
                m.WriteMemory("147B29BCC", "bytes" , "76");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C4C", "bytes", "76");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CCC", "bytes", "76");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D4C", "bytes", "76");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DCC", "bytes", "76");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BCC", "bytes", "76"); // 1
                m.WriteMemory("147B29C4C", "bytes", "76"); // 2
                m.WriteMemory("147B29CCC", "bytes", "76"); // 3
                m.WriteMemory("147B29D4C", "bytes", "76"); // 4
                m.WriteMemory("147B29DCC", "bytes", "76"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e) // STUN MODDED 
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "EE"); // 1
                m.WriteMemory("147B29C49", "bytes", "EE"); // 2
                m.WriteMemory("147B29CC9", "bytes", "EE"); // 3
                m.WriteMemory("147B29D49", "bytes", "EE"); // 4
                m.WriteMemory("147B29DC9", "bytes", "EE"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton6_Click(object sender, EventArgs e) // SMOKE MODDED
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "F4");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "F4");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "F4");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "F4");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "F4");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "F4"); // 1
                m.WriteMemory("147B29C49", "bytes", "F4"); // 2
                m.WriteMemory("147B29CC9", "bytes", "F4"); // 3
                m.WriteMemory("147B29D49", "bytes", "F4"); // 4
                m.WriteMemory("147B29DC9", "bytes", "F4"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton7_Click(object sender, EventArgs e) // CONFUSSION GRENADE
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "EA");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "EA");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "EA");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "EA");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "EA");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "EA"); // 1
                m.WriteMemory("147B29C49", "bytes", "EA"); // 2
                m.WriteMemory("147B29CC9", "bytes", "EA"); // 3
                m.WriteMemory("147B29D49", "bytes", "EA"); // 4
                m.WriteMemory("147B29DC9", "bytes", "EA"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e) // CONFUSSION GRENADE NO WEAPON
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "EB");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "EB");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "EB");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "EB");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "EB");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "EB"); // 1
                m.WriteMemory("147B29C49", "bytes", "EB"); // 2
                m.WriteMemory("147B29CC9", "bytes", "EB"); // 3
                m.WriteMemory("147B29D49", "bytes", "EB"); // 4
                m.WriteMemory("147B29DC9", "bytes", "EB"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton8_Click(object sender, EventArgs e) // VARIABLE GRENADE (EXO MOD)
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "EE");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "EE"); // 1
                m.WriteMemory("147B29C49", "bytes", "EE"); // 2
                m.WriteMemory("147B29CC9", "bytes", "EE"); // 3
                m.WriteMemory("147B29D49", "bytes", "EE"); // 4
                m.WriteMemory("147B29DC9", "bytes", "EE"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }

        private void metroButton9_Click(object sender, EventArgs e) // AUTO RECHARGE
        {
            if (metroComboBox2.Text == "Class #1")
            {
                m.WriteMemory("147B29BC9", "bytes", "EF");
            }
            else if (metroComboBox2.Text == "Class #2")
            {
                m.WriteMemory("147B29C49", "bytes", "EF");
            }
            else if (metroComboBox2.Text == "Class #3")
            {
                m.WriteMemory("147B29CC9", "bytes", "EF");
            }
            else if (metroComboBox2.Text == "Class #4")
            {
                m.WriteMemory("147B29D49", "bytes", "EF");
            }
            else if (metroComboBox2.Text == "Class #5")
            {
                m.WriteMemory("147B29DC9", "bytes", "EF");
            }
            else if (metroComboBox2.Text == "All Class (1 to 5)")
            {
                m.WriteMemory("147B29BC9", "bytes", "EF"); // 1
                m.WriteMemory("147B29C49", "bytes", "EF"); // 2
                m.WriteMemory("147B29CC9", "bytes", "EF"); // 3
                m.WriteMemory("147B29D49", "bytes", "EF"); // 4
                m.WriteMemory("147B29DC9", "bytes", "EF"); // 5
            }
            else
            {
                MessageBox.Show("Invalid Option!");
            }
        }
    }
}
