using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Requests
{
    /// <summary>
    /// <para>Abstract class to define a client request for finding ressources strongly typed using pagination</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class GetPaginatedRequest<T> : RequestBase<T>
        where T : IDto
    {
        [JsonPropertyName("i")]
        public virtual int? Index { get; set; }

        [JsonPropertyName("p")]
        public virtual int? PageSize { get; set; }
    }
}
