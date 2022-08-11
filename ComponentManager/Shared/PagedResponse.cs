using System.Collections;

namespace ComponentManager.Shared
{
    public class PagingInfo
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }


    public class PagingInfo<T> : PagingInfo
    {
        public T[] Data { get; set; }


        public PagingInfo()
        {

        }

        public static PagingInfo<T> Create(IEnumerable<T> data, int currentPage, int pageSize)
        {
            PagingInfo<T> response = new PagingInfo<T>();
            response.CurrentPage = currentPage;
            response.PageSize = pageSize;
            response.TotalPages = (data.Count() + pageSize - 1) / pageSize;
            response.Data = data.Skip(currentPage * pageSize).Take(pageSize).ToArray();
            return response;
        }
    }
}