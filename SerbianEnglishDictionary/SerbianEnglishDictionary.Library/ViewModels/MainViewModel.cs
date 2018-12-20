using SerbianEnglishDictionary.Library.Commands.Base;
using SerbianEnglishDictionary.Library.ViewModels.Base;
using System.Windows.Input;
using SerbianEnglishDictionary.Library.Dictionaries.Interface;
using SerbianEnglishDictionary.Library.DictionaryWriters.Base;
using SerbianEnglishDictionary.Library.EntityBuilders;
using SerbianEnglishDictionary.Library.NextWordChoosers.Base;

namespace SerbianEnglishDictionary.Library.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
		private readonly NextWordChooser _nextWordChooser;
		private readonly IDictionary _translator;
	    private readonly DictionaryWriter _dictionaryWriter;
	    private readonly EntityBuilder _entityBuilder;


		public MainViewModel(NextWordChooser nextWordChooser, IDictionary translator, DictionaryWriter dictionaryWriter, EntityBuilder entityBuilder)
		{
			_nextWordChooser = nextWordChooser;
			_translator = translator;
			_dictionaryWriter = dictionaryWriter;
			_entityBuilder = entityBuilder;
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

		#region Save Entity Command

		private ICommand _saveEntityCommand;

		public ICommand SaveEntityCommand
		{
			get
			{
				if (_saveEntityCommand == null)
				{
					_saveEntityCommand = new RelayCommand(SaveEntityExecute, SaveEntityCanExecute);
				}
				return _saveEntityCommand;
			}
		}

		public void SaveEntityExecute(object obj)
		{
			var entity = _entityBuilder.GetEntity(FirstWord, SecondWord);
			_dictionaryWriter.AddEntity(entity);
			FirstWord = "";
			SecondWord = "";
		}

		public bool SaveEntityCanExecute(object obj)
		{
			return !string.IsNullOrWhiteSpace(FirstWord) && !string.IsNullOrWhiteSpace(SecondWord);
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