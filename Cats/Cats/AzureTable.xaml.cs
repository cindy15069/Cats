﻿using Cats.DataModels;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cats
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AzureTable : ContentPage
	{
        MobileServiceClient client = AzureManager.AzureManagerInstance.AzureClient;
        public AzureTable()
		{
			InitializeComponent();
		}
        async void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            List<NotCatModel> notCatInformation = await AzureManager.AzureManagerInstance.GetCatInformation();

            CatList.ItemsSource = notCatInformation;
        }
    }
}