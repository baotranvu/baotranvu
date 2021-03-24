using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendClass
{
    public class Group
    {
        private int adminid;
        private int groupId;
        private ClientList<Client> members;

        public int GroupID
        {
            get { return groupId; }
            set { groupId = value; }
        }
        public ClientList<Client> Memebers
        {
            get { return members; }
            set { members = value; }
        }
        public Group(int gpid, int adid)
        {
            adminid = adid;
            groupId = gpid;
            members = null;

        }
        public int AdminID
        {
            get { return adminid; }
            set { adminid = value; }
        }
        public bool AddMember(Client c)
        {
            members.Add(c);
            return true;
        }
        public bool KickMembers(string name)
        {
            if(members.Count > 0)
            {
                foreach(Client c in members)
                {
                    if(c.Name.Equals(name))
                    {
                        members.Remove(c);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
