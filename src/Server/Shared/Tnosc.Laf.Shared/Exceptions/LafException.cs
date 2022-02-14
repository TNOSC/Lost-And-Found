namespace Tnosc.Laf.Shared.Exceptions
{
    public abstract class LafException : Exception
    {
        protected LafException(string message) 
            : base(message)
        {
        }
    }
}
