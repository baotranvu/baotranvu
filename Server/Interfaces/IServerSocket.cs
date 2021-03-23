using System;


namespace Interfaces
{
    public interface IServerSocket
    {
        void Init();
        void SendCallback(IAsyncResult iar);
        void ReceiveCallback(IAsyncResult iar);
        void Disconnect(object sender, EventArgs e);
        
    }
}
