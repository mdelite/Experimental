using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Utility
{
    public class CSVService<T>
    {
        DataTable _dt;
        public CSVService()
        {
            _dt = new DataTable();

            var headers = typeof(T).GetMembers()
                .Where(x => x.MemberType.HasFlag(MemberTypes.Field) || x.MemberType.HasFlag(MemberTypes.Property))
                .Select(x => x.Name);

            headers.ToList()
                .ForEach(x => _dt.Columns.Add(x, typeof(string)));
        }

        public CSVService(T obj) : this();
        {
            this.Add(obj);
        }
        
        public void Add<T>(T obj)
        {
            
        }
    }
}
