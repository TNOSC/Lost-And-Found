namespace Tnosc.Laf.Shared.Exceptions
{
    public abstract class ValidationException : LafException
    {
        protected ValidationException(string message)
            : base(message)
        {
        }
    }
}
