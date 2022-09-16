using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response for updating a ressource request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public class PutResponse : ResponseBase
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected PutResponse(Result result)
                    : base(result)
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected PutResponse()
        {

        }
    }

    /// <summary>
    /// <para>Abstract class to define a server response for updating a ressource request strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public class PutResponse<T> : ResponseBase<T>
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected PutResponse(Result result)
                    : base(result)
        {

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected PutResponse()
        {

        }
    }
}
