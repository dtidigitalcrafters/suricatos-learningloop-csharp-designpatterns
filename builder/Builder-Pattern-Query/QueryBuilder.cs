using System;
using System.Collections.Generic;
using System.Text;

namespace builder
{
    class QueryBuilder
    {
        string tableName;
        string select;
        string where;
        string orderBy;

        public QueryBuilder(string tableName)
        {
            this.tableName = tableName;
            select = "";
            where = "";
            orderBy = "";
        }

        public void CreateSelect(IEnumerable<string> listColumns)
        {
            if (select.Length > 0)
            {
                foreach (var column in listColumns)
                {
                    select += column + ',';
                }
                select = select.Remove(select.Length - 1);
            }
        }

        public void CreateSelectAll() => select = "*";


        public void CreateWhere(string where)
        {
            this.where = where;
        }

        public void CreateOrderBy(string column, bool descending = false)
        {
            if (orderBy.Length > 0)
            {
                orderBy += ", ";
            }
            string order = descending ? "DESC" : "ASC";
            orderBy += $"{column} {order}";

        }

        public string Build()
        {
            select = select.Length == 0 ? "*" : select;

            string query = $"select {select} from {tableName}";
            if (where.Length > 0)
            {
                query += $" where {where}";
            }
            if (orderBy.Length > 0)
            {
                query += $" order by {orderBy}";
            }
            return query;
        }
            
    }
}
