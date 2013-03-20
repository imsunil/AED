using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }

        [Fact]
        public void CreateEmptyStack_Succeeds()
        {
            Stack stack = new Stack();
                        
            Assert.Equal(0,stack.list.Count());
        }

        [Fact]
        public void PushIncrementsCount_Succeeds()
        {
            Stack stack = new Stack();
            stack.Push(42);

            Assert.Equal(1, stack.list.Count());
        }

        [Fact]
        public void PopOnEmptyStack_Throws()
        {
            Stack stack = new Stack();

            //Exception ex = Record.Exception(() => stack.Pop());

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void PopReturnsTop_Succeeds()
        {
            Stack stack = new Stack();
            stack.Push(42);
            //Exception ex = Record.Exception(() => stack.Pop());

            Assert.Equal(42, stack.Pop());
        }


        [Fact]
        public void PeekDoesNotDecrement_Succeeds()
        {
            Stack stack = new Stack();
            stack.Push(42);
            //Exception ex = Record.Exception(() => stack.Pop());

            Assert.Equal(42, stack.Peek());
            Assert.Equal(1, stack.list.Count());
        }

    }

    public class Stack
    {
        public List<int> list = new List<int>();
        int count = 0;

        public void Push(int p)
        {
           list.Insert(list.Count(), p);
        }

        public int Pop()
        {
           if (list.Count() == 0) throw new InvalidOperationException();

           int re = list[list.Count()-1];
           list.RemoveAt(list.Count()-1);
           
           return re;

        }

        public int Peek()
        {
            if (list.Count() == 0) throw new InvalidOperationException();
            int re = list[list.Count() - 1];
            
            return re;
        }
    }
   

