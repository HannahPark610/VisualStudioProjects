﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NavigationDemo
{

    public partial class Details : ContentPage
    {
        public Details(ContactData contact)
        {
            InitializeComponent();
            if (contact == null)
                throw new ArgumentNullException();

            BindingContext = contact;


        }


        public Details()
        {
            InitializeComponent();
            //myListView.EndRefresh();
            //myListView.IsRefreshing = false;
        }
    }
 }

