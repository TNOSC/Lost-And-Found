using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper
{
    /// <summary>
    /// <para>Abstract class to define a client request for deleting entities strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public class DeleteRequest<T> : RequestBase<T>
        where T : IDto
    {
    }
}
