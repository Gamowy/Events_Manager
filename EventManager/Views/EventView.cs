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
        public string Description { get => descriptionTextBox.Text; set => descriptionTextBox.Text = value; }
        public DateTime EventDate { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public string EventType
        {
            get => evTypeComboBox.Text;
            set
            {
                int index = evTypeComboBox.FindStringExact(value);
                if (index != -1)
                    evTypeComboBox.SelectedIndex = index;
            }
        }
        public string EventPriority
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
        }

        public void setEventListSource(BindingSource eventList)
        {
            eventDataGrid.DataSource = eventList;
        }
    }
}
