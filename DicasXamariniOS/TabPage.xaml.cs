using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DicasXamariniOS
{
    public partial class TabPage : TabbedPage
    {
        public TabPage()
        {
            InitializeComponent();

            Children.Add(new MainPage());
            Children.Add(new OutraPage());
        }
    }
}
