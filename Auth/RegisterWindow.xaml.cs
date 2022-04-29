﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sanator.Auth
{

    public partial class RegisterWindow : Window
    {
        private static MainWindow _mainWindow;
        private static string msgSuccessCreation = "Congratulations! New user successfully created";
        private static string msgErrorCreation = "Error while saving";
        private static string msgLoginExists = "Such login is already exists. Try new one.";
        private static string msgInputError = "Error of input data. Try again";

        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Show(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            this.Show();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ShowMainWindow();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (CreateNewUser())
            {
                ShowMainWindow();
            }
        }

        private void ShowMainWindow()
        {
            this.Close();
            _mainWindow?.Show();
        }

        private bool CreateNewUser()
        {
            bool success = false;
            User newUser;

            string name = nameTxtBox.Text;
            string login = loginTxtBox.Text;
            string pass1 = passBox1.Password;
            string pass2 = passBox2.Password;
        }
    }
}


