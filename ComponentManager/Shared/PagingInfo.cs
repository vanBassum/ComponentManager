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

        public static PagingInfo<T> Create(IEnumerable<T> data, int page, int size)
        {
            int total = data.Count();
            if (page < 0)
                page = 0;
            if(page * size > total)
                page = total / size;
            PagingInfo<T> response = new PagingInfo<T>();
            response.CurrentPage = page;
            response.PageSize = size;
            response.TotalPages = (total + size - 1) / size;
            response.Data = data.Skip(page * size).Take(size).ToArray();
            return response;
        }
    }
}