using Microsoft.AspNetCore.SignalR;

namespace MainSignalServer
{
    public class MainHub : Hub
    {
        public async IAsyncEnumerable<DateTime> Streaming(CancellationToken cancellationToken)
        {
            while (true)
            {
                yield return DateTime.Now;
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}
