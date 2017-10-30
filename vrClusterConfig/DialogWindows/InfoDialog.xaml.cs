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
using System.Windows.Shapes;

namespace vrClusterConfig
{
    /// <summary>
    /// Interaction logic for InfoDialog.xaml
    /// </summary>
    public partial class InfoDialog : Window
    {
        public InfoDialog()
        {
            InitializeComponent();
        }

        public InfoDialog(string message)
        {
            InitializeComponent();
            MessageTextBlock.Text = message;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
