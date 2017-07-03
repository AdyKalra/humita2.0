using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zukini.API.Examples.Features.Ccmsi.MobileApi.Response
{
    public class RootObject
    {
        public List<object> errors { get; set; }
        public Result result { get; set; }
    }
}
