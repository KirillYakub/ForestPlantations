
namespace ForestPlantations
{
    partial class BushMenu
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
            this.deleteElement = new System.Windows.Forms.Button();
            this.addElement = new System.Windows.Forms.Button();
            this.sortBushArr = new System.Windows.Forms.Button();
            this.outputInfo = new System.Windows.Forms.Button();
            this.bushPageText = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.inputDeleteBox = new System.Windows.Forms.TextBox();
            this.bushText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.White;
            this.goBackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(90, 340);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(171, 58);
            this.goBackButton.TabIndex = 13;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // deleteElement
            // 
            this.deleteElement.BackColor = System.Drawing.Color.White;
            this.deleteElement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteElement.Location = new System.Drawing.Point(90, 276);
            this.deleteElement.Name = "deleteElement";
            this.deleteElement.Size = new System.Drawing.Size(171, 58);
            this.deleteElement.TabIndex = 12;
            this.deleteElement.Text = "Удалить элемент";
            this.deleteElement.UseVisualStyleBackColor = false;
            this.deleteElement.Click += new System.EventHandler(this.deleteElement_Click);
            // 
            // addElement
            // 
            this.addElement.BackColor = System.Drawing.Color.White;
            this.addElement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElement.Location = new System.Drawing.Point(90, 212);
            this.addElement.Name = "addElement";
            this.addElement.Size = new System.Drawing.Size(171, 58);
            this.addElement.TabIndex = 11;
            this.addElement.Text = "Добавить элемент";
            this.addElement.UseVisualStyleBackColor = false;
            this.addElement.Click += new System.EventHandler(this.addElement_Click);
            // 
            // sortBushArr
            // 
            this.sortBushArr.BackColor = System.Drawing.Color.White;
            this.sortBushArr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBushArr.Location = new System.Drawing.Point(90, 148);
            this.sortBushArr.Name = "sortBushArr";
            this.sortBushArr.Size = new System.Drawing.Size(171, 58);
            this.sortBushArr.TabIndex = 10;
            this.sortBushArr.Text = "Отсортировать список";
            this.sortBushArr.UseVisualStyleBackColor = false;
            this.sortBushArr.Click += new System.EventHandler(this.sortBushArr_Click);
            // 
            // outputInfo
            // 
            this.outputInfo.BackColor = System.Drawing.Color.White;
            this.outputInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputInfo.Location = new System.Drawing.Point(90, 84);
            this.outputInfo.Name = "outputInfo";
            this.outputInfo.Size = new System.Drawing.Size(171, 58);
            this.outputInfo.TabIndex = 9;
            this.outputInfo.Text = "Вывести информацию о всех кустах";
            this.outputInfo.UseVisualStyleBackColor = false;
            this.outputInfo.Click += new System.EventHandler(this.outputInfo_Click);
            // 
            // bushPageText
            // 
            this.bushPageText.AutoSize = true;
            this.bushPageText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushPageText.Location = new System.Drawing.Point(104, 43);
            this.bushPageText.Name = "bushPageText";
            this.bushPageText.Size = new System.Drawing.Size(142, 29);
            this.bushPageText.TabIndex = 8;
            this.bushPageText.Text = "Меню Кустов";
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(330, 84);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(396, 259);
            this.outputBox.TabIndex = 14;
            this.outputBox.Text = "";
            // 
            // inputDeleteBox
            // 
            this.inputDeleteBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDeleteBox.Location = new System.Drawing.Point(633, 366);
            this.inputDeleteBox.Name = "inputDeleteBox";
            this.inputDeleteBox.Size = new System.Drawing.Size(93, 32);
            this.inputDeleteBox.TabIndex = 15;
            // 
            // bushText
            // 
            this.bushText.AutoSize = true;
            this.bushText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bushText.Location = new System.Drawing.Point(325, 366);
            this.bushText.Name = "bushText";
            this.bushText.Size = new System.Drawing.Size(311, 29);
            this.bushText.TabIndex = 16;
            this.bushText.Text = "Введите номер для удаления:";
            // 
            // BushMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bushText);
            this.Controls.Add(this.inputDeleteBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.deleteElement);
            this.Controls.Add(this.addElement);
            this.Controls.Add(this.sortBushArr);
            this.Controls.Add(this.outputInfo);
            this.Controls.Add(this.bushPageText);
            this.Name = "BushMenu";
            this.Text = "BushMenu";
            this.Load += new System.EventHandler(this.BushMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button deleteElement;
        private System.Windows.Forms.Button addElement;
        private System.Windows.Forms.Button sortBushArr;
        private System.Windows.Forms.Button outputInfo;
        private System.Windows.Forms.Label bushPageText;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.TextBox inputDeleteBox;
        private System.Windows.Forms.Label bushText;
    }
}