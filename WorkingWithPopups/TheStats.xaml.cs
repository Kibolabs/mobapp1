using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace My_App
{
	public partial class TheStats : ContentPage
	{
		public TheStats()
		{
			InitializeComponent ();
		}

		async void OnActionSheetSimpleClicked (object sender, EventArgs e)
		{
			var action = await DisplayActionSheet ("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
			Debug.WriteLine ("Action: " + action);
		}

		async void OnActionSheetCancelDeleteClicked (object sender, EventArgs e)
		{
			var action = await DisplayActionSheet ("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
			Debug.WriteLine ("Action: " + action);
		}
	}
}
