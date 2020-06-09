using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Jump
{
    public partial class Game_level_one : Form
    {
        public bool go = false, win = false;
        public Game_level_one()
        {
            InitializeComponent();
            Finish.ImageLocation = @"https://static8.depositphotos.com/1472772/978/i/950/depositphotos_9787455-stock-photo-finish-flags.jpg";
            Finish.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void UP()
        {
            Game_Person.Top -= 10;            
        }
        public void DOWN()
        {
            Game_Person.Top += 10;
        }
        public void LEFT()
        {
            Game_Person.Left -= 10;
        }
        public void RIGHT()
        {
            Game_Person.Left += 10;
        }
        private void Game_level_one_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        private void Start_button_Click(object sender, EventArgs e)
        {
            go = true;
        }      
        private void Game_level_one_KeyDown(object sender, KeyEventArgs e)
        {
            if (go == true)
            {
                if (Local())
                {
                    if (e.KeyValue == (char)Keys.D)                   
                        RIGHT();                   
                    if (e.KeyValue == (char)Keys.A)                   
                        LEFT();                   
                    if (e.KeyValue == (char)Keys.W)                   
                        UP();                    
                    if (e.KeyValue == (char)Keys.S)                    
                        DOWN();                   
                }
                else
                    Game_Person.Location = new Point(15, 200);
            }
            if(win == true)
            {
                var Yes = MessageBox.Show("Пройти уровень еще раз?", "Победа!", MessageBoxButtons.YesNo);
                if (Yes == DialogResult.Yes)
                {
                    win = false;
                    go = true;
                    Game_Person.Location = new Point(15, 200);
                }
                else
                    Application.Exit();
            }
            if (e.KeyValue == (char)Keys.Escape)
                Application.Exit();
        }
        public bool Local()
        {
            if(Game_Person.Top < 220 && Game_Person.Left > 110 && Game_Person.Left < 170)           
                return false;
            if (Game_Person.Top > 60 && Game_Person.Left > 240 && Game_Person.Left < 300)
                return false;
            if (Game_Person.Top < 210 && Game_Person.Left > 380 && Game_Person.Left < 600)
                return false;
            if (Game_Person.Top > 190 && Game_Person.Top < 260 && Game_Person.Left > 620 && Game_Person.Left < 680)
                return false;
            if (Game_Person.Top > 250 && Game_Person.Top < 380 && Game_Person.Left > 520 && Game_Person.Left < 660)
                return false;
            if (Game_Person.Top > 320 && Game_Person.Left > 350 && Game_Person.Left < 440)
                return false;
            if(Game_Person.Top > 80 && Game_Person.Top < 160 && Game_Person.Left > 640 && Game_Person.Left < 720)
            {
                win = true;
                go = false;
            }
            return true;
        }
        private void Game_field_Click(object sender, EventArgs e)
        { }
        private void End_Click(object sender, EventArgs e)
        {
            go = false;
            Game_Person.Location = new Point(15, 200);
        }
    }
}