using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper
{
    /// <summary>
    /// <para>Applys the pagination during getting finded objects</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PaginatedFindResponse<T> : FindResponse<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the total number of the finded objects and take them per a page size
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="values"></param>
        protected PaginatedFindResponse(int totalCount, IEnumerable<T> values)
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
