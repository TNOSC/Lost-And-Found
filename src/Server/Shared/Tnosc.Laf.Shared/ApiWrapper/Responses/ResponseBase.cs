using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Responses
{
    /// <summary>
    /// <para>Abstract class to define a server response to client request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class ResponseBase
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected ResponseBase(Result result)
            : this()
        {
            if (result.IsFailure)
                Errors = result.Errors;
        }
        /// <summary>
        /// Instanciate a response by sepecifing error messages
        /// </summary>
        /// <param name="errors">array of errors</param>
        protected ResponseBase(string[] errors)
            : this()
        {
            Errors = errors;
        }
        /// <summary>
        /// Instanciate a response by sepecifing an error message
        /// </summary>
        /// <param name="error">error message</param>
        protected ResponseBase(string error)
            : this(new string[] { error })
        {

        }
        /// <summary>
        /// Defautl constructor
        /// </summary>
        protected ResponseBase()
        {
            TimeGenerated = DateTime.Now;
            Errors = new List<string>();
        }
        /// <summary>
        /// Gets or sets error messages
        /// </summary>
        [JsonPropertyName("errors")]
        public IEnumerable<string> Errors { get; set; }

        /// <summary>
        /// Gets whether the server handles successfully the received request 
        /// Returns: true if the server has proceeded the request without errors; otherwise false
        /// </summary>
        [JsonPropertyName("isSucceeded")]
        public bool IsSucceeded
        {
            get { return !Errors.Any(); }
        }

        /// <summary>
        /// Gets or sets a refresh token
        /// </summary>
        [JsonPropertyName("r")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets a the Guid of the received request 
        /// Returns: The Guid value
        /// </summary>
        [JsonIgnore]
        public Guid RequestId { get; set; }

        /// <summary>
        /// Gets or sets a status code value of the response
        /// Returns: The status code value for eg: [200, 400, 401, 403, 500]
        /// </summary>
        [JsonIgnore]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Gets or sets a datetime when the response is created
        /// </summary>
        [JsonPropertyName("timeGenerated")]
        public DateTime TimeGenerated { get; }

        /// <summary>
        /// Gets or sets a Jwt token
        /// </summary>
        [JsonPropertyName("t")]
        public string Token { get; set; }
    }

    /// <summary>
    /// <para>Abstract class to define a server response to client request strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class ResponseBase<T> : ResponseBase
        where T : IDto
    {
        /// <summary>
        /// Instanciate a response by sepecifing the operation's result
        /// </summary>
        /// <param name="result">Result object <see cref="Result"/></param>
        protected ResponseBase(Result result)
                    : base(result)
        {
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected ResponseBase()
        {

        }
    }
}
