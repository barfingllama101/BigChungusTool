namespace BigChungusTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.carrotTextBox = new System.Windows.Forms.TextBox();
            this.platformButton = new System.Windows.Forms.Button();
            this.carrotButton = new System.Windows.Forms.Button();
            this.platformTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spawnTextBox = new System.Windows.Forms.TextBox();
            this.spawnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To add carrots:  Enter the x-position and y-position of a carrot, seperated by co" +
    "mmas without spaces, then press the Add Carrot button (All numbers must be great" +
    "er than 0 and less than 1024)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // carrotTextBox
            // 
            this.carrotTextBox.Location = new System.Drawing.Point(389, 235);
            this.carrotTextBox.Name = "carrotTextBox";
            this.carrotTextBox.Size = new System.Drawing.Size(258, 20);
            this.carrotTextBox.TabIndex = 3;
            this.carrotTextBox.TextChanged += new System.EventHandler(this.carrotTextBox_TextChanged);
            // 
            // platformButton
            // 
            this.platformButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.platformButton.Location = new System.Drawing.Point(718, 141);
            this.platformButton.Name = "platformButton";
            this.platformButton.Size = new System.Drawing.Size(75, 23);
            this.platformButton.TabIndex = 4;
            this.platformButton.Text = "Add Platform";
            this.platformButton.UseVisualStyleBackColor = false;
            this.platformButton.Click += new System.EventHandler(this.platformButton_Click);
            // 
            // carrotButton
            // 
            this.carrotButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.carrotButton.Location = new System.Drawing.Point(718, 235);
            this.carrotButton.Name = "carrotButton";
            this.carrotButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.carrotButton.Size = new System.Drawing.Size(75, 23);
            this.carrotButton.TabIndex = 5;
            this.carrotButton.Text = "Add Carrot";
            this.carrotButton.UseVisualStyleBackColor = false;
            this.carrotButton.Click += new System.EventHandler(this.carrotButton_Click);
            // 
            // platformTextBox
            // 
            this.platformTextBox.Location = new System.Drawing.Point(389, 143);
            this.platformTextBox.Name = "platformTextBox";
            this.platformTextBox.Size = new System.Drawing.Size(258, 20);
            this.platformTextBox.TabIndex = 6;
            this.platformTextBox.TextChanged += new System.EventHandler(this.platformTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(594, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a level name here, then press the Name Level button (To play the level, cha" +
    "nge the LevelPath variable in BigChungus)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(389, 50);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameButton
            // 
            this.nameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameButton.Location = new System.Drawing.Point(718, 47);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 9;
            this.nameButton.Text = "Name Level";
            this.nameButton.UseMnemonic = false;
            this.nameButton.UseVisualStyleBackColor = false;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Once you have entered all of your data, press the Create Level Button to create t" +
    "he level file (Saves to Debug Folder)";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createButton.Location = new System.Drawing.Point(493, 443);
            this.createButton.Name = "createButton";
            this.createButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Create Level";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(433, 403);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(233, 13);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "Errors will appear here if something doesn\'t work";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(851, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Enter the x and y coordinates for where you want the player to start, seperated b" +
    "y commas without spaces, then press the Set Spawn button (Both numbers must be f" +
    "rom 0 to 1024)";
            // 
            // spawnTextBox
            // 
            this.spawnTextBox.Location = new System.Drawing.Point(389, 322);
            this.spawnTextBox.Name = "spawnTextBox";
            this.spawnTextBox.Size = new System.Drawing.Size(258, 20);
            this.spawnTextBox.TabIndex = 14;
            // 
            // spawnButton
            // 
            this.spawnButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.spawnButton.Location = new System.Drawing.Point(718, 319);
            this.spawnButton.Name = "spawnButton";
            this.spawnButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.spawnButton.Size = new System.Drawing.Size(75, 23);
            this.spawnButton.TabIndex = 15;
            this.spawnButton.Text = "Set Spawn";
            this.spawnButton.UseVisualStyleBackColor = false;
            this.spawnButton.Click += new System.EventHandler(this.spawnButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 622);
            this.Controls.Add(this.spawnButton);
            this.Controls.Add(this.spawnTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.platformTextBox);
            this.Controls.Add(this.carrotButton);
            this.Controls.Add(this.platformButton);
            this.Controls.Add(this.carrotTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox carrotTextBox;
        private System.Windows.Forms.Button platformButton;
        private System.Windows.Forms.Button carrotButton;
        private System.Windows.Forms.TextBox platformTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox spawnTextBox;
        private System.Windows.Forms.Button spawnButton;
    }
}

