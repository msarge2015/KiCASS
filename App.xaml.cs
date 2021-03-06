﻿using System.Windows;
using log4net.Config;
using LaptopOrchestra.Kinect.ViewModel;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LaptopOrchestra.Kinect
{
    public partial class App : System.Windows.Application
    {

        MainWindow window;
        MainWindowViewModel viewModel;

        private void App_Startup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(e);

            // Initialize logger
            XmlConfigurator.Configure();
            Logger.Debug("App Startup");

            //Create the main window view.
            //MainWindow window = new MainWindow();
            window = new MainWindow();

            // Create the ViewModel to which the main window binds.
            //MainWindowViewModel viewModel = new MainWindowViewModel();
            viewModel = new MainWindowViewModel();

            // Allow all controls in the window to bind to the ViewModel by
            //setting the DataContext, which propagates down the element tree.
            window.DataContext = viewModel;

            //Show the main window.
            window.Show();

            System.Windows.Application.Current.MainWindow.Closing += new CancelEventHandler(App_Exit);
        }

        public static bool CloseCancel()
        {
            const string message = "Are you sure that you would like to close KICASS?";
            const string caption = "Cancel Installer";
            var result = System.Windows.Forms.MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public void App_Exit(object sender, CancelEventArgs e)
        {
            if (CloseCancel())
                Environment.Exit(Environment.ExitCode);
            else
                e.Cancel = true;
        }
    }
}