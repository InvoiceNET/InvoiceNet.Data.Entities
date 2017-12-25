using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data.Entities
{
    public abstract class AbstractAuditableEntity
    {
        private String m_createdBy;
        private DateTime m_createdAt;
        private String m_updatedBy;
        private DateTime m_updatedAt;

        public String CreatedBy
        {
            get { return m_createdBy; }
        }

        public DateTime CreatedAt
        {
            get { return m_createdAt; }
        }

        public String UpdatedBy
        {
            get { return m_updatedBy; }
        }

        public DateTime UpdatedAt
        {
            get { return m_updatedAt; }
        }
    }
}
