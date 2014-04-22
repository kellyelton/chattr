using System.Threading.Tasks;

namespace Chattr.Server
{
    public interface IRunnable
    {
        bool IsRunning { get; }

        Task Start();
        Task Stop();
    }
}