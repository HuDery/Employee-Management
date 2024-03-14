using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Heper
{
    public class Pagination<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }

        public Pagination(List<T> list, int count, int currentPage, int pageSize)
        {
            CurrentPage = currentPage;
            TotalPage = (int) Math.Ceiling(count/ (double) pageSize);
            AddRange(list);
        }

        public static Pagination<T> Paging(IQueryable<T> source, int currentPage, int pageSize)
        {
            var count = source.Count();
            var list = source.Skip((currentPage-1)*pageSize).Take(pageSize).ToList();
            return new Pagination<T>(list, count, currentPage, pageSize);
        }
    }
}
