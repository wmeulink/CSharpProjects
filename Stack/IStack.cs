namespace Stack 
{
    interface IStack<T>
    {
        T Pop();
        T Peek();
        void Push(T item);
    }
}