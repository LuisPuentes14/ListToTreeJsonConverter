using ListToTreeJsonConverter.Builds.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToTreeJsonConverter.Builds.Build.Interfaces
{
    public interface IGenericTree
    {
        void ListConvertTreeBuild();
        void ListconvertedTreeBuild();
        GenericTree Build();

    }
}
