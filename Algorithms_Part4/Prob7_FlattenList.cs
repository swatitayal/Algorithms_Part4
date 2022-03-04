using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Part4
{
    class Prob7_FlattenList
    {
        static void Main7(string[] args)
        {
           
            

        }

        static void flattenList()
        {
            Node<int> x = new Node<int>(25);
            Node<int> y = new Node<int>(15);
            Node<int> z = new Node<int>(5);

            int result = findMinimumNode(x, y, z);

            if (result == 1)
            {
                Console.WriteLine("Right is minimum");
            }
            else if (result == 2)
            {
                Console.WriteLine("Bottom is minimum");
            }
            else if (result == 3)
            {
                Console.WriteLine("LeftOver is minimum");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }


        static int findMinimumNode(Node<int> right, Node<int> bottom, Node<int> leftOver)
        {
            int r = right.data;
            int b = bottom.data;
            int l = leftOver.data;

            Console.WriteLine("Right: " + r + "\nBottom: " + b + "\nLeftOver: " + l);

            if (right.data < bottom.data)
            {
                if (right.data < leftOver.data)
                    return 1;
                else
                {
                    if (leftOver.data < bottom.data)
                        return 3;
                    else
                        return 2;
                }
            }
            else
            {
                if (leftOver.data < bottom.data)
                   return 3;
                else
                    return 2;
            }
        }
    }
}
