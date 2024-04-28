﻿using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;

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
        public event EventHandler? RemoveAllEvent;
        public event EventHandler? SaveFileEvent;
        public event EventHandler? LoadFileEvent;

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
                RemoveAllEvent?.Invoke(this, EventArgs.Empty);
            };
            saveFileToolStripMenuItem.Click += (sender, e) =>
            {
                SaveFileEvent?.Invoke(this, EventArgs.Empty);
            };
            loadFileToolStripMenuItem.Click += (sender, e) =>
            {
                LoadFileEvent?.Invoke(this, EventArgs.Empty);
            };
            eventDataGrid.SelectionChanged += _displaySelectedEvent;
            clearFormToolStripMenuItem.Click += _clearFormEvent;
            aboutToolStripMenuItem.Click += _displayAbout;
            sortByComboBox.SelectionChangeCommitted += sortEventList;
            sortTypeComboBox.SelectionChangeCommitted += sortEventList;
        }

        private void _displaySelectedEvent(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in eventDataGrid.SelectedRows)
            {
                if (row.Cells[0].Value.ToString() != "")
                {
                    Title = row.Cells[0].Value.ToString() ?? "Event";
                    Description = row.Cells[1].Value.ToString();
                    EventDate = (DateTime)row.Cells[2].Value;
                    EventType = row.Cells[3].Value.ToString();
                    EventPriority = row.Cells[4].Value.ToString();
                }
            }
        }

        private void _clearFormEvent(object? sender, EventArgs e)
        {
            clearForm();
        }

        private void _displayAbout(object? sender, EventArgs e)
        {
            MessageBox.Show("Administrator wydarzeń\nAutor: Patryk Gamrat", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sortEventList(Object? sender, EventArgs e)
        {
            string sortBy = sortByComboBox.Text;
            var sortType = sortTypeComboBox.Text.Equals("Ascending") ? ListSortDirection.Ascending : ListSortDirection.Descending;
            switch (sortBy)
            {
                case "Date":
                    eventDataGrid.Sort(eventDataGrid.Columns["Date"], sortType);
                    break;
                case "Priority":
                    eventDataGrid.Sort(eventDataGrid.Columns["Priority"], sortType);
                    break;
                case "Type":
                    eventDataGrid.Sort(eventDataGrid.Columns["Type"], sortType);
                    break;
            }
            colorizeEventList();
        }

        public void clearForm()
        {
            Title = "";
            Description = "";
            EventDate = DateTime.Now;
            EventType = "Work";
            EventPriority = "Normal";
        }

        public void colorizeEventList()
        { 
            foreach (DataGridViewRow row in eventDataGrid.Rows)
            {
                switch (row.Cells[3].Value.ToString())
                {
                    case "Work":
                        row.DefaultCellStyle.BackColor = Color.Blue;
                        break;
                    case "Family":
                        row.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    case "Entertaiment":
                        row.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case "Health":
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case "Sport":
                        row.DefaultCellStyle.BackColor = Color.Purple;
                        break;
                }
            }
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
