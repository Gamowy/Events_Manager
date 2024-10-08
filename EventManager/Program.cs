using EventManager.Presenters;
using EventManager.Repositories;
using EventManager.Views;

namespace EventManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IEventView eventView = new EventView();
            EventRepository eventRepository = EventRepository.getInstance();
            new EventPresenter(eventView, eventRepository);
            Application.Run((Form)eventView);
        }
    }
}