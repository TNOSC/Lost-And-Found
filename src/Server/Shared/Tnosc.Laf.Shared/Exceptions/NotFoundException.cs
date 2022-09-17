namespace Tnosc.Laf.Shared.Exceptions
{
    public abstract class NotFoundException : LafException
    {
        protected NotFoundException(string message)
            : base(message)
        {
        }
    }
}
