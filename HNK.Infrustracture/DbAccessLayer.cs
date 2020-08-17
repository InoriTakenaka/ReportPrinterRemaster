using System;
using System.Collections.Generic;

namespace HNK.Infrustracture
{
    public abstract class DbAccessLayer
    {
        public abstract int Insert<E>(E e) where E:Entity,new();
        public abstract int Insert<E>(List<E> EntityCollection) where E:Entity,new() ;
        public abstract List<E> Select<E>(string querySQL) where E : Entity,new();
        public abstract E Find<E>(string querySQL) where E : Entity, new();
        public abstract int Update<E>(string condition, E e) where E : Entity,new();
        public abstract Boolean Exist(string fieldName, string fieldValue, string tableName);
        public abstract int ExcuteSqlNonQuery(string commandText);
        public abstract System.Data.DataTable ExcuteDataTable(string commandText);
    }
}
