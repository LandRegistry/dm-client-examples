using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDeedApi
    {
        
        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        OperativeDeed DeedDeedReferenceGet (string deedReference);
  
        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>ApiResponse of OperativeDeed</returns>
        ApiResponse<OperativeDeed> DeedDeedReferenceGetWithHttpInfo (string deedReference);

        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of OperativeDeed</returns>
        System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceGetAsync (string deedReference);

        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of ApiResponse (OperativeDeed)</returns>
        System.Threading.Tasks.Task<ApiResponse<OperativeDeed>> DeedDeedReferenceGetAsyncWithHttpInfo (string deedReference);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DeedApi : IDeedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeedApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeedApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DeedApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param> 
        /// <returns>OperativeDeed</returns>
        public OperativeDeed DeedDeedReferenceGet (string deedReference)
        {
             ApiResponse<OperativeDeed> response = DeedDeedReferenceGetWithHttpInfo(deedReference);
             return response.Data;
        }

        /// <summary>
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param> 
        /// <returns>ApiResponse of OperativeDeed</returns>
        public ApiResponse< OperativeDeed > DeedDeedReferenceGetWithHttpInfo (string deedReference)
        {
            
            // verify the required parameter 'deedReference' is set
            if (deedReference == null) throw new ApiException(400, "Missing required parameter 'deedReference' when calling DeedDeedReferenceGet");
            
    
            var path_ = "/deed/{deed_reference}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", Configuration.ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeedDeedReferenceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeedDeedReferenceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<OperativeDeed>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperativeDeed) Configuration.ApiClient.Deserialize(response, typeof(OperativeDeed)));
            
        }
    
        /// <summary>
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of OperativeDeed</returns>
        public async System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceGetAsync (string deedReference)
        {
             ApiResponse<OperativeDeed> response = await DeedDeedReferenceGetAsyncWithHttpInfo(deedReference);
             return response.Data;

        }

        /// <summary>
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference.\nThe response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>Task of ApiResponse (OperativeDeed)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OperativeDeed>> DeedDeedReferenceGetAsyncWithHttpInfo (string deedReference)
        {
            // verify the required parameter 'deedReference' is set
            if (deedReference == null) throw new ApiException(400, "Missing required parameter 'deedReference' when calling DeedDeedReferenceGet");
            
    
            var path_ = "/deed/{deed_reference}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", Configuration.ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeedDeedReferenceGet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeedDeedReferenceGet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<OperativeDeed>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OperativeDeed) Configuration.ApiClient.Deserialize(response, typeof(OperativeDeed)));
            
        }
        
    }
    
}
