using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper
{
    /// <summary>
    /// <para>Abstract class to define a server response for client request to finding entities strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class FindResponse<T> : ResponseBase<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing a collection of objects
        /// </summary>
        /// <param name="values"></param>
        protected FindResponse(IEnumerable<T> values)
        {
            Values = values;
        }
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected FindResponse(Result result) :
                base(result)
        {
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        protected FindResponse()
        {

        }
        /// <summary>
        /// Gets a collection of finded objects
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<T> Values { get; set; }
    }
}
