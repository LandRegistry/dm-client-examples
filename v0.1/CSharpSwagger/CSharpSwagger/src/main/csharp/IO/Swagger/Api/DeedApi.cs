using System;
using System.IO;
using System.Collections.Generic;
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
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        OperativeDeed DeedDeedReferenceGet (string deedReference);
  
        /// <summary>
        /// Deed
        /// </summary>
        /// <remarks>
        /// The Deed endpoint returns details of a specific deed based on the unique deed reference. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceGetAsync (string deedReference);
        
        /// <summary>
        /// Deed Update
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provide. The reponse will return a URL that can retrieve the created deed. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <param name="body"></param>
        /// <returns>OperativeDeed</returns>
        OperativeDeed DeedDeedReferencePut (string deedReference, DeedApplication body);
  
        /// <summary>
        /// Deed Update
        /// </summary>
        /// <remarks>
        /// The post Deed endpoint creates a new deed based on the JSON provide. The reponse will return a URL that can retrieve the created deed. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </remarks>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <param name="body"></param>
        /// <returns>OperativeDeed</returns>
        System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferencePutAsync (string deedReference, DeedApplication body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DeedApi : IDeedApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeedApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DeedApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeedApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DeedApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param> 
        /// <returns>OperativeDeed</returns>            
        public OperativeDeed DeedDeedReferenceGet (string deedReference)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferenceGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferenceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OperativeDeed) ApiClient.Deserialize(response, typeof(OperativeDeed));
        }
    
        /// <summary>
        /// Deed The Deed endpoint returns details of a specific deed based on the unique deed reference. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <returns>OperativeDeed</returns>
        public async System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferenceGetAsync (string deedReference)
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferenceGet: " + response.Content, response.Content);

            return (OperativeDeed) ApiClient.Deserialize(response, typeof(OperativeDeed));
        }
        
        /// <summary>
        /// Deed Update The post Deed endpoint creates a new deed based on the JSON provide. The reponse will return a URL that can retrieve the created deed. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param> 
        /// <param name="body"></param> 
        /// <returns>OperativeDeed</returns>            
        public OperativeDeed DeedDeedReferencePut (string deedReference, DeedApplication body)
        {
            
            // verify the required parameter 'deedReference' is set
            if (deedReference == null) throw new ApiException(400, "Missing required parameter 'deedReference' when calling DeedDeedReferencePut");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeedDeedReferencePut");
            
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferencePut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferencePut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (OperativeDeed) ApiClient.Deserialize(response, typeof(OperativeDeed));
        }
    
        /// <summary>
        /// Deed Update The post Deed endpoint creates a new deed based on the JSON provide. The reponse will return a URL that can retrieve the created deed. The response includes the Title Number, Property information, Borrower(s) information and deed information.
        /// </summary>
        /// <param name="deedReference">Unique reference of the deed.</param>
        /// <param name="body"></param>
        /// <returns>OperativeDeed</returns>
        public async System.Threading.Tasks.Task<OperativeDeed> DeedDeedReferencePutAsync (string deedReference, DeedApplication body)
        {
            // verify the required parameter 'deedReference' is set
            if (deedReference == null) throw new ApiException(400, "Missing required parameter 'deedReference' when calling DeedDeedReferencePut");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DeedDeedReferencePut");
            
    
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
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (deedReference != null) pathParams.Add("deed_reference", ApiClient.ParameterToString(deedReference)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeedDeedReferencePut: " + response.Content, response.Content);

            return (OperativeDeed) ApiClient.Deserialize(response, typeof(OperativeDeed));
        }
        
    }
    
}
