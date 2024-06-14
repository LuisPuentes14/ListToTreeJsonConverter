using ListToTreeJsonConverter.Builds.Build.Interfaces;
using ListToTreeJsonConverter.Builds.Objects;

namespace ListToTreeJsonConverter.Builds.Directors
{
    public class GenericTreeDirector
    {

        public GenericTree Construct(IGenericTree genericTree)
        {
            genericTree.ListConvertTreeBuild();
            genericTree.ListconvertedTreeBuild();
            return genericTree.Build();

        }

    }
}
