using MediatR;
using Microsoft.Extensions.Configuration;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol;
using OmniSharp.Extensions.LanguageServer.Protocol.Server;
using System.Threading;
using System.Threading.Tasks;

namespace Thousand.LSP.Extensions
{
    class PreviewHandler : IJsonRpcNotificationHandler<BeginPreview>
    {
        private readonly ILanguageServerConfiguration configuration;

        public PreviewHandler(ILanguageServerConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<Unit> Handle(BeginPreview request, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }

       
    }
}
