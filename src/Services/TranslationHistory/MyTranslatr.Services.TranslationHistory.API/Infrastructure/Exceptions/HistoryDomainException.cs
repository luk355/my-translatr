using System;

namespace TranslationHistory.API.Infrastructure.Exceptions
{
    public class HistoryDomainException : Exception
    {
        public HistoryDomainException()
        { }

        public HistoryDomainException(string message)
            : base(message)
        { }

        public HistoryDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
