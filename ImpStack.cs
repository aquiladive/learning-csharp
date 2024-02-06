//Program to implement stack in C#.

using System;

public class Impstack {
    static void Main(string[] args) {
        stack st = new stack();
        while(true) {
            Console.WriteLine("\nStack MENU (size -- 6)");
            Console.WriteLine("1. Push --> Add an element");
            Console.WriteLine("2. Pop --> Remove an element");
            Console.WriteLine("3. Display --> Print all elements");
            Console.WriteLine("4. Exit");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice) {
                case 1:
                Console.WriteLine("Enter an element: ");
                st.Push(Console.ReadLine());
                break;

                case 2:
                Console.WriteLine("Element removed: {0}", st.Pop());
                break;

                case 3:
                Console.WriteLine("Elements of stack are: ");
                st.Display();
                break;

                case 4:
                Environment.Exit(1);
                break;
            }
        }
    }
}

class stack { //don't use "Stack", that is in-built stack in C#
    private int StackSize;
    public int StackSizeSet {
        get { return StackSize; }
        set { StackSize=value; }
    }
    public int top;
    Object[] item; //int can be used in place of Object as well, Object is base class in C++ so it can accept any value without throwing error
    
    public stack() {
        StackSizeSet = 6;
        item = new Object[StackSizeSet];
        top = -1;
    }

    public void Push(object element) {
        if (top == (StackSize - 1))
            Console.WriteLine("Stack is full.");
        else {
            item[++top] = element;
            Console.WriteLine("Item pushed successfully.");
        }
    }

    public object Pop() {
        if (top == -1) {
            Console.WriteLine("Stack is empty.");
            return "No elements.";
        }
        else {
            return item[top--];
        }
    }

    public void Display() {
        if (top == -1) {
            Console.WriteLine("Stack is empty.");
        }
        else {
            for(int i=top; i>-1; i--) {
                Console.WriteLine("Item {0}: {1}", (i+1), item[i]);
            }
        }
    }
}
