﻿using Configuration_Tool.Configuration.Forensics;
using System;
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

namespace Configuration_Tool.Controls.Forensics
{
    /// <summary>
    /// Interaction logic for ControlAnswerText.xaml
    /// </summary>
    public partial class ControlAnswerText : UserControl, IAnswer
    {
        public EAnswerType Type => EAnswerType.Text;

        public string Info
        {
            get { return txtInfo.Text; }
            set
            {
                txtInfo.Text = value;
            }
        }

        public ControlAnswerText()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            ItemsControl itemsControl = (ItemsControl)this.Parent;

            itemsControl.Items.Remove(this);
        }
    }
}
