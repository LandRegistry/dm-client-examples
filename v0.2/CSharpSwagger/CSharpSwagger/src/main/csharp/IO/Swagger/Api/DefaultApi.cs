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
    public interface IDefaultApi
    {
        
        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string AddDeed (DeedApplication body);
  
        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> AddDeedWithHttpInfo (DeedApplication body);

        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> AddDeedAsync (DeedApplication body);

        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </remarks>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> AddDeedAsyncWithHttpInfo (DeedApplication body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
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
        /// Deed The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>string</returns>
        public string AddDeed (DeedApplication body)
        {
             ApiResponse<string> response = AddDeedWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Deed The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </summary>
        /// <param name="body"></param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > AddDeedWithHttpInfo (DeedApplication body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddDeed");
            
    
            var path_ = "/deed/";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddDeed: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddDeed: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
    
        /// <summary>
        /// Deed The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> AddDeedAsync (DeedApplication body)
        {
             ApiResponse<string> response = await AddDeedAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Deed The post Deed endpoint creates a new deed based on the JSON provided.\n The reponse will return a URL that can retrieve the created deed. \n &gt; REQUIRED: Land Registry system requests Conveyancer to confirm that the Borrowers identity has been established in accordance with Section 111 of the Network Access Agreement.
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> AddDeedAsyncWithHttpInfo (DeedApplication body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddDeed");
            
    
            var path_ = "/deed/";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "text/plain"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddDeed: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddDeed: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<string>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(response, typeof(string)));
            
        }
        
    }
    
}
