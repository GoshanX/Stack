using System;

class Stack {
    char[] stck; // массив, содержащий стек
    int tos;    // индекс вершины стека

        public Stack(int size) {
            stck = new char[size];
            tos = 0;
        }
    public void Push(char ch) {
        if(tos == stck.Length){
            Console.WriteLine("  - Стек заполнен.");
            return;
        }
        stck[tos] = ch;
        tos++;
    }
    public char Pop() {
        if(tos == 0) {
            Console.WriteLine(" - Стек пуст.");
            return (char)0;
        }
        tos--;
        return stck[tos];
    }
    public bool IsFull() {
        return tos == stck.Length;
    }
    public bool IsEmpty() {
        return tos == 0;
    }
    public int Capacity() {
        return stck.Length;
    }
    public int GetNum() {
        return tos;
    }
    
}



