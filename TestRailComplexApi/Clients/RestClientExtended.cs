using RestSharp;
using RestSharp.Authenticators;
using System.Diagnostics;
using TestRailComplexApi.Helpers.Configuration;
using NLog;
using AngleSharp.Html.Dom;

namespace TestRailComplexApi.Clients
{
    public sealed class RestClientExtended
    {
        private readonly RestClient _client;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public RestClientExtended()
        {
            var option = new RestClientOptions(Configurator.AppSettings.URI ?? throw new InvalidOperationException())
            {
                Authenticator =
                    new HttpBasicAuthenticator(Configurator.Admin.Username, Configurator.Admin.Password)
            };

            _client = new RestClient(option);
            Debug.Assert(Configurator.Admin != null, "Configurator.Admin != null");
        }

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }

        private void LogRequest(RestRequest request)
        {
            _logger.Debug($"{request.Method} request to: {request.Resource}");

            var body = request.Parameters
                .FirstOrDefault(p => p.Type == ParameterType.RequestBody)?.Value;

            if (body != null)
            {
                _logger.Debug($"body: {body}");
            }
        }

        private void LogResponce(RestResponse responce)
        {
            if (responce.ErrorException != null)
            {
                _logger.Error($"Error in the responce\n {responce.ErrorException.Message}");
            }


            _logger.Debug($"request tofinished with status code:  {responce.StatusCode}");


            if (!string.IsNullOrEmpty(responce.Content))
            {
                _logger.Debug(responce.Content);
            }
        }

        public async Task<RestResponse> ExecuteAsync(RestRequest request)
        {
            LogRequest(request);
            var responce = await _client.ExecuteAsync(request);
            LogResponce(responce);

            return  responce;
        }

        public async Task<T> ExecuteAsync<T>(RestRequest request)
        {
            LogRequest(request);
            var responce = await _client.ExecuteAsync<T>(request);
            LogResponce(responce);

            return responce.Data ?? throw new InvalidOperationException();
        }

    }
}
