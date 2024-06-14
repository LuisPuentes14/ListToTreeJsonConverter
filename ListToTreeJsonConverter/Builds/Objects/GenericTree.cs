using ListToTreeJsonConverter.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToTreeJsonConverter.Builds.Objects
{
    public class GenericTree
    {
        public List<TreeBuilder> ListConvertTree { get; set; } = new List<TreeBuilder>();
        public List<TreeBuilder> ListconvertedTree { get; set; } = new List<TreeBuilder>();

    }
}
