namespace MyTranslatr.Services.TranslationHistory.API.Application.Commands
{
    public class AddTranslationAttemptCommand
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public string Language { get; set; }
        public bool Success { get; set; }
    }
}
