namespace Tnosc.Laf.Shared.Common
{
    public interface ICurrentUser
    {
        bool IsAnonymous { get; }
        string UserName { get; }
    }
}
