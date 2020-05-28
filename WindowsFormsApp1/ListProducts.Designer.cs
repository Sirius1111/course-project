namespace WindowsFormsApp1
{
    partial class ListProducts
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.PrintDataButton = new System.Windows.Forms.Button();
            this.stateInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintRandomGuitars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(12, 38);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(196, 28);
            this.nameInput.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(223, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 28);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить в БД";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PrintDataButton
            // 
            this.PrintDataButton.Location = new System.Drawing.Point(365, 38);
            this.PrintDataButton.Name = "PrintDataButton";
            this.PrintDataButton.Size = new System.Drawing.Size(78, 28);
            this.PrintDataButton.TabIndex = 2;
            this.PrintDataButton.Text = "Вывести БД";
            this.PrintDataButton.UseVisualStyleBackColor = true;
            this.PrintDataButton.Click += new System.EventHandler(this.PrintDataButton_Click);
            // 
            // stateInput
            // 
            this.stateInput.Location = new System.Drawing.Point(12, 72);
            this.stateInput.Multiline = true;
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(104, 28);
            this.stateInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название и состояние гитары";
            // 
            // PrintRandomGuitars
            // 
            this.PrintRandomGuitars.Location = new System.Drawing.Point(223, 72);
            this.PrintRandomGuitars.Name = "PrintRandomGuitars";
            this.PrintRandomGuitars.Size = new System.Drawing.Size(220, 28);
            this.PrintRandomGuitars.TabIndex = 1;
            this.PrintRandomGuitars.Text = "Вывести 3 случайные гитары";
            this.PrintRandomGuitars.UseVisualStyleBackColor = true;
            this.PrintRandomGuitars.Click += new System.EventHandler(this.PrintRandomGuitars_Click);
            // 
            // ListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintDataButton);
            this.Controls.Add(this.PrintRandomGuitars);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.nameInput);
            this.Name = "ListProducts";
            this.Text = "ListProducts";
            this.Load += new System.EventHandler(this.ListProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button PrintDataButton;
        private System.Windows.Forms.TextBox stateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintRandomGuitars;
    }
}