using SerbianEnglishDictionary.Library.IntermediateModel;
using System.Collections.Generic;

namespace SerbianEnglishDictionary.Library.DataAccess.CommandHandlers.TranslationTypeCommandHandler.DictionaryReaders.Base
{
    public interface IDictionaryReader
    {
        List<WordsPair> ReadFromSource();
    }
}
