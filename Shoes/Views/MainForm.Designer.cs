
namespace Shoes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FootWears = new System.Windows.Forms.ListBox();
            this.addFootWearButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.removeOrderButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FootWears
            // 
            this.FootWears.FormattingEnabled = true;
            this.FootWears.ItemHeight = 15;
            this.FootWears.Location = new System.Drawing.Point(12, 12);
            this.FootWears.Name = "FootWears";
            this.FootWears.Size = new System.Drawing.Size(473, 424);
            this.FootWears.TabIndex = 0;
            // 
            // addFootWearButton
            // 
            this.addFootWearButton.Location = new System.Drawing.Point(491, 12);
            this.addFootWearButton.Name = "addFootWearButton";
            this.addFootWearButton.Size = new System.Drawing.Size(297, 23);
            this.addFootWearButton.TabIndex = 1;
            this.addFootWearButton.Text = "Add footwear";
            this.addFootWearButton.UseVisualStyleBackColor = true;
            this.addFootWearButton.Click += new System.EventHandler(this.addFootWearButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(491, 70);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(297, 23);
            this.openFileButton.TabIndex = 3;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(491, 99);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(297, 23);
            this.saveFileButton.TabIndex = 4;
            this.saveFileButton.Text = "Save file";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // removeOrderButton
            // 
            this.removeOrderButton.Location = new System.Drawing.Point(491, 41);
            this.removeOrderButton.Name = "removeOrderButton";
            this.removeOrderButton.Size = new System.Drawing.Size(297, 23);
            this.removeOrderButton.TabIndex = 6;
            this.removeOrderButton.Text = "Remove footwear";
            this.removeOrderButton.UseVisualStyleBackColor = true;
            this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "None",
            "Black",
            "White",
            "Gray"});
            this.colorComboBox.Location = new System.Drawing.Point(564, 129);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(223, 23);
            this.colorComboBox.TabIndex = 7;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Items.AddRange(new object[] {
            "None",
            "Leather",
            "ImitationLeather",
            "Fabric"});
            this.materialComboBox.Location = new System.Drawing.Point(564, 158);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(224, 23);
            this.materialComboBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "None",
            "Male",
            "Female",
            "Unisex"});
            this.genderComboBox.Location = new System.Drawing.Point(564, 187);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(224, 23);
            this.genderComboBox.TabIndex = 9;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(491, 216);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(297, 23);
            this.filterButton.TabIndex = 10;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(491, 132);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(36, 15);
            this.colorLabel.TabIndex = 11;
            this.colorLabel.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gender";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.removeOrderButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.addFootWearButton);
            this.Controls.Add(this.FootWears);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox FootWears;
        internal System.Windows.Forms.Button addFootWearButton;
        internal System.Windows.Forms.Button openFileButton;
        internal System.Windows.Forms.Button saveFileButton;
        internal System.Windows.Forms.Button removeOrderButton;
        internal System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox colorComboBox;
        public System.Windows.Forms.ComboBox materialComboBox;
        public System.Windows.Forms.ComboBox genderComboBox;
    }
}

