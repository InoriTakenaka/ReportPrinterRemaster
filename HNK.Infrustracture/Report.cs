using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HNK.Infrustracture
{
    public abstract class Report
    {
        protected DbAccessLayer m_dbAccess;
        public
            Report(DbAccessLayer dbAccess)
        {
            m_dbAccess = dbAccess;
        }
    }
}
