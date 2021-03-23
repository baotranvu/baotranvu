using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;


namespace Interfaces
{
    public interface IPacket
    {
        DataIdentifier dataIdentifier { get; set; }
        string Sender { get; set; }
        byte[] GetDataStream();

    }
}
