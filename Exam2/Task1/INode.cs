using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public interface INode<I,H>where I:class
    {
        void Add(I item);
        void Remove(I item);
    }
}
