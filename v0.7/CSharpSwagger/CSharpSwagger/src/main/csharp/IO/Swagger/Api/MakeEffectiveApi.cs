/* 
 * Deed API
 *
 * Land Registry Deed API
 *
 * OpenAPI spec version: 2.3.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMakeEffectiveApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Make Effective
        /// </summary>
        /// <remarks>
        /// The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        OperativeDeed DeedDeedReferenceMakeEffectivePost (string deedReference);

        /// <summary>
        /// Make Effective
        /// </summary>
        /// <remarks>
        /// The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>ApiResponse of OperativeDeed</returns>
        ApiResponse<OperativeDeed> DeedDeedReferenceMakeEffectivePostWithHttpInfo (string deedReference);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Make Effective
        /// </summary>
        /// <remarks>
        /// The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of OperativeDeed</returns>
        System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceMakeEffectivePostAsync (string deedReference);

        /// <summary>
        /// Make Effective
        /// </summary>
        /// <remarks>
        /// The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of ApiResponse (OperativeDeed)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperativeDeed>> DeedDeedReferenceMakeEffectivePostAsyncWithHttpInfo (string deedReference);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MakeEffectiveApi : IMakeEffectiveApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeEffectiveApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MakeEffectiveApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MakeEffectiveApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MakeEffectiveApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Make Effective The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        public OperativeDeed DeedDeedReferenceMakeEffectivePost (string deedReference)
        {
             ApiResponse<OperativeDeed> localVarResponse = DeedDeedReferenceMakeEffectivePostWithHttpInfo(deedReference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make Effective The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>ApiResponse of OperativeDeed</returns>
        public ApiResponse< OperativeDeed > DeedDeedReferenceMakeEffectivePostWithHttpInfo (string deedReference)
        {
            // verify the required parameter 'deedReference' is set
            if (deedReference == null)
                throw new ApiException(400, "Missing required parameter 'deedReference' when calling MakeEffectiveApi->DeedDeedReferenceMakeEffectivePost");

            var localVarPath = "/deed/{deed_reference}/make-effective";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deedReference != null) localVarPathParams.Add("deed_reference", Configuration.ApiClient.ParameterToString(deedReference)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeedDeedReferenceMakeEffectivePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperativeDeed>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperativeDeed) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperativeDeed)));
            
        }

        /// <summary>
        /// Make Effective The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of OperativeDeed</returns>
        public async System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceMakeEffectivePostAsync (string deedReference)
        {
             ApiResponse<OperativeDeed> localVarResponse = await DeedDeedReferenceMakeEffectivePostAsyncWithHttpInfo(deedReference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make Effective The Make Effective endpoint triggers the service to make a deed effective, dating it with the timestamp of when this call is made. The response includes the Title Number, Property information, Borrower(s) information and deed information, as well as the timestamp that is saved onto the deed. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of ApiResponse (OperativeDeed)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperativeDeed>> DeedDeedReferenceMakeEffectivePostAsyncWithHttpInfo (string deedReference)
        {
            // verify the required parameter 'deedReference' is set
            if (deedReference == null)
                throw new ApiException(400, "Missing required parameter 'deedReference' when calling MakeEffectiveApi->DeedDeedReferenceMakeEffectivePost");

            var localVarPath = "/deed/{deed_reference}/make-effective";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (deedReference != null) localVarPathParams.Add("deed_reference", Configuration.ApiClient.ParameterToString(deedReference)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeedDeedReferenceMakeEffectivePost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OperativeDeed>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperativeDeed) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OperativeDeed)));
            
        }

    }
}
