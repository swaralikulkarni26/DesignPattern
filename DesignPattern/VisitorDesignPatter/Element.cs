using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPatter
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
