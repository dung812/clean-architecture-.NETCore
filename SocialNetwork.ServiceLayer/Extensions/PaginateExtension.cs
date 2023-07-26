using SocialNetwork.Dto.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.ServiceLayer.Extensions
{
    public static class PaginateExtension
    {
        public static PagedList<TModel> Paginate<TModel>(this IQueryable<TModel> entities, int pageNumber, int pageSize)
        {
            var paged = new PagedList<TModel>();
            pageNumber = (pageNumber < 0) ? 1 : pageNumber;

            paged.CurrentPage = pageNumber;
            paged.PageSize = pageSize;

            var startRow = (pageNumber - 1) * pageSize;

            paged.Items = entities.Skip(startRow).Take(pageSize).ToList();

            paged.TotalItems = entities.Count();

            paged.TotalPages = ((paged.TotalItems - 1) / pageSize) + 1;

            return paged;
        }
    }
}
