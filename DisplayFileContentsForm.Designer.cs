namespace VT24Assignment1
{
    partial class DisplayFileContentsForm
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
            listBoxDisplay = new ListBox();
            SuspendLayout();
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.ItemHeight = 32;
            listBoxDisplay.Location = new Point(19, 19);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(1151, 1156);
            listBoxDisplay.TabIndex = 0;
            listBoxDisplay.SelectedIndexChanged += listBoxDisplay_SelectedIndexChanged;
            // 
            // DisplayFileContentsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 1187);
            Controls.Add(listBoxDisplay);
            Name = "DisplayFileContentsForm";
            Text = "DisplayFileContentsForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxDisplay;
    }
}