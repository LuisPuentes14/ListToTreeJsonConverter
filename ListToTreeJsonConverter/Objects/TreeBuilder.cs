using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToTreeJsonConverter.Objects
{
    public class TreeBuilder
    {
        public int Id { get; set; }

        public int? FatherId { get; set; }

        public List<TreeBuilder> Values { get; set; } = new List<TreeBuilder>();

    }
}
