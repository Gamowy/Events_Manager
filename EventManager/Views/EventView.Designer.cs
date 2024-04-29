namespace EventManager.Views
{
    partial class EventView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventView));
            eventDetails = new GroupBox();
            evPriorityComboBox = new ComboBox();
            priorityLabel = new Label();
            evTypeComboBox = new ComboBox();
            deleteButton = new Button();
            evTypeLabel = new Label();
            addButton = new Button();
            dateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            descLabel = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new RichTextBox();
            titleLabel = new Label();
            sortLabel = new Label();
            sortByComboBox = new ComboBox();
            sortTypeComboBox = new ComboBox();
            topMenu = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripMenuItem();
            clearFormToolStripMenuItem = new ToolStripMenuItem();
            deleteDataToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            eventDataGrid = new DataGridView();
            errorProvider = new ErrorProvider(components);
            showGroupBox = new GroupBox();
            showLowCheckBox = new CheckBox();
            showNormalCheckBox = new CheckBox();
            showHighCheckBox = new CheckBox();
            priorLabel = new Label();
            showSportCheckBox = new CheckBox();
            showHealthCheckBox = new CheckBox();
            showEntertaimentCheckBox = new CheckBox();
            showFamilyCheckBox = new CheckBox();
            showWorkCheckBox = new CheckBox();
            showTypeLabel = new Label();
            eventDetails.SuspendLayout();
            topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            showGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // eventDetails
            // 
            eventDetails.Controls.Add(evPriorityComboBox);
            eventDetails.Controls.Add(priorityLabel);
            eventDetails.Controls.Add(evTypeComboBox);
            eventDetails.Controls.Add(deleteButton);
            eventDetails.Controls.Add(evTypeLabel);
            eventDetails.Controls.Add(addButton);
            eventDetails.Controls.Add(dateTimePicker);
            eventDetails.Controls.Add(dateLabel);
            eventDetails.Controls.Add(descLabel);
            eventDetails.Controls.Add(titleTextBox);
            eventDetails.Controls.Add(descriptionTextBox);
            eventDetails.Controls.Add(titleLabel);
            eventDetails.Location = new Point(12, 44);
            eventDetails.Name = "eventDetails";
            eventDetails.Size = new Size(352, 510);
            eventDetails.TabIndex = 1;
            eventDetails.TabStop = false;
            eventDetails.Text = "Event";
            // 
            // evPriorityComboBox
            // 
            evPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            evPriorityComboBox.FormattingEnabled = true;
            evPriorityComboBox.Items.AddRange(new object[] { "High", "Normal", "Low" });
            evPriorityComboBox.Location = new Point(6, 366);
            evPriorityComboBox.Name = "evPriorityComboBox";
            evPriorityComboBox.Size = new Size(324, 31);
            evPriorityComboBox.TabIndex = 9;
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(6, 340);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(111, 23);
            priorityLabel.TabIndex = 8;
            priorityLabel.Text = "Event priority";
            // 
            // evTypeComboBox
            // 
            evTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            evTypeComboBox.FormattingEnabled = true;
            evTypeComboBox.Items.AddRange(new object[] { "Work", "Family", "Entertaiment", "Health", "Sport" });
            evTypeComboBox.Location = new Point(6, 306);
            evTypeComboBox.Name = "evTypeComboBox";
            evTypeComboBox.Size = new Size(324, 31);
            evTypeComboBox.TabIndex = 7;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(190, 448);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(162, 56);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete event";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // evTypeLabel
            // 
            evTypeLabel.AutoSize = true;
            evTypeLabel.Location = new Point(6, 280);
            evTypeLabel.Name = "evTypeLabel";
            evTypeLabel.Size = new Size(90, 23);
            evTypeLabel.TabIndex = 6;
            evTypeLabel.Text = "Event type";
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 448);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 56);
            addButton.TabIndex = 2;
            addButton.Text = "Add event";
            addButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(6, 247);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(324, 30);
            dateTimePicker.TabIndex = 5;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(6, 221);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(46, 23);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(6, 95);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(96, 23);
            descLabel.TabIndex = 2;
            descLabel.Text = "Description";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(6, 62);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(324, 30);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(6, 121);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(324, 87);
            descriptionTextBox.TabIndex = 3;
            descriptionTextBox.Text = "";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(6, 36);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(388, 44);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(68, 23);
            sortLabel.TabIndex = 4;
            sortLabel.Text = "Sort by:";
            // 
            // sortByComboBox
            // 
            sortByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortByComboBox.FormattingEnabled = true;
            sortByComboBox.Items.AddRange(new object[] { "Date", "Priority", "Type" });
            sortByComboBox.Location = new Point(454, 41);
            sortByComboBox.Name = "sortByComboBox";
            sortByComboBox.Size = new Size(149, 31);
            sortByComboBox.TabIndex = 5;
            // 
            // sortTypeComboBox
            // 
            sortTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortTypeComboBox.FormattingEnabled = true;
            sortTypeComboBox.Items.AddRange(new object[] { "Ascending", "Descending" });
            sortTypeComboBox.Location = new Point(609, 41);
            sortTypeComboBox.Name = "sortTypeComboBox";
            sortTypeComboBox.Size = new Size(149, 31);
            sortTypeComboBox.TabIndex = 6;
            // 
            // topMenu
            // 
            topMenu.ImageScalingSize = new Size(22, 22);
            topMenu.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edytujToolStripMenuItem, pomocToolStripMenuItem });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.Size = new Size(1376, 31);
            topMenu.TabIndex = 7;
            topMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileToolStripMenuItem, loadFileToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(51, 27);
            plikToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(168, 30);
            saveFileToolStripMenuItem.Text = "Save file";
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(168, 30);
            loadFileToolStripMenuItem.Text = "Load file";
            // 
            // edytujToolStripMenuItem
            // 
            edytujToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearFormToolStripMenuItem, deleteDataToolStripMenuItem });
            edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            edytujToolStripMenuItem.Size = new Size(55, 27);
            edytujToolStripMenuItem.Text = "Edit";
            // 
            // clearFormToolStripMenuItem
            // 
            clearFormToolStripMenuItem.Name = "clearFormToolStripMenuItem";
            clearFormToolStripMenuItem.Size = new Size(192, 30);
            clearFormToolStripMenuItem.Text = "Clear form";
            // 
            // deleteDataToolStripMenuItem
            // 
            deleteDataToolStripMenuItem.Name = "deleteDataToolStripMenuItem";
            deleteDataToolStripMenuItem.Size = new Size(192, 30);
            deleteDataToolStripMenuItem.Text = "Delete data";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(61, 27);
            pomocToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(151, 30);
            aboutToolStripMenuItem.Text = "About";
            // 
            // eventDataGrid
            // 
            eventDataGrid.AllowUserToAddRows = false;
            eventDataGrid.AllowUserToDeleteRows = false;
            eventDataGrid.AllowUserToResizeColumns = false;
            eventDataGrid.AllowUserToResizeRows = false;
            eventDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            eventDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventDataGrid.Location = new Point(388, 78);
            eventDataGrid.Name = "eventDataGrid";
            eventDataGrid.RowHeadersWidth = 57;
            eventDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            eventDataGrid.Size = new Size(776, 482);
            eventDataGrid.TabIndex = 8;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // showGroupBox
            // 
            showGroupBox.Controls.Add(showLowCheckBox);
            showGroupBox.Controls.Add(showNormalCheckBox);
            showGroupBox.Controls.Add(showHighCheckBox);
            showGroupBox.Controls.Add(priorLabel);
            showGroupBox.Controls.Add(showSportCheckBox);
            showGroupBox.Controls.Add(showHealthCheckBox);
            showGroupBox.Controls.Add(showEntertaimentCheckBox);
            showGroupBox.Controls.Add(showFamilyCheckBox);
            showGroupBox.Controls.Add(showWorkCheckBox);
            showGroupBox.Controls.Add(showTypeLabel);
            showGroupBox.Location = new Point(1185, 44);
            showGroupBox.Name = "showGroupBox";
            showGroupBox.Size = new Size(164, 518);
            showGroupBox.TabIndex = 9;
            showGroupBox.TabStop = false;
            showGroupBox.Text = "Show";
            // 
            // showLowCheckBox
            // 
            showLowCheckBox.AutoSize = true;
            showLowCheckBox.Checked = true;
            showLowCheckBox.CheckState = CheckState.Checked;
            showLowCheckBox.Location = new Point(7, 306);
            showLowCheckBox.Name = "showLowCheckBox";
            showLowCheckBox.Size = new Size(62, 27);
            showLowCheckBox.TabIndex = 9;
            showLowCheckBox.Text = "Low";
            showLowCheckBox.UseVisualStyleBackColor = true;
            // 
            // showNormalCheckBox
            // 
            showNormalCheckBox.AutoSize = true;
            showNormalCheckBox.Checked = true;
            showNormalCheckBox.CheckState = CheckState.Checked;
            showNormalCheckBox.Location = new Point(7, 276);
            showNormalCheckBox.Name = "showNormalCheckBox";
            showNormalCheckBox.Size = new Size(89, 27);
            showNormalCheckBox.TabIndex = 8;
            showNormalCheckBox.Text = "Normal";
            showNormalCheckBox.UseVisualStyleBackColor = true;
            // 
            // showHighCheckBox
            // 
            showHighCheckBox.AutoSize = true;
            showHighCheckBox.Checked = true;
            showHighCheckBox.CheckState = CheckState.Checked;
            showHighCheckBox.Location = new Point(7, 247);
            showHighCheckBox.Name = "showHighCheckBox";
            showHighCheckBox.Size = new Size(68, 27);
            showHighCheckBox.TabIndex = 7;
            showHighCheckBox.Text = "High";
            showHighCheckBox.UseVisualStyleBackColor = true;
            // 
            // priorLabel
            // 
            priorLabel.AutoSize = true;
            priorLabel.Location = new Point(7, 221);
            priorLabel.Name = "priorLabel";
            priorLabel.Size = new Size(64, 23);
            priorLabel.TabIndex = 6;
            priorLabel.Text = "Priority";
            // 
            // showSportCheckBox
            // 
            showSportCheckBox.AutoSize = true;
            showSportCheckBox.Checked = true;
            showSportCheckBox.CheckState = CheckState.Checked;
            showSportCheckBox.Location = new Point(7, 187);
            showSportCheckBox.Name = "showSportCheckBox";
            showSportCheckBox.Size = new Size(73, 27);
            showSportCheckBox.TabIndex = 5;
            showSportCheckBox.Text = "Sport";
            showSportCheckBox.UseVisualStyleBackColor = true;
            // 
            // showHealthCheckBox
            // 
            showHealthCheckBox.AutoSize = true;
            showHealthCheckBox.Checked = true;
            showHealthCheckBox.CheckState = CheckState.Checked;
            showHealthCheckBox.Location = new Point(7, 154);
            showHealthCheckBox.Name = "showHealthCheckBox";
            showHealthCheckBox.Size = new Size(82, 27);
            showHealthCheckBox.TabIndex = 4;
            showHealthCheckBox.Text = "Health";
            showHealthCheckBox.UseVisualStyleBackColor = true;
            // 
            // showEntertaimentCheckBox
            // 
            showEntertaimentCheckBox.AutoSize = true;
            showEntertaimentCheckBox.Checked = true;
            showEntertaimentCheckBox.CheckState = CheckState.Checked;
            showEntertaimentCheckBox.Location = new Point(7, 121);
            showEntertaimentCheckBox.Name = "showEntertaimentCheckBox";
            showEntertaimentCheckBox.Size = new Size(131, 27);
            showEntertaimentCheckBox.TabIndex = 3;
            showEntertaimentCheckBox.Text = "Entertaiment";
            showEntertaimentCheckBox.UseVisualStyleBackColor = true;
            // 
            // showFamilyCheckBox
            // 
            showFamilyCheckBox.AutoSize = true;
            showFamilyCheckBox.Checked = true;
            showFamilyCheckBox.CheckState = CheckState.Checked;
            showFamilyCheckBox.Location = new Point(7, 91);
            showFamilyCheckBox.Name = "showFamilyCheckBox";
            showFamilyCheckBox.Size = new Size(79, 27);
            showFamilyCheckBox.TabIndex = 2;
            showFamilyCheckBox.Text = "Family";
            showFamilyCheckBox.UseVisualStyleBackColor = true;
            // 
            // showWorkCheckBox
            // 
            showWorkCheckBox.AutoSize = true;
            showWorkCheckBox.Checked = true;
            showWorkCheckBox.CheckState = CheckState.Checked;
            showWorkCheckBox.Location = new Point(7, 62);
            showWorkCheckBox.Name = "showWorkCheckBox";
            showWorkCheckBox.Size = new Size(71, 27);
            showWorkCheckBox.TabIndex = 1;
            showWorkCheckBox.Text = "Work";
            showWorkCheckBox.UseVisualStyleBackColor = true;
            // 
            // showTypeLabel
            // 
            showTypeLabel.AutoSize = true;
            showTypeLabel.Location = new Point(7, 36);
            showTypeLabel.Name = "showTypeLabel";
            showTypeLabel.Size = new Size(45, 23);
            showTypeLabel.TabIndex = 0;
            showTypeLabel.Text = "Type";
            // 
            // EventView
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1376, 574);
            Controls.Add(showGroupBox);
            Controls.Add(eventDataGrid);
            Controls.Add(sortTypeComboBox);
            Controls.Add(sortByComboBox);
            Controls.Add(sortLabel);
            Controls.Add(eventDetails);
            Controls.Add(topMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = topMenu;
            MaximizeBox = false;
            MaximumSize = new Size(1400, 630);
            Name = "EventView";
            Text = "Events manager";
            eventDetails.ResumeLayout(false);
            eventDetails.PerformLayout();
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            showGroupBox.ResumeLayout(false);
            showGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox eventDetails;
        private Button addButton;
        private Button deleteButton;
        private Label sortLabel;
        private ComboBox sortByComboBox;
        private ComboBox sortTypeComboBox;
        private Label titleLabel;
        private TextBox titleTextBox;
        private Label descLabel;
        private RichTextBox descriptionTextBox;
        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Label priorityLabel;
        private ComboBox evTypeComboBox;
        private Label evTypeLabel;
        private MenuStrip topMenu;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem clearFormToolStripMenuItem;
        private ToolStripMenuItem deleteDataToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ComboBox evPriorityComboBox;
        private DataGridView eventDataGrid;
        private ErrorProvider errorProvider;
        private GroupBox showGroupBox;
        private CheckBox showWorkCheckBox;
        private Label showTypeLabel;
        private CheckBox showFamilyCheckBox;
        private CheckBox showHealthCheckBox;
        private CheckBox showEntertaimentCheckBox;
        private CheckBox showSportCheckBox;
        private Label priorLabel;
        private CheckBox showLowCheckBox;
        private CheckBox showNormalCheckBox;
        private CheckBox showHighCheckBox;
    }
}
