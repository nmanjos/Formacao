using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class ErrorHandler
    {
        private int number;
        private string description;
        private string appname;
        private string type;
        public ErrorHandler(Exception e)
        {
            number = e.HResult;
            type = e.GetType().ToString();
            appname = e.Source;
            description = e.Message;
        }
    }
}
