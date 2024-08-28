using System.Text;
using System.Windows.Forms;
using VT24Assignment1.Animals;
using VT24Assignment1.Birds;
using VT24Assignment1.Insects;
using VT24Assignment1.Mammals;
using VT24Assignment1.Marine;
using VT24Assignment1.Reptiles;
using Newtonsoft.Json;



namespace VT24Assignment1
{

    /// <summary>
    /// Main form for the EcoZoo application.
    /// </summary>
    public partial class EcoZoo : Form
    {
        #region FIELDS

        private string Name;
        private GenderType Gender;
        private CategoryType Category;
        private double Age;

        private AnimalManager manager = new AnimalManager();


        private ListManager<Animal> listManagerInstance;
        private List<Animal> animals = new List<Animal>();



        #endregion

        #region CONSTRUCTOR



        /// <summary>
        /// Initializes a new instance of the EcoZoo/MainForm class.
        /// </summary>
        public EcoZoo()
        {
            InitializeComponent();
            PopulateGenderComboBox();

            listBoxCategory.DataSource = Enum.GetValues(typeof(CategoryType));
            UpdateAvailableSpecies(CategoryType.Mammal);
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            listManagerInstance = new ListManager<Animal>();

        }

        #endregion

        #region METHODS

        /// <summary>
        /// Updates the GUI elements based on the input from the form
        /// </summary>
        private void UpdateGUI()
        {

        }

        /// <summary>
        /// Reads user input and creates an Animal object based on the selected category and species.
        /// </summary>
        private Animal ReadInput()
        {
            //Create correct animal species
            CategoryType category = ReadCategory();
            Animal animal = null;

            switch (category)
            {
                case CategoryType.Mammal:
                    animal = CreateMammal();
                    break;
                case CategoryType.Reptile:
                    animal = CreateReptile();
                    break;
                case CategoryType.Insect:
                    animal = CreateInsect();
                    break;
                case CategoryType.Marine:
                    animal = CreateMarine();
                    break;
                case CategoryType.Bird:
                    animal = CreateBird();
                    break;

                default:
                    return null;
            }
            if (animal != null)
            {
                ReadCommonValues(ref animal);
                animal.IsDomesticated = checkBoxDomesticated.Checked;
            }

            return animal;
        }

        private void ReadCommonValues(ref Animal animal)
        {
            // Assign the name from the textName textbox to the animal
            animal.Name = textName.Text;

            // Parse the age from the textAge textbox
            double age = 0;
            if (double.TryParse(textAge.Text, out age))
                animal.Age = age;

            // Parse the gender selection from comboBoxGender and assign it to the animal
            animal.Gender = (GenderType)Enum.Parse(typeof(GenderType), comboBoxGender.Text);

            // Read the category for the animal
            animal.Category = ReadCategory();
        }

        private (int, double) ReadMammalInput()
        {
            int numOfTeeth = 0;
            double tailLenght = 0;

            if (!int.TryParse(textNumberOfTeeth.Text, out numOfTeeth))
            {
                MessageBox.Show("Please give a valid value for number of teeth.");
            }

            if (!double.TryParse(textLenghtOfTail.Text, out tailLenght))
            {
                MessageBox.Show("Please give a valid value for length of tail.");
            }
            return (numOfTeeth, tailLenght);
        }

        private Animal CreateMammal()
        {
            Animal animal = null;

            // Read number of teeth and tail length
            int numOfTeeth = 0;
            double tailLength = 0;

            (numOfTeeth, tailLength) = ReadMammalInput();

            // Get the selected mammal species
            MammalSpecies species = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listBoxSpecies.Text);

            switch (species)
            {
                case MammalSpecies.Dog:
                    animal = new Dog(numOfTeeth, tailLength);
                    ((Dog)animal).Breed = textBreed.Text;
                    break;
                case MammalSpecies.Cat:
                    animal = new Cat(numOfTeeth, tailLength);

                    if (int.TryParse(textCuteness.Text, out int cuteness))
                    {
                        ((Cat)animal).Cuteness = cuteness;
                    }
                    else
                    {
                        ((Cat)animal).Cuteness = 0;
                    }

                    break;

            }
            return animal;
        }

        private (double, bool) ReadReptileInput()
        {
            double weight = 0;
            bool livesInWater = false;

            if (!double.TryParse(textWeight.Text, out weight))
            {
                MessageBox.Show("Please give a valid value for weight.");
            }

            // Read the state of the checkbox to determine if the reptile lives in water
            livesInWater = checkLivesInWater.Checked;

            return (weight, livesInWater);

        }
        private Animal CreateReptile()
        {
            // Read weight and if the reptile lives in water
            double weight = 0;
            bool livesInWater = false;

            (weight, livesInWater) = ReadReptileInput();

            // Get the selected reptile species
            ReptileSpecies species = (ReptileSpecies)Enum.Parse(typeof(ReptileSpecies), listBoxSpecies.Text);

            //Create reptile using ReptileFactory
            Animal animal = ReptileFactory.CreateReptile(species, weight, livesInWater);

            return animal;

        }

