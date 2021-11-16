
namespace ForestPlantations
{
    partial class MainDatabasePage
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
            this.mainPageText = new System.Windows.Forms.Label();
            this.toBushMenu = new System.Windows.Forms.Button();
            this.toWoodMenu = new System.Windows.Forms.Button();
            this.filewriteButton = new System.Windows.Forms.Button();
            this.filereaderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPageText
            // 
            this.mainPageText.AutoSize = true;
            this.mainPageText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPageText.Location = new System.Drawing.Point(169, 35);
            this.mainPageText.Name = "mainPageText";
            this.mainPageText.Size = new System.Drawing.Size(156, 29);
            this.mainPageText.TabIndex = 0;
            this.mainPageText.Text = "Главное меню";
            // 
            // toBushMenu
            // 
            this.toBushMenu.BackColor = System.Drawing.Color.White;
            this.toBushMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toBushMenu.Location = new System.Drawing.Point(164, 76);
            this.toBushMenu.Name = "toBushMenu";
            this.toBushMenu.Size = new System.Drawing.Size(171, 58);
            this.toBushMenu.TabIndex = 1;
            this.toBushMenu.Text = "Перейти в меню \"Кусты\"";
            this.toBushMenu.UseVisualStyleBackColor = false;
            this.toBushMenu.Click += new System.EventHandler(this.toBushMenu_Click);
            // 
            // toWoodMenu
            // 
            this.toWoodMenu.BackColor = System.Drawing.Color.White;
            this.toWoodMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toWoodMenu.Location = new System.Drawing.Point(164, 140);
            this.toWoodMenu.Name = "toWoodMenu";
            this.toWoodMenu.Size = new System.Drawing.Size(171, 58);
            this.toWoodMenu.TabIndex = 2;
            this.toWoodMenu.Text = "Перейти в меню \"Деревья\"";
            this.toWoodMenu.UseVisualStyleBackColor = false;
            this.toWoodMenu.Click += new System.EventHandler(this.toWoodMenu_Click);
            // 
            // filewriteButton
            // 
            this.filewriteButton.BackColor = System.Drawing.Color.White;
            this.filewriteButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filewriteButton.Location = new System.Drawing.Point(164, 204);
            this.filewriteButton.Name = "filewriteButton";
            this.filewriteButton.Size = new System.Drawing.Size(171, 58);
            this.filewriteButton.TabIndex = 3;
            this.filewriteButton.Text = "Записать данные в файл";
            this.filewriteButton.UseVisualStyleBackColor = false;
            this.filewriteButton.Click += new System.EventHandler(this.filewriteButton_Click);
            // 
            // filereaderButton
            // 
            this.filereaderButton.BackColor = System.Drawing.Color.White;
            this.filereaderButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filereaderButton.Location = new System.Drawing.Point(164, 268);
            this.filereaderButton.Name = "filereaderButton";
            this.filereaderButton.Size = new System.Drawing.Size(171, 58);
            this.filereaderButton.TabIndex = 5;
            this.filereaderButton.Text = "Cчитать данные из файла";
            this.filereaderButton.UseVisualStyleBackColor = false;
            this.filereaderButton.Click += new System.EventHandler(this.filereaderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(164, 332);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(171, 58);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainDatabasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(498, 451);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.filereaderButton);
            this.Controls.Add(this.filewriteButton);
            this.Controls.Add(this.toWoodMenu);
            this.Controls.Add(this.toBushMenu);
            this.Controls.Add(this.mainPageText);
            this.Name = "MainDatabasePage";
            this.Text = "MainDatabasePage";
            this.Load += new System.EventHandler(this.MainDatabasePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainPageText;
        private System.Windows.Forms.Button toBushMenu;
        private System.Windows.Forms.Button toWoodMenu;
        private System.Windows.Forms.Button filewriteButton;
        private System.Windows.Forms.Button filereaderButton;
        private System.Windows.Forms.Button exitButton;
    }
}

