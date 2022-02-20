using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper
{
    /// <summary>
    /// <para>Abstract class to define a server response for client request to saving an entity strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public class SaveResponse<T> : ResponseBase<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected SaveResponse(Result result)
                    : base(result)
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected SaveResponse()
        {

        }
    }
}
