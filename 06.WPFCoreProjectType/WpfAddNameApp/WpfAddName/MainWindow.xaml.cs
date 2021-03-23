// HOMEWORK - 06 - Mini-Project - Build a small WPF Application that has a simple data entry, for example 'Name'
// Have a Button say "Hi" or "Hello {name} " when pressed. You can use the .NET Framwork or .NET Core to build it.

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

namespace WpfAddName
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private int clickedTimes;

		public MainWindow()
		{
			InitializeComponent();
			
			clickedTimes = 0;
		}

		private void MainButton_Click(object sender, RoutedEventArgs e)
		{
			clickedTimes++;

			MainLabel.Text = "You clicked the button " + clickedTimes + " Times";
		}
	}
}