        private bool ReadInsectInput()
        {
            bool hasWings = checkHasWings.Checked;
            return hasWings;
        }

        private Animal CreateInsect()
        {
            //Read if the insect has wings true/false
            bool hasWings = false;

            (hasWings) = ReadInsectInput();

            // Get the selected insect species
            InsectSpecies species = (InsectSpecies)Enum.Parse(typeof(InsectSpecies), listBoxSpecies.Text);

            // Create an insect using InsectFactory
            Animal animal = InsectFactory.CreateInsect(species, hasWings);

            return animal;

        }

        private (double, bool) ReadMarineInput()
        {
            double fishLength = 0;
            bool isDangerous = true;

            if (!double.TryParse(textLenghtOfFish.Text, out fishLength))
            {
                MessageBox.Show("Please enter a valid value for the length of the fish.");
            }
            else
            {
                // Set isDangerous to true only if the checkbox is checked
                isDangerous = checkBoxIsDangerous.Checked;
            }

            return (fishLength, isDangerous);

        }
        private Animal CreateMarine()
        {
            // Read the length of the marine and if it is dangerous or not
            double fishLength = 0;
            bool isDangerous = true;

            (fishLength, isDangerous) = ReadMarineInput();

            // Get the selected marine species
            MarineSpecies species = (MarineSpecies)Enum.Parse(typeof(MarineSpecies), listBoxSpecies.Text);

            // Create a marine using MarineFactory
            Animal animal = MarineFactory.CreateMarine(species, fishLength, isDangerous);

            return animal;
        }

        private (double, double) ReadBirdInput()
        {
            double wingspan = 0;
            double lengthOfBeak = 0;

            if (!double.TryParse(textWingspan.Text, out wingspan))
            {
                MessageBox.Show("Please enter a valid value for wingspan.");
            }

            if (!double.TryParse(textLengthOfBeak.Text, out lengthOfBeak))
            {
                MessageBox.Show("Please enter a valid value for the length of the beak.");
            }

            return (wingspan, lengthOfBeak);

        }
        private Animal CreateBird()
        {
            // Read the wing span and lenght of the beak
            double wingspan;
            double lenghtOfBeak;

            (wingspan, lenghtOfBeak) = ReadBirdInput();

            // Get the selected bird species
            BirdSpecies species = (BirdSpecies)Enum.Parse(typeof(BirdSpecies), listBoxSpecies.Text);

            // Create a bird using BirdFactory
            Animal animal = BirdFactory.CreateBird(species, wingspan, lenghtOfBeak);

            return animal;

        }

        private CategoryType ReadCategory()
        {
            // Check if an item is selected in the listBoxCategory
            // Return the selected category from the listBoxCategory
            if (listBoxCategory.SelectedItem != null)
            {
                return (CategoryType)listBoxCategory.SelectedItem;
            }
            else
            {
                throw new InvalidOperationException("No category selected.");
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            // Update the 'Name' property with the text from the textBoxName
            Name = textName.Text;
        }

        private void listBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategory.SelectedItem != null)
            {
                // Get the selected category from listBoxCategory
                CategoryType selectedCategory = (CategoryType)listBoxCategory.SelectedItem;
                UpdateAvailableSpecies(selectedCategory);
            }

