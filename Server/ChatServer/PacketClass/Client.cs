using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ExtendClass
{
    public class Client
    {
        private EndPoint endpoint;
        private string name;
        private string password;

        public EndPoint endPoint
        {
            get { return endpoint; }
            set { endpoint = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Pass
        {
            get { return password; }
            set { password = value; }
        }
            
    }
}
