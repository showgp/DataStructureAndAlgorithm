using C1.Interfaces;

namespace C1.Implementations {

    /// <summary>
    /// 单链表结点实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedListNode<T>: ISingleLinkedListNode<T> {

        public SingleLinkedListNode(T value, ISingleLinkedListNode<T> next) {
            Value = value;
            Next = next;
        }

        public ISingleLinkedListNode<T> Next { get; set; }

        public T Value { get; set; }
    }
}