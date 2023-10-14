using handMadeShop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace handMadeShop.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}