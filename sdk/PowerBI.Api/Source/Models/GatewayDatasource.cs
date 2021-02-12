// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI gateway datasource
    /// </summary>
    public partial class GatewayDatasource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        public GatewayDatasource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayDatasource class.
        /// </summary>
        /// <param name="id">The unique id for this datasource</param>
        /// <param name="gatewayId">The associated gateway id</param>
        /// <param name="credentialType">Type of the datasource credentials.
        /// Possible values include: 'Basic', 'Windows', 'Anonymous', 'OAuth2',
        /// 'Key'</param>
        /// <param name="datasourceName">The name of the datasource</param>
        /// <param name="datasourceType">The type of the datasource</param>
        /// <param name="connectionDetails">Connection details in json
        /// format</param>
        public GatewayDatasource(System.Guid id, System.Guid gatewayId, CredentialType credentialType, string datasourceName = default(string), string datasourceType = default(string), string connectionDetails = default(string))
        {
            Id = id;
            GatewayId = gatewayId;
            DatasourceName = datasourceName;
            DatasourceType = datasourceType;
            ConnectionDetails = connectionDetails;
            CredentialType = credentialType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique id for this datasource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the associated gateway id
        /// </summary>
        [JsonProperty(PropertyName = "gatewayId")]
        public System.Guid GatewayId { get; set; }

        /// <summary>
        /// Gets or sets the name of the datasource
        /// </summary>
        [JsonProperty(PropertyName = "datasourceName")]
        public string DatasourceName { get; set; }

        /// <summary>
        /// Gets or sets the type of the datasource
        /// </summary>
        [JsonProperty(PropertyName = "datasourceType")]
        public string DatasourceType { get; set; }

        /// <summary>
        /// Gets or sets connection details in json format
        /// </summary>
        [JsonProperty(PropertyName = "connectionDetails")]
        public string ConnectionDetails { get; set; }

        /// <summary>
        /// Gets or sets type of the datasource credentials. Possible values
        /// include: 'Basic', 'Windows', 'Anonymous', 'OAuth2', 'Key'
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public CredentialType CredentialType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
