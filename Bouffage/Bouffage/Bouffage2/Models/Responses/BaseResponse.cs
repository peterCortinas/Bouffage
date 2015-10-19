using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bouffage2.Web.Responses
{
    public abstract class BaseResponse
    {
        public bool IsSuccessFull { get; set; }

        public string TransactionId { get; set; }

        public BaseResponse()
        {
            //Bouffage: This TxId we are just faking to demo the purpose
            this.TransactionId = Guid.NewGuid().ToString();
        }
    }
}