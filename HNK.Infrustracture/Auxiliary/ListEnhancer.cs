using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HNK.Infrustracture.Auxiliary
{
    public class ListEnhancer<E>
    {
        private int m_currentPage;
        private int m_pageSize;
        private List<E> m_entityList;

        public int CurrentPage
        {
            get { return m_currentPage; }
            private set { m_currentPage = value; }
        }
        public int PageSize
        {
            get { return m_pageSize; }
            private set { m_pageSize = value; }
        }
        public List<E> EntityList
        {
            get { return m_entityList; }
            private set { m_entityList = value; }
        }

        public ListEnhancer(List<E> EntityList, int PageSize)
        {
            m_pageSize = PageSize;
            m_entityList = EntityList;
            m_currentPage = 0;
        }

        public List<E> First()
        {
            if (m_entityList == null)
                return null;
            else
                return m_entityList.Take<E>(m_pageSize).ToList<E>();
        }

        public List<E> NextPage()
        {
            List<E> result = new List<E>();
            int counter = 0,
                flag = m_currentPage * m_pageSize;
            while (counter < m_pageSize)
            {
                if (m_entityList.Count > flag)
                {
                    var e = m_entityList[flag];
                    result.Add(e);
                    counter++;
                    flag++;
                }
                else break;
            }
            m_currentPage++;
            return result;
        }

        public List<E> LastPage()
        {
            List<E> result = new List<E>();
            int counter = 0,
                flag = m_currentPage * m_pageSize;
            while (counter < m_pageSize)
            {
                if (flag >= 1)
                {
                    var e = m_entityList[flag - 1];
                    result.Add(e);
                    counter++;
                    flag--;
                }
                else break;
            }
            m_currentPage++;
            return result;
        }

        public void Update(List<E> NewData, bool reset)
        {
            m_entityList = NewData;
            if (reset)
                Reset();
        }

        public void Reset()
        {
            m_currentPage = 0;
        }

        public bool HasNext()
        {
            return (m_currentPage * m_pageSize < m_entityList.Count);
        }
    }
}
