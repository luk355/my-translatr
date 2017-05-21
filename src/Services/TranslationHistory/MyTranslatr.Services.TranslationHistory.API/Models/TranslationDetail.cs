using System;

namespace TranslationHistory.API.Models
{
    public class TranslationDetail
    {
        public Guid Id { get; set; }
        public string Word { get; set; }
        public string Translation { get; set; }
        public string Language { get; set; }
        public bool Success { get; set; }
    }
}
