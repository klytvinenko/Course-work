
namespace Shoes.View
{
    partial class AddFootWearForm
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
            this.components = new System.ComponentModel.Container();
            this.saveFootWear = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ShoesTypeLabel = new System.Windows.Forms.Label();
            this.shoesTypeComboBox = new System.Windows.Forms.ComboBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFootWear
            // 
            this.saveFootWear.Location = new System.Drawing.Point(12, 171);
            this.saveFootWear.Name = "saveFootWear";
            this.saveFootWear.Size = new System.Drawing.Size(190, 23);
            this.saveFootWear.TabIndex = 10;
            this.saveFootWear.Text = "Save footwear";
            this.saveFootWear.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ShoesTypeLabel
            // 
            this.ShoesTypeLabel.AutoSize = true;
            this.ShoesTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.ShoesTypeLabel.Name = "ShoesTypeLabel";
            this.ShoesTypeLabel.Size = new System.Drawing.Size(63, 15);
            this.ShoesTypeLabel.TabIndex = 11;
            this.ShoesTypeLabel.Text = "ShoesType";
            // 
            // shoesTypeComboBox
            // 
            this.shoesTypeComboBox.FormattingEnabled = true;
            this.shoesTypeComboBox.Items.AddRange(new object[] {
            "Shoes",
            "Trainers",
            "Sneakers"});
            this.shoesTypeComboBox.Location = new System.Drawing.Point(81, 6);
            this.shoesTypeComboBox.Name = "shoesTypeComboBox";
            this.shoesTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.shoesTypeComboBox.TabIndex = 12;
            // 
            // MaterialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Items.AddRange(new object[] {
            "Leather",
            "ImitationLeather",
            "Fabric"});
            this.materialComboBox.Location = new System.Drawing.Point(81, 35);
            this.materialComboBox.Name = "MaterialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 23);
            this.materialComboBox.TabIndex = 14;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(12, 38);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(50, 15);
            this.MaterialLabel.TabIndex = 13;
            this.MaterialLabel.Text = "Material";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unisex"});
            this.genderComboBox.Location = new System.Drawing.Point(81, 64);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(121, 23);
            this.genderComboBox.TabIndex = 16;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 67);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(45, 15);
            this.GenderLabel.TabIndex = 15;
            this.GenderLabel.Text = "Gender";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(12, 96);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 15);
            this.SizeLabel.TabIndex = 17;
            this.SizeLabel.Text = "Size";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(81, 94);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(121, 23);
            this.sizeTextBox.TabIndex = 18;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Black",
            "White",
            "Gray"});
            this.colorComboBox.Location = new System.Drawing.Point(81, 123);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 23);
            this.colorComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Color";
            // 
            // AddFootWearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.shoesTypeComboBox);
            this.Controls.Add(this.ShoesTypeLabel);
            this.Controls.Add(this.saveFootWear);
            this.Name = "AddFootWearForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MakeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button saveFootWear;
        internal System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label ShoesTypeLabel;
        private System.Windows.Forms.Label SizeLabel;
        public System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        public System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label MaterialLabel;
        public System.Windows.Forms.ComboBox shoesTypeComboBox;
        public System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox colorComboBox;
    }
}