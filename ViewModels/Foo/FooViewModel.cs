using System.Collections.Generic;
using AvaloniaTestRepository.Models.Foo;

namespace AvaloniaTestRepository.ViewModels.Foo
{
    public class FooViewModel
    {
        public List<EditableLocalizedText> LocalizedTexts { get; set; } = new();

        public FooViewModel()
        {
            LocalizedTexts.Add(new EditableLocalizedText
            {
                Locale = "en", OldText = "Hello", Text = "Hello World"
            });
            LocalizedTexts.Add(new EditableLocalizedText
            {
                Locale = "de"
            });
            LocalizedTexts.Add(new EditableLocalizedText
            {
                Locale = "fr", OldText = "Bonjour le monde", Text = "Bonjour le monde"
            });
        }
    }
}