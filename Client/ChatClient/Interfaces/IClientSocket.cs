using System;
using System.Collections.Generic;
using System.Net;

namespace Interfaces
{
    public interface IClientSocket
    {

        void Login(string user,string pass);
        void Register(string user, string pass);
        void Disconnet();
        void Send(string mess,string recv);
        void SendCallback(IAsyncResult iar);
        void ReceiveCallback(IAsyncResult iar);

    }
}
