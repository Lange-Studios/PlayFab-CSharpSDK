using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayFab
{
    /// <summary>
    /// Interface of any transport SDK plugin.
    /// </summary>
    public interface ITransportPlugin : IPlayFabPlugin
    {
        Task<object> DoPost<T>(string fullPath, T request, Dictionary<string, string> headers);
    }
}