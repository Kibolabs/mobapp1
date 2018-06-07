using System;
using System.Diagnostics;
using Xamarin.Forms;


namespace My_App
{
	public partial class AlertPage : ContentPage
	{
		public AlertPage ()
		{
			InitializeComponent ();
		}

		async void OnAlertSimpleClicked (object sender, EventArgs e)
		{
			await DisplayAlert ("Alert", "You have been alerted", "OK");
		}

		async void OnAlertYesNoClicked (object sender, EventArgs e)
		{
			var answer = await DisplayAlert ("Question?", "Would you like to play a game", "Yes", "No");
			Debug.WriteLine ("Answer: " + answer);
            if (answer==true){
                PuzzlePage Puzzle=new PuzzlePage();
                await Navigation.PushModalAsync(Puzzle);

            }
        }
	}
}
