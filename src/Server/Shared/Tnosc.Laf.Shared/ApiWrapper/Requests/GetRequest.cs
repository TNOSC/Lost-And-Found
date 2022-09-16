using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class GetRequest : RequestBase
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GetRequest<T> : RequestBase<T>
       where T : IDto
    {

    }
}
