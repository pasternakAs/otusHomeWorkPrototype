using otusHomeWorkPrototype.Prototype;

namespace otusHomeWorkPrototype.TestClass.Documents
{
    public abstract class DocumentClass : IMyCloneable<DocumentClass>
    {
        public string NumDocument { get; set; }
        public string DateDocument { get; set; }

        public abstract DocumentClass ShallowClone();
        public abstract DocumentClass DeepClone();

        public abstract object Clone();
    }
}
