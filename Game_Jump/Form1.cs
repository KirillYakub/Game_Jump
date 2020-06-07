using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Game_Jump
{
    public partial class Game_level_one : Form
    {
        KeyEventArgs eventArgs = new KeyEventArgs(true);
        public static bool win = false;
        public Game_level_one()
        {
            InitializeComponent();   
        }
        public class KeyEventArgs : EventArgs
        {            
            public Keys KeyCode { get; set; }
            public KeyEventArgs(bool Start)
            {
                Thread up = new Thread(UP);
                up.Start();
                up.Join(100);
                Thread left = new Thread(LEFT);
                left.Start();
                left.Join(100);
                Thread right = new Thread(RIGHT);
                right.Start();
                right.Join(100);
            }  
            public KeyEventArgs()
            { }
            public void UP()
            {
                while (win == false)
                {
                    if (this.KeyCode == Keys.W)
                    {
                        MessageBox.Show("sdf");
                    }
                    Thread.Sleep(100);
                }
            }
            public void LEFT()
            {
                while (win == false)
                {
                    if (this.KeyCode == Keys.A)
                    {
                        MessageBox.Show("sdf");
                    }
                    Thread.Sleep(100);
                }
            }
            public void RIGHT()
            {
                while (win == false)
                {
                    if (this.KeyCode == Keys.D)
                    {
                        MessageBox.Show("sdf");
                    }
                    Thread.Sleep(100);
                }
            }
        }
        private void Game_level_one_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void Start_button_Click(object sender, EventArgs e)
        {
            Game_time.Start();           
        }
        private void Game_time_Tick(object sender, EventArgs e)
        {
            eventArgs.UP();
            eventArgs.LEFT();
            eventArgs.RIGHT();
        }
    }
}