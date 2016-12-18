﻿using System.Collections.Generic;

namespace squirrel.Nodes
{
    public class SymbolicExpressionNode : INode
    {
        public readonly List<INode> Children;

        public SymbolicExpressionNode(List<INode> children)
        {
            Children = children;
        }

        public override string ToString()
        {
            return $"({string.Join(" ", Children)})";
        }
    }
}