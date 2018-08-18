using SerbianEnglishDictionary.Library.Commands.Base;
using SerbianEnglishDictionary.Library.ViewModels.Base;
using System.Windows.Input;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.NextWordChoosers.Base;

namespace SerbianEnglishDictionary.Library.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
		private readonly NextWordChooser _nextWordChooser;
		private readonly IDictionary _translator;

		public MainViewModel(NextWordChooser nextWordChooser, IDictionary translator)
		{
			_nextWordChooser = nextWordChooser;
			_translator = translator;
		}

		#region Show Answer Command

		private ICommand _showAnswerCommand;

        public ICommand ShowAnswerCommand
        {
            get
            {
                if (_showAnswerCommand == null)
                {
                    _showAnswerCommand = new RelayCommand(ShowAnswerExecute, ShowAnswerCanExecute);
                }
                return _showAnswerCommand;
            }
        }

        public void ShowAnswerExecute(object obj)
        {
			SecondWord = _translator.GetTranslation(FirstWord);
        }

        public bool ShowAnswerCanExecute(object obj)
        {
            return !string.IsNullOrWhiteSpace(FirstWord);
        } 

        #endregion
        
        #region Next Word Command

        private ICommand _nextWordCommand;

        public ICommand NextWordCommand
        {
            get
            {
                if (_nextWordCommand == null)
                {
                    _nextWordCommand = new RelayCommand(NextCommandExecute);
                }
                return _nextWordCommand;
            }
        }

        public void NextCommandExecute(object obj)
        {
			FirstWord = _nextWordChooser.GetNextWord();
			SecondWord = "";

        }

        #endregion
		
        private string _secondWord;

        public string SecondWord
        {
            get
            {
                return _secondWord;
            }
            set
            {
                _secondWord = value;
				OnPropertyChanged(nameof(SecondWord));
			}
        }
		
		private string _firstWord;

        public string FirstWord
        {
            get
            {
                if (_firstWord != null)
                {
                    return _firstWord;
                }
                return "";
            }
            set
            {
				_firstWord = value;
                OnPropertyChanged(nameof(FirstWord));

            }
        }
    }
}