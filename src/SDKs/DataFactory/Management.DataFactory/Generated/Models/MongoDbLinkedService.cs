// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for MongoDb data source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MongoDb")]
    [Rest.Serialization.JsonTransformation]
    public partial class MongoDbLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbLinkedService class.
        /// </summary>
        public MongoDbLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbLinkedService class.
        /// </summary>
        /// <param name="server">The IP address or server name of the MongoDB
        /// server. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="databaseName">The name of the MongoDB database that
        /// you want to access. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="authenticationType">The authentication type to be used
        /// to connect to the MongoDB database. Possible values include:
        /// 'Basic', 'Anonymous'</param>
        /// <param name="username">Username for authentication. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="password">Password for authentication.</param>
        /// <param name="authSource">Database to verify the username and
        /// password. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="port">The TCP port number that the MongoDB server uses
        /// to listen for client connections. The default value is 27017. Type:
        /// integer (or Expression with resultType integer), minimum:
        /// 0.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public MongoDbLinkedService(object server, object databaseName, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), string authenticationType = default(string), object username = default(object), SecureString password = default(SecureString), object authSource = default(object), object port = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description)
        {
            Server = server;
            AuthenticationType = authenticationType;
            DatabaseName = databaseName;
            Username = username;
            Password = password;
            AuthSource = authSource;
            Port = port;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IP address or server name of the MongoDB server.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.server")]
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to be used to connect to the
        /// MongoDB database. Possible values include: 'Basic', 'Anonymous'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the name of the MongoDB database that you want to
        /// access. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.databaseName")]
        public object DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecureString Password { get; set; }

        /// <summary>
        /// Gets or sets database to verify the username and password. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authSource")]
        public object AuthSource { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the MongoDB server uses to
        /// listen for client connections. The default value is 27017. Type:
        /// integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Server == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Server");
            }
            if (DatabaseName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DatabaseName");
            }
            if (Password != null)
            {
                Password.Validate();
            }
        }
    }
}