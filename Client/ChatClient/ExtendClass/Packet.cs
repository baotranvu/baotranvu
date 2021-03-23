using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net;
using Interfaces;
using Enums;

namespace ExtendClass
{

   

    public  class Packet : IPacket
    {
        // ----------------
        // Packet Structure
        // ----------------

        // Description   -> |dataIdentifier|sender length|receiver length|message length|    sender   |   receiver    |    message   |
        // Size in bytes -> |       4      |     4       |       4       |      4       |sender length|receiver length|message length|
        #region Private Members
        private DataIdentifier identifier;
        private string sender;
        private string receiver;
        private string message;
        #endregion

        #region Public Properties
        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public DataIdentifier dataIdentifier
        {
            get { return identifier; }
            set { identifier = value; }
        }
        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        #endregion
        #region Methods
        //Default Contructor
        public Packet()
        {
            identifier = DataIdentifier.Null;
            message = null;
            sender = null;
            receiver = null;
        }
        
        
        public Packet(byte[] dataStream)
        {
            //Read the dataIdentifer from the begining of stream ( 4 bytes)
            this.identifier = (DataIdentifier)BitConverter.ToInt32(dataStream, 0);

            //Read the length of the sender name ( 4 bytes )
            int sendLength = BitConverter.ToInt32(dataStream, 4);

            //Read the length of the receiver name ( 4 bytes)
            int recvLength = BitConverter.ToInt32(dataStream, 8); 

            // Read the length of the message ( 4 bytes )
            int msgLength = BitConverter.ToInt32(dataStream, 12);

            // // Read the sender field
            if (sendLength > 0)
                this.sender = Encoding.UTF8.GetString(dataStream, 16, sendLength);
            else
                this.sender = null;

            // Read the receiver field
            if (recvLength > 0)
                this.receiver = Encoding.UTF8.GetString(dataStream, 16 + sendLength, recvLength);
            else
                this.receiver = null;

            //Read the messgae field
            if (msgLength > 0)
                this.message = Encoding.UTF8.GetString(dataStream, 16 + sendLength + recvLength, msgLength);
            else
                this.message = null;
        }

        

        // Converts the packet into a byte array for sending/receiving 
        public byte[] GetDataStream()
        {
            List<byte> dataStream = new List<byte>();

            // Add the dataIdentifier
            dataStream.AddRange(BitConverter.GetBytes((int)this.identifier));

            // Add the name length
            if (this.sender != null)
                dataStream.AddRange(BitConverter.GetBytes(this.sender.Length));
            else
                dataStream.AddRange(BitConverter.GetBytes(0));

            //Add the receiver length
            if (this.receiver != null)
                dataStream.AddRange(BitConverter.GetBytes(this.receiver.Length));
            else
                dataStream.AddRange(BitConverter.GetBytes(0));

            // Add the message length
            if (this.message != null)
                dataStream.AddRange(BitConverter.GetBytes(this.message.Length));
            else
                dataStream.AddRange(BitConverter.GetBytes(0));

            // Add the sender
            if (this.sender != null)
                dataStream.AddRange(Encoding.UTF8.GetBytes(this.sender));

            //Add the receiver
            if (this.receiver != null)
                dataStream.AddRange(Encoding.UTF8.GetBytes(this.receiver));

            // Add the message
            if (this.message != null)
                dataStream.AddRange(Encoding.UTF8.GetBytes(this.message));

            return dataStream.ToArray();
            #endregion
        }
    }
}


