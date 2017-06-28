﻿using Xamarin.Forms;
using Project78.Services;
using Project78.Views;

namespace Project78
{
	public partial class Project78Page : ContentPage
	{
        private readonly INavigationService _navigationService = new Navigator();

        public Project78Page()
		{
			this.BindingContext = new DeclarationsViewModel();
			InitializeComponent();
			Title = "Declarations";

			ToolbarItems.Add(new ToolbarItem("Add", null, async () =>
			{
				await Navigation.PushAsync(new CameraPage());
			}));
        }

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			ListView lv = (ListView)sender;
			Declaration item = (Declaration)lv.SelectedItem;
			await Navigation.PushAsync(new DetailedDeclarationPage(item.ID));
		}
	}
}
