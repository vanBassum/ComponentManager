using System.Linq.Expressions;

namespace ComponentManager.Server
{
    public static class Utils
    {
        public static IQueryable<T> OrderDynamic<T>(this IQueryable<T> Data, string propertyName, bool desc = false)
        {
            var param = Expression.Parameter(typeof(T));
            var memberAccess = Expression.Property(param, propertyName);
            var convertedMemberAccess = Expression.Convert(memberAccess, typeof(object));
            var orderPredicate = Expression.Lambda<Func<T, object>>(convertedMemberAccess, param);

            if (desc)
                return Data.AsQueryable().OrderBy(orderPredicate);
            else
                return Data.AsQueryable().OrderByDescending(orderPredicate);
        }
    }
}
