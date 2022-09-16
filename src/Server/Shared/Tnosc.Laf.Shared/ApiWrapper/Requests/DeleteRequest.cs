using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Requests
{
    /// <summary>
    /// <para>Abstract class to define a client request for deleting ressource</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class DeleteRequest : RequestBase
    {
    }

    /// <summary>
    /// <para>Abstract class to define a client request for deleting ressource strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class DeleteRequest<T> : RequestBase<T>
        where T : IDto
    {
    }
}
