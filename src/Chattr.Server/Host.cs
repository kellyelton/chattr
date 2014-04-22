using System;
using System.Threading.Tasks;

namespace Chattr.Server
{
    public class Host : IRunnable
    {
        public bool IsRunning { get { return Listener.IsRunning; } }

        private IListener Listener { get; set; }
        private IMessageProcessor Processor { get; set; }

        public Host(IListener listener, IMessageProcessor processor)
        {
            if (listener == null)
                throw new ArgumentNullException("listener");
            if(processor == null)
                throw new ArgumentNullException("processor");
            Listener = listener;
        }

        public async Task Start()
        {
            if (Listener.IsRunning)
                return;
            await Listener.Start();
        }

        public async Task Stop()
        {
            if (Listener.IsRunning == false)
                return;
            await Listener.Stop();
        }
    }
}