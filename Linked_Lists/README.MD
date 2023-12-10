# Linked Lists

A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations. The elements in a linked list are linked using pointers.

Each node usually has a value, a pointer to the next node, and usually a pointer to the previous node (making it doubly linked).

There are multiple types including singly linked and doubly linked lists, which are referenced above, but there are also circular linked lists - where all the nodes form a circle - and header linked lists where you can use a header node to store information other that the information found in each node of the linked list.

This is a very foundational data structure, every linked list is also technically a graph and a tree.

An example interface for a linked list:

```C#

public interface LinkedList<T> {

    int Count { get; } // Gets the number of elements in the linked list.

    void AddFirst(T value); // Adds an element to the beginning of the linked list.

    void AddLast(T value); // Adds an element to the end of the linked list.

    bool Remove(T value); // Removes the first occurrence of the specified value from the linked list.

    bool Contains(T value); // Checks if the linked list contains the specified value.

    void Clear(); // Removes all elements from the linked list.

    void Print(); // Prints the elements of the linked list (for demonstration purposes).

}

```

## Key Properties and Uses

- Can be whatever size you want it to be
- Can be fast to insert and delete O(1)
- there is no index, you need to traverse O(N), unless its the head or tail O(1)
- Should avoid traversal, there are likely other, better, data structures to use

