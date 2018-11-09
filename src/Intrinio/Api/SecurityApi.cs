

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Intrinio.Client;
using Intrinio.Model;

namespace Intrinio.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISecurityApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get All Securiites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 GetAllSecurities (string nextPage = null);

        /// <summary>
        /// Get All Securiites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20023</returns>
        ApiResponse<InlineResponse20023> GetAllSecuritiesWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Security by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Security</returns>
        Security GetSecurityById (string identifier);

        /// <summary>
        /// Get a Security by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of Security</returns>
        ApiResponse<Security> GetSecurityByIdWithHttpInfo (string identifier);
        /// <summary>
        /// Get Security Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>DataPointNumber</returns>
        DataPointNumber GetSecurityDataPointNumber (string identifier, string tag);

        /// <summary>
        /// Get Security Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        ApiResponse<DataPointNumber> GetSecurityDataPointNumberWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Get Security Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>DataPointText</returns>
        DataPointText GetSecurityDataPointText (string identifier, string tag);

        /// <summary>
        /// Get Security Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of DataPointText</returns>
        ApiResponse<DataPointText> GetSecurityDataPointTextWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Get Security Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20025</returns>
        InlineResponse20025 GetSecurityHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Security Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20025</returns>
        ApiResponse<InlineResponse20025> GetSecurityHistoricalDataWithHttpInfo (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Get Stock Price Adjustments for Security
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20027</returns>
        InlineResponse20027 GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Get Stock Price Adjustments for Security
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20027</returns>
        ApiResponse<InlineResponse20027> GetSecurityStockPriceAdjustmentsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get Stock Prices for Security
        /// </summary>
        /// <remarks>
        /// Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20026</returns>
        InlineResponse20026 GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);

        /// <summary>
        /// Get Stock Prices for Security
        /// </summary>
        /// <remarks>
        /// Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20026</returns>
        ApiResponse<InlineResponse20026> GetSecurityStockPricesWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);
        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>List&lt;SecurityScreenResult&gt;</returns>
        List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);

        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityScreenResult&gt;</returns>
        ApiResponse<List<SecurityScreenResult>> ScreenSecuritiesWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);
        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>InlineResponse20024</returns>
        InlineResponse20024 SearchSecurities (string query);

        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of InlineResponse20024</returns>
        ApiResponse<InlineResponse20024> SearchSecuritiesWithHttpInfo (string query);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get All Securiites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20023</returns>
        System.Threading.Tasks.Task<InlineResponse20023> GetAllSecuritiesAsync (string nextPage = null);

        /// <summary>
        /// Get All Securiites
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> GetAllSecuritiesAsyncWithHttpInfo (string nextPage = null);
        /// <summary>
        /// Get a Security by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of Security</returns>
        System.Threading.Tasks.Task<Security> GetSecurityByIdAsync (string identifier);

        /// <summary>
        /// Get a Security by ID
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Security)</returns>
        System.Threading.Tasks.Task<ApiResponse<Security>> GetSecurityByIdAsyncWithHttpInfo (string identifier);
        /// <summary>
        /// Get Security Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of DataPointNumber</returns>
        System.Threading.Tasks.Task<DataPointNumber> GetSecurityDataPointNumberAsync (string identifier, string tag);

        /// <summary>
        /// Get Security Data Point (Number)
        /// </summary>
        /// <remarks>
        /// Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetSecurityDataPointNumberAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Get Security Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of DataPointText</returns>
        System.Threading.Tasks.Task<DataPointText> GetSecurityDataPointTextAsync (string identifier, string tag);

        /// <summary>
        /// Get Security Data Point (Text)
        /// </summary>
        /// <remarks>
        /// Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetSecurityDataPointTextAsyncWithHttpInfo (string identifier, string tag);
        /// <summary>
        /// Get Security Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20025</returns>
        System.Threading.Tasks.Task<InlineResponse20025> GetSecurityHistoricalDataAsync (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);

        /// <summary>
        /// Get Security Historical Data
        /// </summary>
        /// <remarks>
        /// Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20025)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20025>> GetSecurityHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null);
        /// <summary>
        /// Get Stock Price Adjustments for Security
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20027</returns>
        System.Threading.Tasks.Task<InlineResponse20027> GetSecurityStockPriceAdjustmentsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);

        /// <summary>
        /// Get Stock Price Adjustments for Security
        /// </summary>
        /// <remarks>
        /// Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null);
        /// <summary>
        /// Get Stock Prices for Security
        /// </summary>
        /// <remarks>
        /// Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20026</returns>
        System.Threading.Tasks.Task<InlineResponse20026> GetSecurityStockPricesAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);

        /// <summary>
        /// Get Stock Prices for Security
        /// </summary>
        /// <remarks>
        /// Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> GetSecurityStockPricesAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null);
        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of List&lt;SecurityScreenResult&gt;</returns>
        System.Threading.Tasks.Task<List<SecurityScreenResult>> ScreenSecuritiesAsync (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);

        /// <summary>
        /// Screen Securities
        /// </summary>
        /// <remarks>
        /// Screen securities using complex logic
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityScreenResult&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SecurityScreenResult>>> ScreenSecuritiesAsyncWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null);
        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of InlineResponse20024</returns>
        System.Threading.Tasks.Task<InlineResponse20024> SearchSecuritiesAsync (string query);

        /// <summary>
        /// Search Securities
        /// </summary>
        /// <remarks>
        /// Searches for Securities matching the text &#x60;query&#x60;
        /// </remarks>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (InlineResponse20024)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20024>> SearchSecuritiesAsyncWithHttpInfo (string query);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SecurityApi : ISecurityApi
    {
        private Intrinio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SecurityApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SecurityApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Intrinio.Client.Configuration.DefaultExceptionFactory;
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
        public Intrinio.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Get All Securiites 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20023</returns>
        public InlineResponse20023 GetAllSecurities (string nextPage = null)
        {
             ApiResponse<InlineResponse20023> localVarResponse = GetAllSecuritiesWithHttpInfo(nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Securiites 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20023</returns>
        public ApiResponse< InlineResponse20023 > GetAllSecuritiesWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/securities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20023>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20023)));
        }

        /// <summary>
        /// Get All Securiites 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20023</returns>
        public async System.Threading.Tasks.Task<InlineResponse20023> GetAllSecuritiesAsync (string nextPage = null)
        {
             ApiResponse<InlineResponse20023> localVarResponse = await GetAllSecuritiesAsyncWithHttpInfo(nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Securiites 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20023)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20023>> GetAllSecuritiesAsyncWithHttpInfo (string nextPage = null)
        {

            var localVarPath = "/securities";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20023>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20023) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20023)));
        }

        /// <summary>
        /// Get a Security by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Security</returns>
        public Security GetSecurityById (string identifier)
        {
             ApiResponse<Security> localVarResponse = GetSecurityByIdWithHttpInfo(identifier);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Security by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>ApiResponse of Security</returns>
        public ApiResponse< Security > GetSecurityByIdWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityById");

            var localVarPath = "/securities/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Security>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Security) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Security)));
        }

        /// <summary>
        /// Get a Security by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of Security</returns>
        public async System.Threading.Tasks.Task<Security> GetSecurityByIdAsync (string identifier)
        {
             ApiResponse<Security> localVarResponse = await GetSecurityByIdAsyncWithHttpInfo(identifier);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Security by ID 
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <returns>Task of ApiResponse (Security)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Security>> GetSecurityByIdAsyncWithHttpInfo (string identifier)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityById");

            var localVarPath = "/securities/{identifier}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Security>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Security) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Security)));
        }

        /// <summary>
        /// Get Security Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>DataPointNumber</returns>
        public DataPointNumber GetSecurityDataPointNumber (string identifier, string tag)
        {
             ApiResponse<DataPointNumber> localVarResponse = GetSecurityDataPointNumberWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Security Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of DataPointNumber</returns>
        public ApiResponse< DataPointNumber > GetSecurityDataPointNumberWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointNumber");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Security Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of DataPointNumber</returns>
        public async System.Threading.Tasks.Task<DataPointNumber> GetSecurityDataPointNumberAsync (string identifier, string tag)
        {
             ApiResponse<DataPointNumber> localVarResponse = await GetSecurityDataPointNumberAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Security Data Point (Number) Returns a numeric value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (DataPointNumber)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointNumber>> GetSecurityDataPointNumberAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointNumber");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointNumber");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/number";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityDataPointNumber", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointNumber>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointNumber) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointNumber)));
        }

        /// <summary>
        /// Get Security Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>DataPointText</returns>
        public DataPointText GetSecurityDataPointText (string identifier, string tag)
        {
             ApiResponse<DataPointText> localVarResponse = GetSecurityDataPointTextWithHttpInfo(identifier, tag);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Security Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>ApiResponse of DataPointText</returns>
        public ApiResponse< DataPointText > GetSecurityDataPointTextWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointText");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Security Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of DataPointText</returns>
        public async System.Threading.Tasks.Task<DataPointText> GetSecurityDataPointTextAsync (string identifier, string tag)
        {
             ApiResponse<DataPointText> localVarResponse = await GetSecurityDataPointTextAsyncWithHttpInfo(identifier, tag);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Security Data Point (Text) Returns a text value for the given &#x60;tag&#x60; for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <returns>Task of ApiResponse (DataPointText)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DataPointText>> GetSecurityDataPointTextAsyncWithHttpInfo (string identifier, string tag)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityDataPointText");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityDataPointText");

            var localVarPath = "/securities/{identifier}/data_point/{tag}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityDataPointText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DataPointText>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DataPointText) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DataPointText)));
        }

        /// <summary>
        /// Get Security Historical Data Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20025</returns>
        public InlineResponse20025 GetSecurityHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20025> localVarResponse = GetSecurityHistoricalDataWithHttpInfo(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Security Historical Data Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20025</returns>
        public ApiResponse< InlineResponse20025 > GetSecurityHistoricalDataWithHttpInfo (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityHistoricalData");

            var localVarPath = "/securities/{identifier}/historical_data/{tag}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20025>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20025) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20025)));
        }

        /// <summary>
        /// Get Security Historical Data Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20025</returns>
        public async System.Threading.Tasks.Task<InlineResponse20025> GetSecurityHistoricalDataAsync (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20025> localVarResponse = await GetSecurityHistoricalDataAsyncWithHttpInfo(identifier, tag, type, startDate, endDate, sortOrder, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Security Historical Data Returns historical values for the given &#x60;tag&#x60; and the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="tag">An Intrinio data tag ID or code-name</param>
        /// <param name="type">Filter by type, when applicable (optional)</param>
        /// <param name="startDate">Get historical data on or after this date (optional)</param>
        /// <param name="endDate">Get historical date on or before this date (optional)</param>
        /// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20025)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20025>> GetSecurityHistoricalDataAsyncWithHttpInfo (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityHistoricalData");
            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new ApiException(400, "Missing required parameter 'tag' when calling SecurityApi->GetSecurityHistoricalData");

            var localVarPath = "/securities/{identifier}/historical_data/{tag}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (tag != null) localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
            if (type != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (sortOrder != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityHistoricalData", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20025>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20025) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20025)));
        }

        /// <summary>
        /// Get Stock Price Adjustments for Security Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20027</returns>
        public InlineResponse20027 GetSecurityStockPriceAdjustments (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20027> localVarResponse = GetSecurityStockPriceAdjustmentsWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Price Adjustments for Security Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20027</returns>
        public ApiResponse< InlineResponse20027 > GetSecurityStockPriceAdjustmentsWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPriceAdjustments");

            var localVarPath = "/securities/{identifier}/prices/adjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityStockPriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20027>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20027)));
        }

        /// <summary>
        /// Get Stock Price Adjustments for Security Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20027</returns>
        public async System.Threading.Tasks.Task<InlineResponse20027> GetSecurityStockPriceAdjustmentsAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20027> localVarResponse = await GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo(identifier, startDate, endDate, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Price Adjustments for Security Return stock price adjustments for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return price adjustments on or after the date (optional)</param>
        /// <param name="endDate">Return price adjustments on or before the date (optional)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20027)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20027>> GetSecurityStockPriceAdjustmentsAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPriceAdjustments");

            var localVarPath = "/securities/{identifier}/prices/adjustments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityStockPriceAdjustments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20027>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20027) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20027)));
        }

        /// <summary>
        /// Get Stock Prices for Security Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>InlineResponse20026</returns>
        public InlineResponse20026 GetSecurityStockPrices (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20026> localVarResponse = GetSecurityStockPricesWithHttpInfo(identifier, startDate, endDate, frequency, nextPage);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Stock Prices for Security Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>ApiResponse of InlineResponse20026</returns>
        public ApiResponse< InlineResponse20026 > GetSecurityStockPricesWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPrices");

            var localVarPath = "/securities/{identifier}/prices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityStockPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20026>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20026)));
        }

        /// <summary>
        /// Get Stock Prices for Security Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of InlineResponse20026</returns>
        public async System.Threading.Tasks.Task<InlineResponse20026> GetSecurityStockPricesAsync (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
             ApiResponse<InlineResponse20026> localVarResponse = await GetSecurityStockPricesAsyncWithHttpInfo(identifier, startDate, endDate, frequency, nextPage);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Stock Prices for Security Return stock prices for the Security with the given &#x60;identifier&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
        /// <param name="startDate">Return prices on or after the date (optional)</param>
        /// <param name="endDate">Return prices on or before the date (optional)</param>
        /// <param name="frequency">Return stock prices in the given frequency (optional, default to daily)</param>
        /// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20026)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20026>> GetSecurityStockPricesAsyncWithHttpInfo (string identifier, DateTime? startDate = null, DateTime? endDate = null, string frequency = null, string nextPage = null)
        {
            // verify the required parameter 'identifier' is set
            if (identifier == null)
                throw new ApiException(400, "Missing required parameter 'identifier' when calling SecurityApi->GetSecurityStockPrices");

            var localVarPath = "/securities/{identifier}/prices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (identifier != null) localVarPathParams.Add("identifier", Configuration.ApiClient.ParameterToString(identifier)); // path parameter
            if (startDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
            if (endDate != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
            if (frequency != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
            if (nextPage != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSecurityStockPrices", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20026>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20026) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20026)));
        }

        /// <summary>
        /// Screen Securities Screen securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>List&lt;SecurityScreenResult&gt;</returns>
        public List<SecurityScreenResult> ScreenSecurities (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {
             ApiResponse<List<SecurityScreenResult>> localVarResponse = ScreenSecuritiesWithHttpInfo(logic, orderColumn, orderDirection, primaryOnly);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Screen Securities Screen securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>ApiResponse of List&lt;SecurityScreenResult&gt;</returns>
        public ApiResponse< List<SecurityScreenResult> > ScreenSecuritiesWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {

            var localVarPath = "/securities/screen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderColumn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_column", orderColumn)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_direction", orderDirection)); // query parameter
            if (primaryOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "primary_only", primaryOnly)); // query parameter
            if (logic != null && logic.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logic); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logic; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScreenSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityScreenResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityScreenResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityScreenResult>)));
        }

        /// <summary>
        /// Screen Securities Screen securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of List&lt;SecurityScreenResult&gt;</returns>
        public async System.Threading.Tasks.Task<List<SecurityScreenResult>> ScreenSecuritiesAsync (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {
             ApiResponse<List<SecurityScreenResult>> localVarResponse = await ScreenSecuritiesAsyncWithHttpInfo(logic, orderColumn, orderDirection, primaryOnly);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Screen Securities Screen securities using complex logic
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logic">The logic to screen with, consisting of operators, clauses, and nested groups (optional)</param>
        /// <param name="orderColumn">Results returned sorted by this column (optional)</param>
        /// <param name="orderDirection">Sort order to use with the order_column (optional, default to asc)</param>
        /// <param name="primaryOnly">Return only primary securities (optional, default to false)</param>
        /// <returns>Task of ApiResponse (List&lt;SecurityScreenResult&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SecurityScreenResult>>> ScreenSecuritiesAsyncWithHttpInfo (SecurityScreenGroup logic = null, string orderColumn = null, string orderDirection = null, bool? primaryOnly = null)
        {

            var localVarPath = "/securities/screen";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (orderColumn != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_column", orderColumn)); // query parameter
            if (orderDirection != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "order_direction", orderDirection)); // query parameter
            if (primaryOnly != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "primary_only", primaryOnly)); // query parameter
            if (logic != null && logic.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(logic); // http body (model) parameter
            }
            else
            {
                localVarPostBody = logic; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScreenSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SecurityScreenResult>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SecurityScreenResult>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SecurityScreenResult>)));
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>InlineResponse20024</returns>
        public InlineResponse20024 SearchSecurities (string query)
        {
             ApiResponse<InlineResponse20024> localVarResponse = SearchSecuritiesWithHttpInfo(query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>ApiResponse of InlineResponse20024</returns>
        public ApiResponse< InlineResponse20024 > SearchSecuritiesWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SecurityApi->SearchSecurities");

            var localVarPath = "/securities/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20024>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20024) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20024)));
        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of InlineResponse20024</returns>
        public async System.Threading.Tasks.Task<InlineResponse20024> SearchSecuritiesAsync (string query)
        {
             ApiResponse<InlineResponse20024> localVarResponse = await SearchSecuritiesAsyncWithHttpInfo(query);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search Securities Searches for Securities matching the text &#x60;query&#x60;
        /// </summary>
        /// <exception cref="Intrinio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="query"></param>
        /// <returns>Task of ApiResponse (InlineResponse20024)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20024>> SearchSecuritiesAsyncWithHttpInfo (string query)
        {
            // verify the required parameter 'query' is set
            if (query == null)
                throw new ApiException(400, "Missing required parameter 'query' when calling SecurityApi->SearchSecurities");

            var localVarPath = "/securities/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
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

            if (query != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "query", query)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key", Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SearchSecurities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20024>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20024) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20024)));
        }

    }
}
