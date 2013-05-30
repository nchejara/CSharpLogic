using System;
using System.Text;
using System.Threading.Tasks;
using WicresoftDev.CSharpLogic.Stacks;

namespace WicresoftDev.CSharpLogic.Stacks
{
    public class StackLogic
    {
        public class Stack
        {
            private const int maxSize = 15;
            private Object[] element = new Object[15];
            private int currentElement = -1;
            // Set Instance property so user can use all method whithout creating Object of class
            private static Stack instance = new Stack();
            public static Stack Instance
            {
                get { return instance; }
            }
            
            /// <summary>
            /// Add item in the stack
            /// </summary>
            /// <param name="item"></param>
            public void Push(Object item)
            {
                currentElement++;

                if (IsFullStack())
                {
                    throw new InvalidOperationException("Stack is full! It unable to fullfill your push request on " + currentElement + " index.");
                }
                
                element[currentElement] = item;
            }

            /// <summary>
            /// Retrived item from the stack based on the current pointer
            /// </summary>
            /// <returns></returns>
            public Object Pop()
            {
                if (IsEmptyStack())
                {
                    throw new InvalidOperationException("Stack is empty! It unable to fullfill your pop request on " + currentElement + " index");
                }

                Object popItem = element[currentElement];
                element[currentElement] = null;
                currentElement--;

                return popItem;
            }

            /// <summary>
            /// Retrive current pointer item from the stack
            /// </summary>
            /// <returns></returns>
            public Object Peek()
            {
                if (IsEmptyStack())
                {
                    throw new InvalidOperationException("Stack is empty! It unable to fullfill your peek request on " + currentElement + " index");
                }

                return element[currentElement];
            }

            /// <summary>
            /// Verify stack have the enough space to do Push Operation!
            /// </summary>
            /// <returns></returns>
            private bool IsFullStack()
            {
                if (currentElement > maxSize - 1)
                    return true;

                return false;
            }

            /// <summary>
            /// Return true if stack is empty!
            /// </summary>
            /// <returns></returns>
            private bool IsEmptyStack()
            {
                if (currentElement < 0)
                    return true;

                return false;
            }
        }

        //[To Do]: Other funcation ...
    }
}
