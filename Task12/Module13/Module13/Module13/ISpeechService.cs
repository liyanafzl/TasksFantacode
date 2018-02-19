using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    public interface ISpeechService
    {
        Task<string> FetchTokenAsync(string fetchUri, string apiKey);
        Task<string> SendRequestAsync(Stream fileStream, string url, string bearerToken, string contentType);
        Task<string> RecognizeSpeechAsync(string filename);
        string GenerateRequestUri(string speechEndpoint);

    }
}
