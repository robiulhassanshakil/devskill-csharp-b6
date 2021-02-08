using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public abstract class NodeBase<P, INode> : INode<P, INode> where P : class

    {
        public virtual string property1 { get; private set; }
        public void Add(P item)
        {
            throw new NotImplementedException();
        }

        public void Remove(P item)
        {
            throw new NotImplementedException();
        }

        public abstract void GetCount();
    }


}
