using SerbianEnglishDictionary.Library.Commands.Base;
using SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base;
using SerbianEnglishDictionary.Library.IntermediateModel;
using SerbianEnglishDictionary.Library.ViewModels.Base;
using System;
using System.Windows.Input;
using System.Collections.Generic;

namespace SerbianEnglishDictionary.Library.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
		private List<WordsPair> _wordsDictionary;

		public MainViewModel(IDictionaryReader dictionaryReader)
        {
			_wordsDictionary = dictionaryReader.ReadFromSource();
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
			CorrectTranslation = CurrentPair.SecondWord;
        }

        public bool ShowAnswerCanExecute(object obj)
        {
            return CurrentPair != null;
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
            CurrentPair = GetRandomPairFromDictionary();
			CorrectTranslation = "";

        }

        #endregion

        #region Serbian Word To Show
        private string _correctTranslation;

        public string CorrectTranslation
        {
            get
            {
                return _correctTranslation;
            }
            set
            {
                _correctTranslation = value;
                OnPropertyChanged(nameof(CorrectTranslation));
            }
        }

        #endregion


        private WordsPair _currentPair;

		public WordsPair CurrentPair
        {
            get
            {
                return _currentPair;
            }
            set
            {
                _currentPair = value;
                OnPropertyChanged(nameof(CurrentPair));
                OnPropertyChanged(nameof(FirstWord));
            }
        }
        public string FirstWord
        {
            get
            {
                if (_currentPair != null)
                {
                    return _currentPair.FirstWord;
                }
                return "";
            }
            set
            {
                _currentPair.FirstWord = value;
                OnPropertyChanged(nameof(FirstWord));

            }
        }


        #region Private methods

        private WordsPair GetRandomPairFromDictionary()
        {
            Random randomForWordsPair = new Random();
            int randomWordsPairIndex = randomForWordsPair.Next() % _wordsDictionary.Count;
            return _wordsDictionary[randomWordsPairIndex];
        }

        #endregion
    }
}