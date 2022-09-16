using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response for getting a ressource request using pagination strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class GetPaginatedResponse<T> : GetResponse<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the total number of the finded objects and take them per a page size
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="values"></param>
        protected GetPaginatedResponse(int totalCount, IEnumerable<T> values)
            : base(values)
        {
            TotalCount = totalCount;
        }

        /// <summary>
        /// Gets the total number of the finded objects
        /// </summary>
        [JsonPropertyName("total")]
        public int TotalCount { get; }
    }
}
