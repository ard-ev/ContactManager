using System.Linq;
using ContactManager.Data;
using ContactManager.Models;
using ContactManager.Services;
using ContactManager.Enums;

namespace ContactManager
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
            Application.Run(new ContactManager());
        }
    }
}