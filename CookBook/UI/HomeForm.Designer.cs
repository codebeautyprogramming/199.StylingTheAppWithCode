﻿namespace CookBook.UI
{
    partial class HomeForm
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
            FridgeBtn = new Button();
            RecipesBtn = new Button();
            FoodManagerBtn = new Button();
            NotificationIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).BeginInit();
            SuspendLayout();
            // 
            // FridgeBtn
            // 
            FridgeBtn.Location = new Point(12, 25);
            FridgeBtn.Name = "FridgeBtn";
            FridgeBtn.Size = new Size(314, 60);
            FridgeBtn.TabIndex = 0;
            FridgeBtn.Text = "Fridge";
            FridgeBtn.UseVisualStyleBackColor = true;
            FridgeBtn.Click += FridgeBtn_Click;
            // 
            // RecipesBtn
            // 
            RecipesBtn.Location = new Point(12, 107);
            RecipesBtn.Name = "RecipesBtn";
            RecipesBtn.Size = new Size(314, 60);
            RecipesBtn.TabIndex = 1;
            RecipesBtn.Text = "Recipes";
            RecipesBtn.UseVisualStyleBackColor = true;
            RecipesBtn.Click += RecipesBtn_Click;
            // 
            // FoodManagerBtn
            // 
            FoodManagerBtn.Location = new Point(12, 188);
            FoodManagerBtn.Name = "FoodManagerBtn";
            FoodManagerBtn.Size = new Size(314, 60);
            FoodManagerBtn.TabIndex = 2;
            FoodManagerBtn.Text = "Food manager";
            FoodManagerBtn.UseVisualStyleBackColor = true;
            FoodManagerBtn.Click += FoodManagerBtn_Click;
            // 
            // NotificationIcon
            // 
            NotificationIcon.Image = Properties.Resources.notification;
            NotificationIcon.Location = new Point(126, 265);
            NotificationIcon.Name = "NotificationIcon";
            NotificationIcon.Size = new Size(60, 54);
            NotificationIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            NotificationIcon.TabIndex = 3;
            NotificationIcon.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(344, 331);
            Controls.Add(NotificationIcon);
            Controls.Add(FoodManagerBtn);
            Controls.Add(RecipesBtn);
            Controls.Add(FridgeBtn);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)NotificationIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button FridgeBtn;
        private Button RecipesBtn;
        private Button FoodManagerBtn;
        private PictureBox NotificationIcon;
    }
}