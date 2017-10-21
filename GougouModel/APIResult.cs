using System;
using System.Collections.Generic;
using System.Text;

namespace GougouModel
{
    public class APIResult
    {
        public APIResult(bool success, string message)
            : this(success)
        {
            this.success = success;
            this.message = message;
        }

        public APIResult(object data)
            : this(true)
        {
            this.data = data;
        }

        public APIResult(bool success)
        {
            this.success = success;
        }


        public bool success { get; set; }

        public object data { get; set; }

        public string message { get; set; }
    }
}
