using SerbianEnglishDictionary.Initializers.NextWordChoosers;
using SerbianEnglishDictionary.Initializers.Translators;
using SerbianEnglishDictionary.Library.ViewModels;
using System.Windows;
using SerbianEnglishDictionary.Initializers.DictionaryWriters;
using SerbianEnglishDictionary.Initializers.EntityBuilders;
using SerbianEnglishDictionary.Initializers.ServiceHosts;

namespace SerbianEnglishDictionary
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			//TODO: Initialize model from here
			InitializeComponentExt();
		}

		private void InitializeComponentExt()
		{
			//TODO: Move Main view model from here
			ReceiveEntityServiceHostInitializer.Initialize();
			DataContext = new MainViewModel(NextWordChooserInitializer.GetChooser(), 
											DictionaryInitializer.GetDictionary(),
											DictionaryWriterInitializer.GetWriter(), 
											EntityBuilderInitializer.GetEntityBuilder(),
											Config.Instance.DictionaryType);
		}
	}
}
