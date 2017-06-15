// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IDataCatalogRestClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        Microsoft.Rest.ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// API version
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Catalog name
        /// </summary>
        string CatalogName { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IContainerOperations.
        /// </summary>
        IContainerOperations Container { get; }

        /// <summary>
        /// Gets the ITableOperations.
        /// </summary>
        ITableOperations Table { get; }

        /// <summary>
        /// Gets the ICommandOperations.
        /// </summary>
        ICommandOperations Command { get; }

        /// <summary>
        /// Gets the ITableValuedFunctionOperations.
        /// </summary>
        ITableValuedFunctionOperations TableValuedFunction { get; }

        /// <summary>
        /// Gets the IReportOperations.
        /// </summary>
        IReportOperations Report { get; }

        /// <summary>
        /// Gets the IKPIOperations.
        /// </summary>
        IKPIOperations KPI { get; }

        /// <summary>
        /// Gets the IMeasureOperations.
        /// </summary>
        IMeasureOperations Measure { get; }

        /// <summary>
        /// Gets the IQueryOperations.
        /// </summary>
        IQueryOperations Query { get; }

        /// <summary>
        /// Gets the ICollectionOperations.
        /// </summary>
        ICollectionOperations Collection { get; }

    }
}
