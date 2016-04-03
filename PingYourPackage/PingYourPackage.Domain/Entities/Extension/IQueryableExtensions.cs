﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingYourPackage.Domain.Entities.Core;
namespace PingYourPackage.Domain.Entities.Extension
{
    public static class IQueryableExtensions
    {
        public static PaginatedList<T> ToPaginatedList<T>(
            this IQueryable<T> query, int pageIndex, int pageSize)
        {
            var totalCount = query.Count();
            var collection = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return new PaginatedList<T>(
                pageIndex, pageSize,
                totalCount, collection);
        }
    }
}
