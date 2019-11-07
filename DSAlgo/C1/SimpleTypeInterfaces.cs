namespace C1 {
    public interface IFixedCapacityStackOfStrings {
        void Push(string s);
        string Pop();
        bool IsEmpty();
        int Size();
    }

    public interface IFixedCapacityStack<Item> {
        void Push(Item s);
        Item Pop();
        bool IsEmpty();
        int Size();
    }
}