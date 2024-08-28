using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VT24Assignment1.Animals
{
    public partial class FoodItemForm : Form
    {
        // Properties to hold user input data
        public string FoodItemName { get; set; }
        public List<string> FoodItemIngredients { get; set; }

    
        // Constructor
        public FoodItemForm()
        {
            InitializeComponent();
            FoodItemIngredients = new List<string>();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnOk = new Button();
            btnDelete = new Button();
            btnChange = new Button();
            btnAdd = new Button();
            listBoxIngredients = new ListBox();
            label2 = new Label();
            txtIngredient = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(421, 39);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnOk);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnChange);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(listBoxIngredients);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIngredient);
            groupBox1.Location = new Point(18, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 528);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Ingredients";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(252, 471);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 51);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(59, 471);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(162, 51);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(17, 299);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(17, 217);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(165, 47);
            btnChange.TabIndex = 4;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 45);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // listBoxIngredients
            // 
            listBoxIngredients.FormattingEnabled = true;
            listBoxIngredients.ItemHeight = 32;
            listBoxIngredients.Location = new Point(205, 127);
            listBoxIngredients.Name = "listBoxIngredients";
            listBoxIngredients.Size = new Size(392, 324);
            listBoxIngredients.TabIndex = 2;
            listBoxIngredients.SelectedIndexChanged += listBoxIngredients_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Ingredient";
            // 
            // txtIngredient
            // 
            txtIngredient.Location = new Point(205, 56);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(385, 39);
            txtIngredient.TabIndex = 0;
            // 
            // FoodItemForm
            // 
            ClientSize = new Size(661, 650);
            Controls.Add(groupBox1);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "FoodItemForm";
            Load += FoodForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public string GetFoodItemName()
        {
            // Retrieve the name from the text box
            return txtName.Text.Trim();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            FoodItemName = txtName.Text.Trim();

            // Close the form 
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtIngredient;
        private ListBox listBoxIngredients;
        private Button btnChange;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnOk;
        private Button btnDelete;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the ingredient from the text box
            string ingredient = txtIngredient.Text.Trim();

            // Add the ingredient to the list box and the list
            if (!string.IsNullOrEmpty(ingredient))
            {
                listBoxIngredients.Items.Add(ingredient);
                FoodItemIngredients.Add(ingredient);

                // Clear the text box for the next input
                txtIngredient.Clear();
            }

        }

        // Change button
        private void btnChange_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list box
            if (listBoxIngredients.SelectedItem != null)
            {
                string selectedItem = listBoxIngredients.SelectedItem.ToString();

                string newIngredient = Microsoft.VisualBasic.Interaction.InputBox("Enter the new ingredient:", "Change Ingredient", selectedItem);

                // Check if  user included a new ingredient
                if (!string.IsNullOrEmpty(newIngredient))
                {
                    int selectedIndex = listBoxIngredients.SelectedIndex;
                    listBoxIngredients.Items[selectedIndex] = newIngredient;
                    FoodItemIngredients[selectedIndex] = newIngredient;
                }
            }
        }
        // Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients.SelectedItem != null)
            {
                // Remove the selected item
                int selectedIndex = listBoxIngredients.SelectedIndex;
                listBoxIngredients.Items.RemoveAt(selectedIndex);
                FoodItemIngredients.RemoveAt(selectedIndex);
            }
        }

        private void listBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the with selected ingredients
            if (listBoxIngredients.SelectedItem != null)
            {
                txtIngredient.Text = listBoxIngredients.SelectedItem.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveFoodItem();

        }

        private void SaveFoodItem()
        {
            string foodItemName = txtName.Text.Trim();

            FoodItem foodItem = new FoodItem(foodItemName, FoodItemIngredients);

            DialogResult = DialogResult.OK;

            Close();
        }

        public List<string> GetFoodItemIngredients()
        {
            return FoodItemIngredients;
        }

        // Close window without saving
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
