using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bouffage2.Web.Responses
{
    public class ItemResponse<T> : SuccessResponse
    {
        public T Item { get; set; }
    }
}