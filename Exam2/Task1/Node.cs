using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class Node<T, INode>:NodeBase<T, INode>where T:class
    {
        private string _property;
        public override string property1
        {
            get
            {
                return _property;
            }
            set
            {
                _property = value;
            }

        }


        public override void GetCount()
        {

        }

        public void Add(string[] a)
        {

        }

        public void Remove(string[] b)
        {

        }

        
    }
}
