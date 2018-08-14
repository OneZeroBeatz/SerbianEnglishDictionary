using SerbianEnglishDictionary.Initializer.CommandHandlerInitializer.TranslationTypeCommandHandlerInitializer;
using SerbianEnglishDictionary.Library.ViewModels;
using System.Windows;

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
			DataContext = new MainViewModel(TranslationTypeToReaderCommandHandlerInitializer.Get().GetDictionaryReader(Config.Instance.CurrentTranslationType));
		}
	}
}
