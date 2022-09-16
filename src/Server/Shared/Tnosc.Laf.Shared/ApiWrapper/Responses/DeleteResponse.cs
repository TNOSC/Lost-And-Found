using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response for deleting a ressource request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class DeleteResponse : ResponseBase
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

    /// <summary>
    /// <para>Abstract class to define a server response for deleting a ressource request strongly typed</para>
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