            if (listBoxCategory.SelectedItem != null && listBoxSpecies.SelectedItem != null)
            {
                ShowGroupBoxes();
            }
            else
            {
                HideGroupBoxes();
            }
        }


        private void listBoxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if both category and species have been selected
            if (listBoxCategory.SelectedItem != null && listBoxSpecies.SelectedItem != null)
            {
                ShowGroupBoxes();
            }
            else
            {
                HideGroupBoxes();
            }
        }

        private void ShowGroupBoxes()
        {
            HideGroupBoxes();

            // Show the group box corresponding to the selected species
            CategoryType selectedCategory = (CategoryType)listBoxCategory.SelectedItem;
            string selectedSpecies = (string)listBoxSpecies.SelectedItem;

            switch (selectedCategory)
            {
                case CategoryType.Bird:
                    groupBirdSpecifications.Visible = true;
                    break;
                case CategoryType.Insect:
                    groupInsectSpecification.Visible = true;
                    break;
                case CategoryType.Mammal:
                    groupMammalSpecifications.Visible = true;
                    if (selectedSpecies == "Cat")
                        groupCatSpecifications.Visible = true;
                    else if (selectedSpecies == "Dog")
                        groupDogSpecifications.Visible = true;
                    else
                        groupMammalSpecifications.Visible = true;
                    break;
                case CategoryType.Marine:
                    if (selectedSpecies == "Shark" || selectedSpecies == "Goldfish")
                        groupMarineSpecifications.Visible = true;
                    else
                        groupMarineSpecifications.Visible = true;
                    break;
                case CategoryType.Reptile:
                    if (selectedSpecies == "Frog" || selectedSpecies == "Lizard")
                        groupReptileSpecification.Visible = true;
                    else
                        groupReptileSpecification.Visible = true;
                    break;
            }
        }

        private void HideGroupBoxes()
        {
            groupCatSpecifications.Visible = false;
            groupMammalSpecifications.Visible = false;
            groupBirdSpecifications.Visible = false;
            groupDogSpecifications.Visible = false;
            groupInsectSpecification.Visible = false;
            groupMarineSpecifications.Visible = false;
            groupReptileSpecification.Visible = false;
        }

        private CategoryType DetermineCategoryFromSpecies(string species)
        {
            switch (species)
            {
                case "Cat":
                case "Dog":
                    return CategoryType.Mammal;
                case "Shark":
                case "Goldfish":
                    return CategoryType.Marine;
                case "Frog":
                case "Lizard":
                    return CategoryType.Reptile;
                case "Bee":
                case "Ant":
                    return CategoryType.Insect;
                case "Dove":
                case "Eagle":
                    return CategoryType.Bird;
                default:
                    throw new InvalidOperationException("Unknown species.");
            }
        }


        /// <summary>
        /// Updates the list of available species based on the selected category.
        /// </summary>
        private void UpdateAvailableSpecies(CategoryType category)
        {
            // Clear the existing items in listBoxSpecies
            listBoxSpecies.Items.Clear();

            // Populate listBoxSpecies with species based on the selected category
            switch (category)
            {
                case CategoryType.Bird:
                    listBoxSpecies.Items.AddRange(Enum.GetNames(typeof(BirdSpecies)));
                    break;
                case CategoryType.Insect:
                    listBoxSpecies.Items.AddRange(Enum.GetNames(typeof(InsectSpecies)));
                    break;
                case CategoryType.Mammal:
                    listBoxSpecies.Items.AddRange(Enum.GetNames(typeof(MammalSpecies)));
                    break;
                case CategoryType.Marine:
                    listBoxSpecies.Items.AddRange(Enum.GetNames(typeof(MarineSpecies)));
                    break;
                case CategoryType.Reptile:
                    listBoxSpecies.Items.AddRange(Enum.GetNames(typeof(ReptileSpecies)));
                    break;
                default:
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Animal animal = ReadInput();
            if (animal != null)
            {
                string generatedID = manager.AddItem(animal);
                listManagerInstance.AddItem(animal);
                listBoxAllAnimals.Items.Add($"{animal.ID}, {animal.Name}, {animal.Age}, {animal.Gender}");
                lblExtraInfo.Text = $"{animal.ToString()}\nGenerated ID: {generatedID}";
                UpdateGUI();
            }
        }


        /// <summary>
        /// Populates the gender combo box with gender options from the Enum class GenderType
        /// </summary>
        private void PopulateGenderComboBox()
        {
            comboBoxGender.DataSource = Enum.GetValues(typeof(GenderType));
        }
        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedItem != null)
            {
                GenderType selectedGender = (GenderType)comboBoxGender.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a gender.");
            }
        }

        private void groupCatSpecifications_Enter(object sender, EventArgs e)
        {

        }

        private void groupMammalSpecifications_Enter(object sender, EventArgs e)
        {

        }

        private void groupBirdSpecifications_Enter(object sender, EventArgs e)
        {

        }

        private void groupDogSpecifications_Enter(object sender, EventArgs e)
        {

        }

        private void groupInsectSpecification_Enter(object sender, EventArgs e)
        {

        }

        private void groupMarineSpecifications_Enter(object sender, EventArgs e)
        {

        }

        private void groupReptileSpecification_Enter(object sender, EventArgs e)
        {

        }

        private void textLenghtOfFish_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAddedAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void lblExtraInfo_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAllAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxAllAnimals.SelectedIndex;
            if (index == -1)
                return;

            Animal animal = manager.GetAt(index);

            // Update listBoxAnimalInfo with the ToString representation of the selected Animal
            listBoxAnimalInfo.Items.Clear();

            string extraInfo = animal.GetExtraInfo();

            string combinedInfo = animal.ToString() + extraInfo;

            // Split the combined information with newline
            string[] lines = combinedInfo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Add each line separately to listBoxAnimalInfo
            foreach (string line in lines)
            {
                listBoxAnimalInfo.Items.Add(line);
            }

            // Clear the existing items in the listbox
            listBoxFoodSchedule.Items.Clear();

            // Get the food schedule of the selected animal
            var foodSchedule = animal.GetFoodSchedule();

            // Display the food schedule in the listBoxFoodSchedule
            foreach (var food in foodSchedule.GetFoodListInfo())
            {
                listBoxFoodSchedule.Items.Add(food);
            }
        }

        private void listBoxAnimalInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxFoodSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Button to initiate the fooditem form
        private void btnFoodItems_Click(object sender, EventArgs e)
        {
            FoodItemForm foodItemForm = new FoodItemForm();
            if (foodItemForm.ShowDialog() == DialogResult.OK)
            {
                string foodItemName = foodItemForm.GetFoodItemName();

                List<string> foodItemIngredients = foodItemForm.GetFoodItemIngredients();

                foreach (string ingredient in foodItemIngredients)
                {
                    string displayText = foodItemName + ": " + ingredient;
                    listBoxFoodItems.Items.Add(displayText);
                }
            }

        }

        private void listBoxFoodItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Delete button to remove animal from the list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxAllAnimals.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Animal selectedAnimal = manager.GetAt(selectedIndex);

                manager.RemoveItem(selectedAnimal);

                listBoxAllAnimals.Items.RemoveAt(selectedIndex);

                listBoxAnimalInfo.Items.Clear();

                listBoxFoodSchedule.Items.Clear();
            }
        }

        // Button to change animal information
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxAllAnimals.SelectedIndex;
            if (selectedIndex >= 0)
            {
                Animal selectedAnimal = manager.GetAt(selectedIndex);

                // Read user input to change animal info
                Animal updatedAnimal = ReadInput();

                if (updatedAnimal != null)
                {
                    // Update GUI
                    manager.Update(selectedIndex, updatedAnimal);

                    listBoxAllAnimals.Items[selectedIndex] = $"{updatedAnimal.ID}, {updatedAnimal.Name}, {updatedAnimal.Age}, {updatedAnimal.Gender}";
                    UpdateSelectedAnimalInfo(updatedAnimal);
                }
            }
        }

        // Updates the information in the listbox
        private void UpdateSelectedAnimalInfo(Animal animal)
        {
            listBoxAnimalInfo.Items.Clear();
            string extraInfo = animal.GetExtraInfo();
            string combinedInfo = animal.ToString() + extraInfo;
            string[] lines = combinedInfo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                listBoxAnimalInfo.Items.Add(line);
            }

            listBoxFoodSchedule.Items.Clear();

            var foodSchedule = animal.GetFoodSchedule();

            foreach (var food in foodSchedule.GetFoodListInfo())
            {
                listBoxFoodSchedule.Items.Add(food);
            }
        }

        private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllData();
            MessageBox.Show("New document created.");

        }

        // Method to clear all data
        private void ClearAllData()
        {
            animals.Clear();

            listBoxAllAnimals.Items.Clear();
            listBoxAnimalInfo.Items.Clear();
            listBoxFoodSchedule.Items.Clear();

            textName.Text = "";
            textAge.Text = "";
            comboBoxGender.SelectedIndex = 0;
            checkBoxDomesticated.Checked = false;

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save As";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        if (Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                        {
                            listManagerInstance.SaveAsTextFile(filePath); 
                        }
                        else if (Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase))
                        {
                            listManagerInstance.SaveAsJsonFile(filePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

 
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save As";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        if (Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                        {

                            listManagerInstance.SaveAsTextFile(filePath);
                        }
                        else if (Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase))
                        {
                            listManagerInstance.SaveAsJsonFile(filePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

  
        private void exitAltXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exiting the application.");
            Application.Exit();
        }

        // Method to open files from the library
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            openFileDialog1.Title = "Open File";
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ShowDialog();


        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;

            try
            {
                if (Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    string fileContents;
                    using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        fileContents = reader.ReadToEnd();
                    }
                    MessageBox.Show("Text file opened successfully!");

                    DisplayFileContentsForm displayForm = new DisplayFileContentsForm();
                    displayForm.DisplayFileContents(fileContents); 
                    displayForm.ShowDialog(); 
                }
                else if (Path.GetExtension(filePath).Equals(".json", StringComparison.OrdinalIgnoreCase))
                {
                    string json;
                    using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        json = reader.ReadToEnd();
                    }
                    MessageBox.Show("JSON file opened successfully!");

                    DisplayFileContentsForm displayForm = new DisplayFileContentsForm(); 
                    displayForm.DisplayFileContents(json);
                    displayForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unsupported file type.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


    }
}