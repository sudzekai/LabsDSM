namespace Task2
{
    partial class ReplaceForm
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
            label1 = new Label();
            searchTextBox = new TextBox();
            label2 = new Label();
            replaceTextBox = new TextBox();
            replaceButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Найти";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 27);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Заменить на";
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(12, 71);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(100, 23);
            replaceTextBox.TabIndex = 3;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(12, 100);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(100, 23);
            replaceButton.TabIndex = 4;
            replaceButton.Text = "Заменить";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(139, 159);
            Controls.Add(replaceButton);
            Controls.Add(replaceTextBox);
            Controls.Add(label2);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Name = "ReplaceForm";
            Text = "Заменить";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchTextBox;
        private Label label2;
        private TextBox replaceTextBox;
        private Button replaceButton;
    }
}