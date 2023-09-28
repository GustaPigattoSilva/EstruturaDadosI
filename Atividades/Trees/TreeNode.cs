using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace é uma caixa de ferramentas
//As classes são as ferramentas
namespace Trees
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        //Atributo recursivo
        public TreeNode<T> Parent { get; set; }
        //Lista com variável chamada de tipo recursivo
        public List< TreeNode<T> > Children { get; set; }

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            
            return height;
        }
    }
}