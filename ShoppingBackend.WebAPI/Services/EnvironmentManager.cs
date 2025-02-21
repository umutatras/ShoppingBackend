using ShoppingBackend.Application.Common.Interfaces;

namespace ShoppingBackend.WebAPI.Services
{
    public sealed class EnvironmentManager : IEnvironmentService
    {
        public string WebRootPath { get; }
        public EnvironmentManager(string webRootPath)
        {
            WebRootPath = webRootPath;
        }
    }
}
