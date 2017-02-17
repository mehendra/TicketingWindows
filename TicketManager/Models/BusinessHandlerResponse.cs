using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BusinessHandlerResponse<T>
    {
        public bool IsASuccess { get; set; }
        public List<string> Errors { get; set; }

        public T ItemResuested { get; set; }

    }
}
