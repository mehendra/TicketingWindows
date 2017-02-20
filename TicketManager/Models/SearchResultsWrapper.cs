using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SearchResultsWrapper<T>
    {
        public IEnumerable<T> Results { get; set;}
        public int RecordCiount { get; set; }
    }
}
