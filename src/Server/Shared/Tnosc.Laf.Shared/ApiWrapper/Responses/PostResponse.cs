using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response for posting a ressource request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="TKey">ID Type</typeparam>
    public class PostResponse<TKey> : ResponseBase
        where TKey : struct
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected PostResponse(Result result)
                    : base(result)
        {
            
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected PostResponse()
        {

        }

        /// <summary>
        /// Gets or sets ressource Id
        /// </summary>
        public TKey Id { get; set; }
    }

    /// <summary>
    /// <para>Abstract class to define a server response for posting a ressource request strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    /// <typeparam name="TKey">ID Type</typeparam>
    public class PostResponse<T, TKey> : ResponseBase<T>
        where T : IDto
        where TKey : struct
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected PostResponse(Result result)
                    : base(result)
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected PostResponse()
        {

        }

        /// <summary>
        /// Gets or sets ressource Id
        /// </summary>
        public TKey Id { get; set; }
    }
}
