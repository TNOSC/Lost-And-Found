using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response for getting a ressource request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class GetResponse : ResponseBase
    {

        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected GetResponse(Result result) :
                base(result)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected GetResponse()
        {

        }
    }

    /// <summary>
    /// <para>Abstract class to define a server response for getting a ressource request strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class GetResponse<T> : ResponseBase<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing a collection of objects
        /// </summary>
        /// <param name="values"></param>
        protected GetResponse(IEnumerable<T> values)
        {
            Values = values;
        }

        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected GetResponse(Result result) :
                base(result)
        {
        }

        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected GetResponse(Result<IEnumerable<T>> result) :
                base(result)
        {
            if (result.IsSuccess)
                Values = result.Value;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected GetResponse()
        {

        }

        /// <summary>
        /// Gets a collection of finded objects
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<T> Values { get; set; }
    }
}
