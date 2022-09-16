using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Requests
{
    /// <summary>
    /// <para>Abstract class to define a client request for updating a ressource</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class PutRequest : RequestBase
    {

    }

    /// <summary>
    /// <para>Abstract class to define a client request for updating a ressource strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class PutRequest<T> : RequestBase<T>
      where T : IDto
    {

    }
}
