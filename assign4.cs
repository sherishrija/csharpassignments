using Stacks;
using System;
namespace Stacks
{
    class MyStack
    {
        private int[] ele;
            private int top;
        private int max;

        public MyStack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int item)
        {
            try 
            {
                ele[top++] = item;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }

        }
        public int Pop()
        {
            Console.WriteLine("popped element is:" + ele[top]);
            return ele[top--];
        }
        public void PrintStack()
        { 
            if (top == -1)
            {
                 Console.WriteLine("stack is empty");
                return;

            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                Console.WriteLine("Item[" + (i + 1) + "]:" + ele[i]);
                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        StackException se = new StackException();
        se.Method();
        Console.ReadLine();
    }
}
class StackException
{
    public void Method()
    {
        MyStack S = new MyStack(5);
        S.Push(10);
        S.Push(20);
        S.Push(30);
        S.Push(40);
        S.Push(50);

        Console.WriteLine("items are:");
        S.PrintStack();

        S.Pop();
        S.PrintStack();
        S.Push(50);
        S.Push(60);
    }
}