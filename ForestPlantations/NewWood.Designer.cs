
namespace ForestPlantations
{
    partial class NewWood
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
            this.goBackButton = new System.Windows.Forms.Button();
            this.addWood = new System.Windows.Forms.Button();
            this.woodHeightText = new System.Windows.Forms.Label();
            this.woodAgeText = new System.Windows.Forms.Label();
            this.woodNameText = new System.Windows.Forms.Label();
            this.woodHeight = new System.Windows.Forms.TextBox();
            this.woodAge = new System.Windows.Forms.TextBox();
            this.woodName = new System.Windows.Forms.TextBox();
            this.newWoodText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.White;
            this.goBackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(197, 293);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(164, 49);
            this.goBackButton.TabIndex = 23;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // addWood
            // 
            this.addWood.BackColor = System.Drawing.Color.White;
            this.addWood.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWood.Location = new System.Drawing.Point(197, 238);
            this.addWood.Name = "addWood";
            this.addWood.Size = new System.Drawing.Size(164, 49);
            this.addWood.TabIndex = 22;
            this.addWood.Text = "Добавить элемент";
            this.addWood.UseVisualStyleBackColor = false;
            this.addWood.Click += new System.EventHandler(this.addWood_Click);
            // 
            // woodHeightText
            // 
            this.woodHeightText.AutoSize = true;
            this.woodHeightText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodHeightText.Location = new System.Drawing.Point(82, 187);
            this.woodHeightText.Name = "woodHeightText";
            this.woodHeightText.Size = new System.Drawing.Size(109, 29);
            this.woodHeightText.TabIndex = 21;
            this.woodHeightText.Text = "Высота:";
            // 
            // woodAgeText
            // 
            this.woodAgeText.AutoSize = true;
            this.woodAgeText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodAgeText.Location = new System.Drawing.Point(75, 138);
            this.woodAgeText.Name = "woodAgeText";
            this.woodAgeText.Size = new System.Drawing.Size(116, 29);
            this.woodAgeText.TabIndex = 20;
            this.woodAgeText.Text = "Возраст:";
            // 
            // woodNameText
            // 
            this.woodNameText.AutoSize = true;
            this.woodNameText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodNameText.Location = new System.Drawing.Point(58, 91);
            this.woodNameText.Name = "woodNameText";
            this.woodNameText.Size = new System.Drawing.Size(133, 29);
            this.woodNameText.TabIndex = 19;
            this.woodNameText.Text = "Название:";
            // 
            // woodHeight
            // 
            this.woodHeight.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodHeight.Location = new System.Drawing.Point(197, 188);
            this.woodHeight.Name = "woodHeight";
            this.woodHeight.Size = new System.Drawing.Size(164, 32);
            this.woodHeight.TabIndex = 18;
            // 
            // woodAge
            // 
            this.woodAge.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodAge.Location = new System.Drawing.Point(197, 139);
            this.woodAge.Name = "woodAge";
            this.woodAge.Size = new System.Drawing.Size(164, 32);
            this.woodAge.TabIndex = 17;
            // 
            // woodName
            // 
            this.woodName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodName.Location = new System.Drawing.Point(197, 91);
            this.woodName.Name = "woodName";
            this.woodName.Size = new System.Drawing.Size(164, 32);
            this.woodName.TabIndex = 16;
            // 
            // newWoodText
            // 
            this.newWoodText.AutoSize = true;
            this.newWoodText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWoodText.Location = new System.Drawing.Point(171, 50);
            this.newWoodText.Name = "newWoodText";
            this.newWoodText.Size = new System.Drawing.Size(218, 29);
            this.newWoodText.TabIndex = 15;
            this.newWoodText.Text = "Введите данные:";
            // 
            // NewWood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.addWood);
            this.Controls.Add(this.woodHeightText);
            this.Controls.Add(this.woodAgeText);
            this.Controls.Add(this.woodNameText);
            this.Controls.Add(this.woodHeight);
            this.Controls.Add(this.woodAge);
            this.Controls.Add(this.woodName);
            this.Controls.Add(this.newWoodText);
            this.Name = "NewWood";
            this.Text = "NewWood";
            this.Load += new System.EventHandler(this.NewWood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button addWood;
        private System.Windows.Forms.Label woodHeightText;
        private System.Windows.Forms.Label woodAgeText;
        private System.Windows.Forms.Label woodNameText;
        private System.Windows.Forms.TextBox woodHeight;
        private System.Windows.Forms.TextBox woodAge;
        private System.Windows.Forms.TextBox woodName;
        private System.Windows.Forms.Label newWoodText;
    }
}