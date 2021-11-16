
namespace ForestPlantations
{
    partial class NewBush
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
            this.newBushText = new System.Windows.Forms.Label();
            this.bushName = new System.Windows.Forms.TextBox();
            this.bushAge = new System.Windows.Forms.TextBox();
            this.bushHeight = new System.Windows.Forms.TextBox();
            this.bushNameText = new System.Windows.Forms.Label();
            this.bushAgeText = new System.Windows.Forms.Label();
            this.bushHeightText = new System.Windows.Forms.Label();
            this.addBush = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newBushText
            // 
            this.newBushText.AutoSize = true;
            this.newBushText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newBushText.Location = new System.Drawing.Point(196, 58);
            this.newBushText.Name = "newBushText";
            this.newBushText.Size = new System.Drawing.Size(218, 29);
            this.newBushText.TabIndex = 0;
            this.newBushText.Text = "Введите данные:";
            // 
            // bushName
            // 
            this.bushName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushName.Location = new System.Drawing.Point(222, 99);
            this.bushName.Name = "bushName";
            this.bushName.Size = new System.Drawing.Size(164, 32);
            this.bushName.TabIndex = 1;
            // 
            // bushAge
            // 
            this.bushAge.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushAge.Location = new System.Drawing.Point(222, 147);
            this.bushAge.Name = "bushAge";
            this.bushAge.Size = new System.Drawing.Size(164, 32);
            this.bushAge.TabIndex = 2;
            // 
            // bushHeight
            // 
            this.bushHeight.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushHeight.Location = new System.Drawing.Point(222, 196);
            this.bushHeight.Name = "bushHeight";
            this.bushHeight.Size = new System.Drawing.Size(164, 32);
            this.bushHeight.TabIndex = 3;
            // 
            // bushNameText
            // 
            this.bushNameText.AutoSize = true;
            this.bushNameText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushNameText.Location = new System.Drawing.Point(83, 99);
            this.bushNameText.Name = "bushNameText";
            this.bushNameText.Size = new System.Drawing.Size(133, 29);
            this.bushNameText.TabIndex = 4;
            this.bushNameText.Text = "Название:";
            // 
            // bushAgeText
            // 
            this.bushAgeText.AutoSize = true;
            this.bushAgeText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushAgeText.Location = new System.Drawing.Point(100, 146);
            this.bushAgeText.Name = "bushAgeText";
            this.bushAgeText.Size = new System.Drawing.Size(116, 29);
            this.bushAgeText.TabIndex = 5;
            this.bushAgeText.Text = "Возраст:";
            // 
            // bushHeightText
            // 
            this.bushHeightText.AutoSize = true;
            this.bushHeightText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushHeightText.Location = new System.Drawing.Point(107, 195);
            this.bushHeightText.Name = "bushHeightText";
            this.bushHeightText.Size = new System.Drawing.Size(109, 29);
            this.bushHeightText.TabIndex = 6;
            this.bushHeightText.Text = "Высота:";
            // 
            // addBush
            // 
            this.addBush.BackColor = System.Drawing.Color.White;
            this.addBush.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBush.Location = new System.Drawing.Point(222, 246);
            this.addBush.Name = "addBush";
            this.addBush.Size = new System.Drawing.Size(164, 49);
            this.addBush.TabIndex = 13;
            this.addBush.Text = "Добавить элемент";
            this.addBush.UseVisualStyleBackColor = false;
            this.addBush.Click += new System.EventHandler(this.addBush_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.White;
            this.goBackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(222, 301);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(164, 49);
            this.goBackButton.TabIndex = 14;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // NewBush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.addBush);
            this.Controls.Add(this.bushHeightText);
            this.Controls.Add(this.bushAgeText);
            this.Controls.Add(this.bushNameText);
            this.Controls.Add(this.bushHeight);
            this.Controls.Add(this.bushAge);
            this.Controls.Add(this.bushName);
            this.Controls.Add(this.newBushText);
            this.Name = "NewBush";
            this.Text = "NewBush";
            this.Load += new System.EventHandler(this.NewBush_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newBushText;
        private System.Windows.Forms.TextBox bushName;
        private System.Windows.Forms.TextBox bushAge;
        private System.Windows.Forms.TextBox bushHeight;
        private System.Windows.Forms.Label bushNameText;
        private System.Windows.Forms.Label bushAgeText;
        private System.Windows.Forms.Label bushHeightText;
        private System.Windows.Forms.Button addBush;
        private System.Windows.Forms.Button goBackButton;
    }
}