using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data.Entities
{
    public class GenericUser : AbstractAuditableEntity
    {
        private UInt32 m_userId;
        private String m_userName;

        public UInt32 UserId
        {
            get { return m_userId; }
        }

        public String UserName
        {
            get { return m_userName; }
            set { m_userName = value; }
        }

        public GenericUser()
        {
            m_userId = 0;
            m_userName = "Anonymous";
        }
    }
}
