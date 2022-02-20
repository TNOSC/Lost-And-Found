using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper
{
    /// <summary>
    /// <para>Abstract class to define a server response for client request to delelting entities strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class DeleteResponse<T> : ResponseBase<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected DeleteResponse(Result result)
            : base(result)
        {

        }
        /// <summary>
        /// Default constructor
        /// </summary>
        protected DeleteResponse()
        {

        }
    }
}
