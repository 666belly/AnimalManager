namespace VT24Assignment1
{
    partial class EcoZoo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBoxDomesticated = new CheckBox();
            textName = new TextBox();
            textAge = new TextBox();
            comboBoxGender = new ComboBox();
            listBoxCategory = new ListBox();
            listBoxSpecies = new ListBox();
            buttonAdd = new Button();
            groupMammalSpecifications = new GroupBox();
            textLenghtOfTail = new TextBox();
            textNumberOfTeeth = new TextBox();
            label10 = new Label();
            label9 = new Label();
            groupBirdSpecifications = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            textLengthOfBeak = new TextBox();
            textWingspan = new TextBox();
            groupMarineSpecifications = new GroupBox();
            checkBoxIsDangerous = new CheckBox();
            textLenghtOfFish = new TextBox();
            label16 = new Label();
            label15 = new Label();
            groupReptileSpecification = new GroupBox();
            textWeight = new TextBox();
            checkLivesInWater = new CheckBox();
            label18 = new Label();
            label17 = new Label();
            groupInsectSpecification = new GroupBox();
            checkHasWings = new CheckBox();
            label19 = new Label();
            groupCatSpecifications = new GroupBox();
            textCuteness = new TextBox();
            label11 = new Label();
            groupDogSpecifications = new GroupBox();
            textBreed = new TextBox();
            label12 = new Label();
            lblExtraInfo = new Label();
            groupBoxAnimalSpecification = new GroupBox();
            groupBox1 = new GroupBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label8 = new Label();
            lblEaterType = new Label();
            label1 = new Label();
            listBoxFoodSchedule = new ListBox();
            listBoxAllAnimals = new ListBox();
            listBoxAnimalInfo = new ListBox();
            btnFoodItems = new Button();
            listBoxFoodItems = new ListBox();
            btnDelete = new Button();
            btnChange = new Button();
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            exitAltXToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupMammalSpecifications.SuspendLayout();
            groupBirdSpecifications.SuspendLayout();
            groupMarineSpecifications.SuspendLayout();
            groupReptileSpecification.SuspendLayout();
            groupInsectSpecification.SuspendLayout();
            groupCatSpecifications.SuspendLayout();
            groupDogSpecifications.SuspendLayout();
            groupBoxAnimalSpecification.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(161, 32);
            label5.TabIndex = 4;
            label5.Text = "Domesticated";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 295);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 5;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 295);
            label7.Name = "label7";
            label7.Size = new Size(94, 32);
            label7.TabIndex = 6;
            label7.Text = "Species";
            // 
            // checkBoxDomesticated
            // 
            checkBoxDomesticated.AutoSize = true;
            checkBoxDomesticated.Location = new Point(265, 189);
            checkBoxDomesticated.Name = "checkBoxDomesticated";
            checkBoxDomesticated.Size = new Size(28, 27);
            checkBoxDomesticated.TabIndex = 7;
            checkBoxDomesticated.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            textName.Location = new Point(190, 33);
            textName.Name = "textName";
            textName.Size = new Size(290, 39);
            textName.TabIndex = 8;
            textName.TextChanged += textBoxName_TextChanged;
            // 
            // textAge
            // 
            textAge.Location = new Point(190, 79);
            textAge.Name = "textAge";
            textAge.Size = new Size(290, 39);
            textAge.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(190, 129);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(290, 40);
            comboBoxGender.TabIndex = 10;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // listBoxCategory
            // 
            listBoxCategory.FormattingEnabled = true;
            listBoxCategory.ItemHeight = 32;
            listBoxCategory.Location = new Point(10, 340);
            listBoxCategory.Name = "listBoxCategory";
            listBoxCategory.Size = new Size(249, 292);
            listBoxCategory.TabIndex = 11;
            listBoxCategory.SelectedIndexChanged += listBoxCategory_SelectedIndexChanged;
            // 
            // listBoxSpecies
            // 
            listBoxSpecies.FormattingEnabled = true;
            listBoxSpecies.ItemHeight = 32;
            listBoxSpecies.Location = new Point(273, 340);
            listBoxSpecies.Name = "listBoxSpecies";
            listBoxSpecies.Size = new Size(249, 292);
            listBoxSpecies.TabIndex = 12;
            listBoxSpecies.SelectedIndexChanged += listBoxSpecies_SelectedIndexChanged;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(632, 557);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(365, 57);
            buttonAdd.TabIndex = 15;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupMammalSpecifications
            // 
            groupMammalSpecifications.Controls.Add(textLenghtOfTail);
            groupMammalSpecifications.Controls.Add(textNumberOfTeeth);
            groupMammalSpecifications.Controls.Add(label10);
            groupMammalSpecifications.Controls.Add(label9);
            groupMammalSpecifications.Location = new Point(61, 780);
            groupMammalSpecifications.Name = "groupMammalSpecifications";
            groupMammalSpecifications.Size = new Size(470, 181);
            groupMammalSpecifications.TabIndex = 17;
            groupMammalSpecifications.TabStop = false;
            groupMammalSpecifications.Text = "Mammal Specifications";
            groupMammalSpecifications.Enter += groupMammalSpecifications_Enter;
            // 
            // textLenghtOfTail
            // 
            textLenghtOfTail.Location = new Point(235, 125);
            textLenghtOfTail.Name = "textLenghtOfTail";
            textLenghtOfTail.Size = new Size(210, 39);
            textLenghtOfTail.TabIndex = 3;
            // 
            // textNumberOfTeeth
            // 
            textNumberOfTeeth.Location = new Point(235, 68);
            textNumberOfTeeth.Name = "textNumberOfTeeth";
            textNumberOfTeeth.Size = new Size(210, 39);
            textNumberOfTeeth.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 128);
            label10.Name = "label10";
            label10.Size = new Size(156, 32);
            label10.TabIndex = 1;
            label10.Text = "Lenght of tail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 71);
            label9.Name = "label9";
            label9.Size = new Size(194, 32);
            label9.TabIndex = 0;
            label9.Text = "Number of teeth";
            // 
            // groupBirdSpecifications
            // 
            groupBirdSpecifications.Controls.Add(label14);
            groupBirdSpecifications.Controls.Add(label13);
            groupBirdSpecifications.Controls.Add(textLengthOfBeak);
            groupBirdSpecifications.Controls.Add(textWingspan);
            groupBirdSpecifications.Location = new Point(55, 1064);
            groupBirdSpecifications.Name = "groupBirdSpecifications";
            groupBirdSpecifications.Size = new Size(469, 202);
            groupBirdSpecifications.TabIndex = 18;
            groupBirdSpecifications.TabStop = false;
            groupBirdSpecifications.Text = "Bird specifications";
            groupBirdSpecifications.Enter += groupBirdSpecifications_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 144);
            label14.Name = "label14";
            label14.Size = new Size(175, 32);
            label14.TabIndex = 3;
            label14.Text = "Lenght of beak";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 72);
            label13.Name = "label13";
            label13.Size = new Size(120, 32);
            label13.TabIndex = 2;
            label13.Text = "Wingspan";
            // 
            // textLengthOfBeak
            // 
            textLengthOfBeak.Location = new Point(227, 141);
            textLengthOfBeak.Name = "textLengthOfBeak";
            textLengthOfBeak.Size = new Size(210, 39);
            textLengthOfBeak.TabIndex = 1;
            // 
            // textWingspan
            // 
            textWingspan.Location = new Point(227, 69);
            textWingspan.Name = "textWingspan";
            textWingspan.Size = new Size(210, 39);
            textWingspan.TabIndex = 0;
            // 
            // groupMarineSpecifications
            // 
            groupMarineSpecifications.Controls.Add(checkBoxIsDangerous);
            groupMarineSpecifications.Controls.Add(textLenghtOfFish);
            groupMarineSpecifications.Controls.Add(label16);
            groupMarineSpecifications.Controls.Add(label15);
            groupMarineSpecifications.Location = new Point(575, 1087);
            groupMarineSpecifications.Name = "groupMarineSpecifications";
            groupMarineSpecifications.Size = new Size(443, 158);
            groupMarineSpecifications.TabIndex = 21;
            groupMarineSpecifications.TabStop = false;
            groupMarineSpecifications.Text = "Marine specifications";
            groupMarineSpecifications.Enter += groupMarineSpecifications_Enter;
            // 
            // checkBoxIsDangerous
            // 
            checkBoxIsDangerous.AutoSize = true;
            checkBoxIsDangerous.Location = new Point(207, 99);
            checkBoxIsDangerous.Name = "checkBoxIsDangerous";
            checkBoxIsDangerous.Size = new Size(28, 27);
            checkBoxIsDangerous.TabIndex = 3;
            checkBoxIsDangerous.UseVisualStyleBackColor = true;
            // 
            // textLenghtOfFish
            // 
            textLenghtOfFish.Location = new Point(204, 37);
            textLenghtOfFish.Name = "textLenghtOfFish";
            textLenghtOfFish.Size = new Size(204, 39);
            textLenghtOfFish.TabIndex = 2;
            textLenghtOfFish.TextChanged += textLenghtOfFish_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(26, 95);
            label16.Name = "label16";
            label16.Size = new Size(150, 32);
            label16.TabIndex = 1;
            label16.Text = "Is dangerous";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 44);
            label15.Name = "label15";
            label15.Size = new Size(162, 32);
            label15.TabIndex = 0;
            label15.Text = "Lenght of fish";
            // 
            // groupReptileSpecification
            // 
            groupReptileSpecification.Controls.Add(textWeight);
            groupReptileSpecification.Controls.Add(checkLivesInWater);
            groupReptileSpecification.Controls.Add(label18);
            groupReptileSpecification.Controls.Add(label17);
            groupReptileSpecification.Location = new Point(575, 644);
            groupReptileSpecification.Name = "groupReptileSpecification";
            groupReptileSpecification.Size = new Size(445, 158);
            groupReptileSpecification.TabIndex = 22;
            groupReptileSpecification.TabStop = false;
            groupReptileSpecification.Text = "Reptile specification";
            groupReptileSpecification.Enter += groupReptileSpecification_Enter;
            // 
            // textWeight
            // 
            textWeight.Location = new Point(217, 50);
            textWeight.Name = "textWeight";
            textWeight.Size = new Size(205, 39);
            textWeight.TabIndex = 3;
            // 
            // checkLivesInWater
            // 
            checkLivesInWater.AutoSize = true;
            checkLivesInWater.Location = new Point(226, 113);
            checkLivesInWater.Name = "checkLivesInWater";
            checkLivesInWater.Size = new Size(28, 27);
            checkLivesInWater.TabIndex = 2;
            checkLivesInWater.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 111);
            label18.Name = "label18";
            label18.Size = new Size(158, 32);
            label18.TabIndex = 1;
            label18.Text = "Lives in water";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 55);
            label17.Name = "label17";
            label17.Size = new Size(90, 32);
            label17.TabIndex = 0;
            label17.Text = "Weight";
            // 
            // groupInsectSpecification
            // 
            groupInsectSpecification.Controls.Add(checkHasWings);
            groupInsectSpecification.Controls.Add(label19);
            groupInsectSpecification.Location = new Point(253, 966);
            groupInsectSpecification.Name = "groupInsectSpecification";
            groupInsectSpecification.Size = new Size(292, 102);
            groupInsectSpecification.TabIndex = 23;
            groupInsectSpecification.TabStop = false;
            groupInsectSpecification.Text = "Insect specifcation";
            groupInsectSpecification.Enter += groupInsectSpecification_Enter;
            // 
            // checkHasWings
            // 
            checkHasWings.AutoSize = true;
            checkHasWings.Location = new Point(234, 58);
            checkHasWings.Name = "checkHasWings";
            checkHasWings.Size = new Size(28, 27);
            checkHasWings.TabIndex = 1;
            checkHasWings.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(14, 53);
            label19.Name = "label19";
            label19.Size = new Size(121, 32);
            label19.TabIndex = 0;
            label19.Text = "Has wings";
            // 
            // groupCatSpecifications
            // 
            groupCatSpecifications.Controls.Add(textCuteness);
            groupCatSpecifications.Controls.Add(label11);
            groupCatSpecifications.Location = new Point(575, 808);
            groupCatSpecifications.Name = "groupCatSpecifications";
            groupCatSpecifications.Size = new Size(379, 140);
            groupCatSpecifications.TabIndex = 19;
            groupCatSpecifications.TabStop = false;
            groupCatSpecifications.Text = "Cat specifications";
            groupCatSpecifications.Enter += groupCatSpecifications_Enter;
            // 
            // textCuteness
            // 
            textCuteness.Location = new Point(160, 60);
            textCuteness.Name = "textCuteness";
            textCuteness.Size = new Size(190, 39);
            textCuteness.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 63);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 0;
            label11.Text = "Cuteness";
            // 
            // groupDogSpecifications
            // 
            groupDogSpecifications.Controls.Add(textBreed);
            groupDogSpecifications.Controls.Add(label12);
            groupDogSpecifications.Location = new Point(575, 953);
            groupDogSpecifications.Name = "groupDogSpecifications";
            groupDogSpecifications.Size = new Size(377, 115);
            groupDogSpecifications.TabIndex = 20;
            groupDogSpecifications.TabStop = false;
            groupDogSpecifications.Text = "Dog specifications";
            groupDogSpecifications.Enter += groupDogSpecifications_Enter;
            // 
            // textBreed
            // 
            textBreed.Location = new Point(181, 50);
            textBreed.Name = "textBreed";
            textBreed.Size = new Size(178, 39);
            textBreed.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 57);
            label12.Name = "label12";
            label12.Size = new Size(76, 32);
            label12.TabIndex = 0;
            label12.Text = "Breed";
            // 
            // lblExtraInfo
            // 
            lblExtraInfo.BackColor = SystemColors.ControlLightLight;
            lblExtraInfo.BorderStyle = BorderStyle.FixedSingle;
            lblExtraInfo.Location = new Point(575, 67);
            lblExtraInfo.Name = "lblExtraInfo";
            lblExtraInfo.Size = new Size(476, 487);
            lblExtraInfo.TabIndex = 24;
            lblExtraInfo.Click += lblExtraInfo_Click;
            // 
            // groupBoxAnimalSpecification
            // 
            groupBoxAnimalSpecification.Controls.Add(listBoxSpecies);
            groupBoxAnimalSpecification.Controls.Add(comboBoxGender);
            groupBoxAnimalSpecification.Controls.Add(textAge);
            groupBoxAnimalSpecification.Controls.Add(textName);
            groupBoxAnimalSpecification.Controls.Add(checkBoxDomesticated);
            groupBoxAnimalSpecification.Controls.Add(label7);
            groupBoxAnimalSpecification.Controls.Add(listBoxCategory);
            groupBoxAnimalSpecification.Controls.Add(label6);
            groupBoxAnimalSpecification.Location = new Point(12, 58);
            groupBoxAnimalSpecification.Name = "groupBoxAnimalSpecification";
            groupBoxAnimalSpecification.Size = new Size(543, 716);
            groupBoxAnimalSpecification.TabIndex = 25;
            groupBoxAnimalSpecification.TabStop = false;
            groupBoxAnimalSpecification.Text = "Animal specification";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lblEaterType);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(listBoxFoodSchedule);
            groupBox1.Controls.Add(listBoxAllAnimals);
            groupBox1.Controls.Add(listBoxAnimalInfo);
            groupBox1.Location = new Point(1082, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 1195);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of registered animals";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(512, 373);
            label22.Name = "label22";
            label22.Size = new Size(92, 32);
            label22.TabIndex = 8;
            label22.Text = "Gender";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(380, 374);
            label21.Name = "label21";
            label21.Size = new Size(56, 32);
            label21.TabIndex = 7;
            label21.Text = "Age";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(146, 374);
            label20.Name = "label20";
            label20.Size = new Size(78, 32);
            label20.TabIndex = 6;
            label20.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 374);
            label8.Name = "label8";
            label8.Size = new Size(37, 32);
            label8.TabIndex = 5;
            label8.Text = "ID";
            // 
            // lblEaterType
            // 
            lblEaterType.Location = new Point(364, 813);
            lblEaterType.Name = "lblEaterType";
            lblEaterType.Size = new Size(257, 36);
            lblEaterType.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 813);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 3;
            label1.Text = "Eater type";
            // 
            // listBoxFoodSchedule
            // 
            listBoxFoodSchedule.FormattingEnabled = true;
            listBoxFoodSchedule.ItemHeight = 32;
            listBoxFoodSchedule.Location = new Point(12, 852);
            listBoxFoodSchedule.Name = "listBoxFoodSchedule";
            listBoxFoodSchedule.Size = new Size(649, 324);
            listBoxFoodSchedule.TabIndex = 2;
            listBoxFoodSchedule.SelectedIndexChanged += listBoxFoodSchedule_SelectedIndexChanged;
            // 
            // listBoxAllAnimals
            // 
            listBoxAllAnimals.FormattingEnabled = true;
            listBoxAllAnimals.ItemHeight = 32;
            listBoxAllAnimals.Location = new Point(12, 409);
            listBoxAllAnimals.Name = "listBoxAllAnimals";
            listBoxAllAnimals.Size = new Size(649, 388);
            listBoxAllAnimals.TabIndex = 1;
            listBoxAllAnimals.SelectedIndexChanged += listBoxAllAnimals_SelectedIndexChanged;
            // 
            // listBoxAnimalInfo
            // 
            listBoxAnimalInfo.FormattingEnabled = true;
            listBoxAnimalInfo.ItemHeight = 32;
            listBoxAnimalInfo.Location = new Point(12, 56);
            listBoxAnimalInfo.Name = "listBoxAnimalInfo";
            listBoxAnimalInfo.Size = new Size(649, 292);
            listBoxAnimalInfo.TabIndex = 0;
            listBoxAnimalInfo.SelectedIndexChanged += listBoxAnimalInfo_SelectedIndexChanged;
            // 
            // btnFoodItems
            // 
            btnFoodItems.Location = new Point(674, 1262);
            btnFoodItems.Name = "btnFoodItems";
            btnFoodItems.Size = new Size(377, 51);
            btnFoodItems.TabIndex = 27;
            btnFoodItems.Text = "Food Items";
            btnFoodItems.UseVisualStyleBackColor = true;
            btnFoodItems.Click += btnFoodItems_Click;
            // 
            // listBoxFoodItems
            // 
            listBoxFoodItems.FormattingEnabled = true;
            listBoxFoodItems.ItemHeight = 32;
            listBoxFoodItems.Location = new Point(1088, 1257);
            listBoxFoodItems.Name = "listBoxFoodItems";
            listBoxFoodItems.Size = new Size(665, 292);
            listBoxFoodItems.TabIndex = 28;
            listBoxFoodItems.SelectedIndexChanged += listBoxFoodItems_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(192, 1272);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(204, 43);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(415, 1272);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(205, 43);
            btnChange.TabIndex = 30;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1824, 40);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, exitAltXToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(71, 36);
            fIleToolStripMenuItem.Text = "File";
            fIleToolStripMenuItem.Click += fIleToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(281, 44);
            newToolStripMenuItem.Text = "New Ctr + N";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(281, 44);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(281, 44);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(281, 44);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // exitAltXToolStripMenuItem
            // 
            exitAltXToolStripMenuItem.Name = "exitAltXToolStripMenuItem";
            exitAltXToolStripMenuItem.Size = new Size(281, 44);
            exitAltXToolStripMenuItem.Text = "Exit Alt + X";
            exitAltXToolStripMenuItem.Click += exitAltXToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk_1;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // EcoZoo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1824, 1590);
            Controls.Add(btnChange);
            Controls.Add(btnDelete);
            Controls.Add(listBoxFoodItems);
            Controls.Add(btnFoodItems);
            Controls.Add(groupBox1);
            Controls.Add(lblExtraInfo);
            Controls.Add(groupInsectSpecification);
            Controls.Add(groupReptileSpecification);
            Controls.Add(groupMarineSpecifications);
            Controls.Add(groupCatSpecifications);
            Controls.Add(groupDogSpecifications);
            Controls.Add(groupBirdSpecifications);
            Controls.Add(groupMammalSpecifications);
            Controls.Add(buttonAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBoxAnimalSpecification);
            Controls.Add(menuStrip1);
            Name = "EcoZoo";
            Text = "EcoZoo ";
            groupMammalSpecifications.ResumeLayout(false);
            groupMammalSpecifications.PerformLayout();
            groupBirdSpecifications.ResumeLayout(false);
            groupBirdSpecifications.PerformLayout();
            groupMarineSpecifications.ResumeLayout(false);
            groupMarineSpecifications.PerformLayout();
            groupReptileSpecification.ResumeLayout(false);
            groupReptileSpecification.PerformLayout();
            groupInsectSpecification.ResumeLayout(false);
            groupInsectSpecification.PerformLayout();
            groupCatSpecifications.ResumeLayout(false);
            groupCatSpecifications.PerformLayout();
            groupDogSpecifications.ResumeLayout(false);
            groupDogSpecifications.PerformLayout();
            groupBoxAnimalSpecification.ResumeLayout(false);
            groupBoxAnimalSpecification.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBoxDomesticated;
        private TextBox textName;
        private TextBox textAge;
        private ComboBox comboBoxGender;
        private ListBox listBoxCategory;
        private ListBox listBoxSpecies;
        private Button buttonAdd;
        private GroupBox groupMammalSpecifications;
        private GroupBox groupBirdSpecifications;
        private TextBox textLenghtOfTail;
        private TextBox textNumberOfTeeth;
        private Label label10;
        private Label label9;
        private GroupBox groupCatSpecifications;
        private TextBox textCuteness;
        private Label label11;
        private GroupBox groupDogSpecifications;
        private TextBox textBreed;
        private Label label12;
        private TextBox textWingspan;
        private TextBox textLengthOfBeak;
        private Label label14;
        private Label label13;
        private GroupBox groupMarineSpecifications;
        private CheckBox checkBoxIsDangerous;
        private TextBox textLenghtOfFish;
        private Label label16;
        private Label label15;
        private GroupBox groupReptileSpecification;
        private TextBox textWeight;
        private CheckBox checkLivesInWater;
        private Label label18;
        private Label label17;
        private GroupBox groupInsectSpecification;
        private CheckBox checkHasWings;
        private Label label19;
        private Label lblExtraInfo;
        private GroupBox groupBoxAnimalSpecification;
        private GroupBox groupBox1;
        private ListBox listBoxFoodSchedule;
        private ListBox listBoxAllAnimals;
        private ListBox listBoxAnimalInfo;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label8;
        private Label lblEaterType;
        private Label label1;
        private Button btnFoodItems;
        private ListBox listBoxFoodItems;
        private Button btnDelete;
        private Button btnChange;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitAltXToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}