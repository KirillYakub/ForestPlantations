
namespace ForestPlantations
{
    partial class WoodMenu
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
            this.woodText = new System.Windows.Forms.Label();
            this.inputDeleteBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.deleteElement = new System.Windows.Forms.Button();
            this.addElement = new System.Windows.Forms.Button();
            this.sortWoodArr = new System.Windows.Forms.Button();
            this.outputInfo = new System.Windows.Forms.Button();
            this.woodPageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // woodText
            // 
            this.woodText.AutoSize = true;
            this.woodText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodText.Location = new System.Drawing.Point(324, 364);
            this.woodText.Name = "woodText";
            this.woodText.Size = new System.Drawing.Size(311, 29);
            this.woodText.TabIndex = 25;
            this.woodText.Text = "Введите номер для удаления:";
            // 
            // inputDeleteBox
            // 
            this.inputDeleteBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputDeleteBox.Location = new System.Drawing.Point(632, 364);
            this.inputDeleteBox.Name = "inputDeleteBox";
            this.inputDeleteBox.Size = new System.Drawing.Size(93, 32);
            this.inputDeleteBox.TabIndex = 24;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(329, 82);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(396, 259);
            this.outputBox.TabIndex = 23;
            this.outputBox.Text = "";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.White;
            this.goBackButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(89, 338);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(171, 58);
            this.goBackButton.TabIndex = 22;
            this.goBackButton.Text = "Назад";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // deleteElement
            // 
            this.deleteElement.BackColor = System.Drawing.Color.White;
            this.deleteElement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteElement.Location = new System.Drawing.Point(89, 274);
            this.deleteElement.Name = "deleteElement";
            this.deleteElement.Size = new System.Drawing.Size(171, 58);
            this.deleteElement.TabIndex = 21;
            this.deleteElement.Text = "Удалить элемент";
            this.deleteElement.UseVisualStyleBackColor = false;
            this.deleteElement.Click += new System.EventHandler(this.deleteElement_Click);
            // 
            // addElement
            // 
            this.addElement.BackColor = System.Drawing.Color.White;
            this.addElement.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addElement.Location = new System.Drawing.Point(89, 210);
            this.addElement.Name = "addElement";
            this.addElement.Size = new System.Drawing.Size(171, 58);
            this.addElement.TabIndex = 20;
            this.addElement.Text = "Добавить элемент";
            this.addElement.UseVisualStyleBackColor = false;
            this.addElement.Click += new System.EventHandler(this.addElement_Click);
            // 
            // sortWoodArr
            // 
            this.sortWoodArr.BackColor = System.Drawing.Color.White;
            this.sortWoodArr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortWoodArr.Location = new System.Drawing.Point(89, 146);
            this.sortWoodArr.Name = "sortWoodArr";
            this.sortWoodArr.Size = new System.Drawing.Size(171, 58);
            this.sortWoodArr.TabIndex = 19;
            this.sortWoodArr.Text = "Отсортировать список";
            this.sortWoodArr.UseVisualStyleBackColor = false;
            this.sortWoodArr.Click += new System.EventHandler(this.sortWoodArr_Click);
            // 
            // outputInfo
            // 
            this.outputInfo.BackColor = System.Drawing.Color.White;
            this.outputInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputInfo.Location = new System.Drawing.Point(89, 82);
            this.outputInfo.Name = "outputInfo";
            this.outputInfo.Size = new System.Drawing.Size(171, 58);
            this.outputInfo.TabIndex = 18;
            this.outputInfo.Text = "Вывести информацию о всех деревьях\r\n";
            this.outputInfo.UseVisualStyleBackColor = false;
            this.outputInfo.Click += new System.EventHandler(this.outputInfo_Click);
            // 
            // woodPageText
            // 
            this.woodPageText.AutoSize = true;
            this.woodPageText.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.woodPageText.Location = new System.Drawing.Point(91, 41);
            this.woodPageText.Name = "woodPageText";
            this.woodPageText.Size = new System.Drawing.Size(169, 29);
            this.woodPageText.TabIndex = 17;
            this.woodPageText.Text = "Меню Деревьев";
            // 
            // WoodMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.woodText);
            this.Controls.Add(this.inputDeleteBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.deleteElement);
            this.Controls.Add(this.addElement);
            this.Controls.Add(this.sortWoodArr);
            this.Controls.Add(this.outputInfo);
            this.Controls.Add(this.woodPageText);
            this.Name = "WoodMenu";
            this.Text = "WoodMenu";
            this.Load += new System.EventHandler(this.WoodMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label woodText;
        private System.Windows.Forms.TextBox inputDeleteBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button deleteElement;
        private System.Windows.Forms.Button addElement;
        private System.Windows.Forms.Button sortWoodArr;
        private System.Windows.Forms.Button outputInfo;
        private System.Windows.Forms.Label woodPageText;
    }
}