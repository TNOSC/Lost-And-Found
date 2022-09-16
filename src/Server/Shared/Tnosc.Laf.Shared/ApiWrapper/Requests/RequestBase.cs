using System.Text.Json.Serialization;
using Tnosc.Laf.Shared.Common;

namespace Tnosc.Laf.Shared.ApiWrapper.Requests
{
    /// <summary>
    /// <para>Abstract class to define a client request</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public abstract class RequestBase
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        protected RequestBase()
        {
            CorrelationId = Guid.NewGuid();
        }

        /// <summary>
        /// Tracks a request by assigning a Guid
        /// </summary>
        [JsonIgnore]
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the Ip Address of the connected user
        /// </summary>
        [JsonIgnore]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the identity of the connected user
        /// </summary>
        [JsonIgnore]
        public ICurrentUser CurrentUser { get; set; }

        /// <summary>
        /// Gets or sets a refresh token
        /// </summary>
        [JsonPropertyName("r")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets a Jwt token
        /// </summary>
        [JsonPropertyName("t")]
        public string Token { get; set; }
    }

    /// <summary>
    /// <para>Abstract class to define a client request strongly typed</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Data transfer object which implements the interface <see cref="IDto"/></typeparam>
    public abstract class RequestBase<T> : RequestBase
        where T : IDto
    {
    }

}