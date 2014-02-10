using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductService.Models
{
    public interface IUser
    {
        int Id { get; }
        int OrgId { get; }
    }

    public class User : IUser
    {
        private readonly int id;
        private readonly int orgId;

        public User(int id, int orgId)
        {
            this.id = id;
            this.orgId = orgId;
        }

        public int Id
        {
            get { return this.id; }
        }

        public int OrgId
        {
            get { return this.orgId; }
        }

    }

    public class DummyUser : IUser
    {
        public int OrgId
        {
            get { return 2; }
        }

        public int Id
        {
            get { return 1; }
        }
    }

    public class OtherUser : IUser
    {
        public int Id
        {
            get { return 1; }
            
        }

        public int OrgId
        {
            get { return 1; }
        }
    }
}