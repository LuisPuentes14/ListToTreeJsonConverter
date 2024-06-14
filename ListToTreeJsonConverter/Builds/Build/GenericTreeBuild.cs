using ListToTreeJsonConverter.Builds.Build.Interfaces;
using ListToTreeJsonConverter.Builds.Objects;
using ListToTreeJsonConverter.Objects;

namespace ListToTreeJsonConverter.Builds.Build
{
    public class GenericTreeBuild : IGenericTree
    {
        private GenericTree genericTree = new GenericTree();
        private List<TreeBuilder> ListConvertTree;

        public GenericTreeBuild(List<TreeBuilder> ListConvertTree)
        {
            this.ListConvertTree = ListConvertTree;
        }

        public GenericTree Build()
        {
            return genericTree;
        }

        public void ListconvertedTreeBuild()
        {
            genericTree.ListconvertedTree = GetTree(genericTree.ListConvertTree.Where(x => x.FatherId == null).ToList());
        }

        public void ListConvertTreeBuild()
        {
            genericTree.ListConvertTree = ListConvertTree;
        }

        private List<TreeBuilder> GetTree(List<TreeBuilder> objects)
        {

            foreach (var obj in objects)
            {
                List<TreeBuilder> objectsTree;

                objectsTree = genericTree.ListConvertTree.Where(x => x.FatherId == obj.Id).ToList();

                if (objectsTree.Count() > 0)
                {
                    foreach (var objectTree in objectsTree)
                    {
                        obj.Values.Add(objectTree);
                    }

                    GetTree(objectsTree);
                }
            }

            return objects;
        }
    }
}
