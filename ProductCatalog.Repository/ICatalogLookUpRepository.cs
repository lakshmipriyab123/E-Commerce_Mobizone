﻿using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Repository
{
    public interface ICatalogLookUpRepository : IGenericService<LookUp>
    {
       // Task<IEnumerable<string>> GetByParentId(LookUpId id);
    }
}
