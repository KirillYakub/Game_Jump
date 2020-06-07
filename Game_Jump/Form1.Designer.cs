namespace Game_Jump
{
    partial class Game_level_one
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Game_field = new System.Windows.Forms.PictureBox();
            this.Game_Person = new System.Windows.Forms.PictureBox();
            this.Start_button = new System.Windows.Forms.Button();
            this.Game_time = new System.Windows.Forms.Timer(this.components);
            this.Game_Bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Game_field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Person)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_field
            // 
            this.Game_field.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Game_field.Location = new System.Drawing.Point(12, 12);
            this.Game_field.Name = "Game_field";
            this.Game_field.Size = new System.Drawing.Size(891, 356);
            this.Game_field.TabIndex = 0;
            this.Game_field.TabStop = false;
            // 
            // Game_Person
            // 
            this.Game_Person.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Game_Person.Location = new System.Drawing.Point(32, 326);
            this.Game_Person.Name = "Game_Person";
            this.Game_Person.Size = new System.Drawing.Size(44, 42);
            this.Game_Person.TabIndex = 1;
            this.Game_Person.TabStop = false;
            // 
            // Start_button
            // 
            this.Start_button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Start_button.Location = new System.Drawing.Point(12, 460);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(115, 65);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "Старт";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            // 
            // Game_time
            // 
            this.Game_time.Tick += new System.EventHandler(this.Game_time_Tick);
            // 
            // Game_Bar
            // 
            this.Game_Bar.Location = new System.Drawing.Point(615, 439);
            this.Game_Bar.Name = "Game_Bar";
            this.Game_Bar.Size = new System.Drawing.Size(214, 44);
            this.Game_Bar.TabIndex = 3;
            // 
            // Game_level_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.Game_Bar);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Game_Person);
            this.Controls.Add(this.Game_field);
            this.Name = "Game_level_one";
            this.Text = "Game_level_one";
            this.Load += new System.EventHandler(this.Game_level_one_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Game_field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game_Person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Game_field;
        private System.Windows.Forms.PictureBox Game_Person;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Timer Game_time;
        private System.Windows.Forms.ProgressBar Game_Bar;
    }
}

