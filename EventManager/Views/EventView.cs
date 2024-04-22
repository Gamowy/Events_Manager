﻿using System.Windows.Forms;

namespace EventManager.Views
{
    public partial class EventView : Form, IEventView
    {
        public EventView()
        {
            InitializeComponent();
            assignEvents();
        }

        // Properties
        public string Title { get => titleTextBox.Text; set => titleTextBox.Text = value; }
        public string? Description { get => descriptionTextBox.Text; set => descriptionTextBox.Text = value; }
        public DateTime EventDate { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public string? EventType
        {
            get => evTypeComboBox.Text;
            set
            {
                int index = evTypeComboBox.FindStringExact(value);
                if (index != -1)
                    evTypeComboBox.SelectedIndex = index;
            }
        }
        public string? EventPriority
        {
            get => evPriorityComboBox.Text;
            set
            {
                int index = evPriorityComboBox.FindStringExact(value);
                if (index != -1)
                    evPriorityComboBox.SelectedIndex = index;
            }
        }

        // Events
        public event EventHandler? AddNewEvent;
        public event EventHandler? RemoveEvent;
        public event EventHandler? ClearFormEvent;
        public event EventHandler? RemoveAllEvents;

        // Methods
        private void assignEvents()
        {
            addButton.Click += (sender, e) =>
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
            };
            deleteButton.Click += (sender, e) =>
            {
                RemoveEvent?.Invoke(this, EventArgs.Empty);
            };
            deleteDataToolStripMenuItem.Click += (sender, e) =>
            {
                RemoveAllEvents?.Invoke(this, EventArgs.Empty);
            };
            eventDataGrid.SelectionChanged += _displaySelectedEvent;
            clearFormToolStripMenuItem.Click += _clearFormEvent;
        }

        private void _displaySelectedEvent(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in eventDataGrid.SelectedRows)
            {
                Title = row.Cells[0].Value.ToString() ?? "Event";
                Description = row.Cells[1].Value.ToString();
                EventDate = (DateTime)row.Cells[2].Value;
                EventType = row.Cells[3].Value.ToString();
                EventPriority = row.Cells[4].Value.ToString();
            }
        }

        private void _clearFormEvent(object? sender, EventArgs e)
        {
            clearForm();
        }

        public void clearForm()
        {
            Title = "";
            Description = "";
            EventDate = DateTime.Now;
            EventType = "Work";
            EventPriority = "Normal";
        }   

        public bool titleTextBoxNotEmpty()
        {
            if (titleTextBox.Text == "")
            {
                errorProvider.SetError(titleTextBox, "Puste pole!");
                return false;
            }
            else
            {
                errorProvider.SetError(titleTextBox, "");
                return true;
            }
        }

        public void setEventListSource(BindingSource eventList)
        {
            eventDataGrid.DataSource = eventList;
        }
    }
}
