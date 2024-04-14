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
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            wczytajToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripMenuItem();
            wyczyśćFormularzToolStripMenuItem = new ToolStripMenuItem();
            usuńDaneToolStripMenuItem = new ToolStripMenuItem();
            zmieńJęzymToolStripMenuItem = new ToolStripMenuItem();
            polskiToolStripMenuItem = new ToolStripMenuItem();
            angielskiToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            eventDataGrid = new DataGridView();
            eventDetails.SuspendLayout();
            topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDataGrid).BeginInit();
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
            eventDetails.Text = "Wydarzenie";
            // 
            // evPriorityComboBox
            // 
            evPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            evPriorityComboBox.FormattingEnabled = true;
            evPriorityComboBox.Items.AddRange(new object[] { "Wysoki", "Standardowy", "Niski" });
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
            priorityLabel.Size = new Size(75, 23);
            priorityLabel.TabIndex = 8;
            priorityLabel.Text = "Priorytet";
            // 
            // evTypeComboBox
            // 
            evTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            evTypeComboBox.FormattingEnabled = true;
            evTypeComboBox.Items.AddRange(new object[] { "Praca", "Rodzina", "Rozrywka", "Zdrowie", "Sport" });
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
            deleteButton.Text = "Usuń";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // evTypeLabel
            // 
            evTypeLabel.AutoSize = true;
            evTypeLabel.Location = new Point(6, 280);
            evTypeLabel.Name = "evTypeLabel";
            evTypeLabel.Size = new Size(126, 23);
            evTypeLabel.TabIndex = 6;
            evTypeLabel.Text = "Typ wydarzenia";
            // 
            // addButton
            // 
            addButton.Location = new Point(6, 448);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 56);
            addButton.TabIndex = 2;
            addButton.Text = "Dodaj";
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
            dateLabel.Text = "Data";
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new Point(6, 95);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(44, 23);
            descLabel.TabIndex = 2;
            descLabel.Text = "Opis";
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
            titleLabel.Size = new Size(47, 23);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Tytuł";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(392, 44);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(120, 23);
            sortLabel.TabIndex = 4;
            sortLabel.Text = "Sortuj według:";
            // 
            // sortByComboBox
            // 
            sortByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortByComboBox.FormattingEnabled = true;
            sortByComboBox.Items.AddRange(new object[] { "Daty", "Priorytetu", "Typu" });
            sortByComboBox.Location = new Point(518, 41);
            sortByComboBox.Name = "sortByComboBox";
            sortByComboBox.Size = new Size(149, 31);
            sortByComboBox.TabIndex = 5;
            // 
            // sortTypeComboBox
            // 
            sortTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortTypeComboBox.FormattingEnabled = true;
            sortTypeComboBox.Items.AddRange(new object[] { "Rosnąco", "Malejąco" });
            sortTypeComboBox.Location = new Point(673, 41);
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
            topMenu.Size = new Size(876, 31);
            topMenu.TabIndex = 7;
            topMenu.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem, wczytajToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(52, 27);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(162, 30);
            zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // wczytajToolStripMenuItem
            // 
            wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            wczytajToolStripMenuItem.Size = new Size(162, 30);
            wczytajToolStripMenuItem.Text = "Wczytaj";
            // 
            // edytujToolStripMenuItem
            // 
            edytujToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wyczyśćFormularzToolStripMenuItem, usuńDaneToolStripMenuItem, zmieńJęzymToolStripMenuItem });
            edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            edytujToolStripMenuItem.Size = new Size(73, 27);
            edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // wyczyśćFormularzToolStripMenuItem
            // 
            wyczyśćFormularzToolStripMenuItem.Name = "wyczyśćFormularzToolStripMenuItem";
            wyczyśćFormularzToolStripMenuItem.Size = new Size(245, 30);
            wyczyśćFormularzToolStripMenuItem.Text = "Wyczyść formularz";
            // 
            // usuńDaneToolStripMenuItem
            // 
            usuńDaneToolStripMenuItem.Name = "usuńDaneToolStripMenuItem";
            usuńDaneToolStripMenuItem.Size = new Size(245, 30);
            usuńDaneToolStripMenuItem.Text = "Usuń dane";
            // 
            // zmieńJęzymToolStripMenuItem
            // 
            zmieńJęzymToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { polskiToolStripMenuItem, angielskiToolStripMenuItem });
            zmieńJęzymToolStripMenuItem.Name = "zmieńJęzymToolStripMenuItem";
            zmieńJęzymToolStripMenuItem.Size = new Size(245, 30);
            zmieńJęzymToolStripMenuItem.Text = "Zmień język";
            // 
            // polskiToolStripMenuItem
            // 
            polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            polskiToolStripMenuItem.Size = new Size(171, 30);
            polskiToolStripMenuItem.Text = "Polski";
            // 
            // angielskiToolStripMenuItem
            // 
            angielskiToolStripMenuItem.Name = "angielskiToolStripMenuItem";
            angielskiToolStripMenuItem.Size = new Size(171, 30);
            angielskiToolStripMenuItem.Text = "Angielski";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oProgramieToolStripMenuItem });
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(78, 27);
            pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(201, 30);
            oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // eventDataGrid
            // 
            eventDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventDataGrid.Location = new Point(392, 78);
            eventDataGrid.Name = "eventDataGrid";
            eventDataGrid.RowHeadersWidth = 57;
            eventDataGrid.Size = new Size(472, 482);
            eventDataGrid.TabIndex = 8;
            // 
            // EventView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 574);
            Controls.Add(eventDataGrid);
            Controls.Add(sortTypeComboBox);
            Controls.Add(sortByComboBox);
            Controls.Add(sortLabel);
            Controls.Add(eventDetails);
            Controls.Add(topMenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = topMenu;
            MaximizeBox = false;
            MaximumSize = new Size(900, 630);
            Name = "EventView";
            Text = "Administrator wydarzeń";
            eventDetails.ResumeLayout(false);
            eventDetails.PerformLayout();
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventDataGrid).EndInit();
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
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem wczytajToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem wyczyśćFormularzToolStripMenuItem;
        private ToolStripMenuItem usuńDaneToolStripMenuItem;
        private ToolStripMenuItem zmieńJęzymToolStripMenuItem;
        private ToolStripMenuItem polskiToolStripMenuItem;
        private ToolStripMenuItem angielskiToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ComboBox evPriorityComboBox;
        private DataGridView eventDataGrid;
    }
}
