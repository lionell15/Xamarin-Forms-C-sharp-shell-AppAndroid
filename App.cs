using System;
using System.IO;
using Xamarin.Forms;

namespace Leonel
{
	public class App : Application
	{
		public App()
		{
			this.MainPage = new Contenido();
		}
	}
	public class Contenido : ContentPage
	{

		public Contenido()
		{
			var colors = new[]
			{
				new { value = Color.White, name = "White" },
				new { value = Color.Silver, name = "Silver" },
				new { value = Color.Gray, name = "Gray" },
				new { value = Color.Black, name = "Black" },
				new { value = Color.Red, name = "Red" },
				new { value = Color.Maroon, name = "Maroon" },
				new { value = Color.Yellow, name = "Yellow" },
				new { value = Color.Olive, name = "Olive" },
				new { value = Color.Lime, name = "Lime" },
				new { value = Color.Green, name = "Green" },
				new { value = Color.Aqua, name = "Aqua" },
				new { value = Color.Teal, name = "Teal" },
				new { value = Color.Blue, name = "Blue" },
				new { value = Color.Navy, name = "Navy" },
				new { value = Color.Pink, name = "Pink" },
				new { value = Color.Fuchsia, name = "Fuchsia" },
				new { value = Color.Purple, name = "Purple" }
			};


			// Build the page.
			Title = "Xaml Designer";
			Padding = new Thickness(10, 0);
			BackgroundColor = Color.White;
			ScrollView scrollView = new ScrollView();
			Content = scrollView;
			StackLayout stackLayout = new StackLayout();
			scrollView.Content = stackLayout;
			stackLayout.Children.Add(
				new Label
				{
					Text = "Colours Xamarin",
					TextColor = Color.Black,
					HorizontalTextAlignment = TextAlignment.Center,
					FontSize = 25,
					Margin = new Thickness(0, 10)
				}
				);
			foreach (var Colorid in colors)
			{
				stackLayout.Children.Add(
					new Frame
					{
						BorderColor = Color.Black,
						BackgroundColor = Colorid.value,
						Padding = new Thickness(0, 20),
						Content = new StackLayout
						{
							Children = {
								new Label{
									Text = Colorid.name,
									TextColor = Colorid.value==Color.Black ? Color.White : Color.Black,
									HorizontalTextAlignment = TextAlignment.Center
								}, new Label{
									Text = Colorid.value.ToHex(),
										TextColor = Colorid.value==Color.Black ? Color.White : Color.Black,
									HorizontalTextAlignment = TextAlignment.Center
								}
							}
						}
					}
					);
			}


		}

	}

}
