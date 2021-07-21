﻿using System;

namespace LinkedListReimplimentation
{
    
        public class SinglyLinkedList<T>
        {
            public Node<T> Head { get; private set; }
            public Node<T> Tail { get; private set; }
            public int Count { get; private set; }

            public void AddFirst(T value)
            {
                AddFirst(new Node<T>(value));
            }
            private void AddFirst(Node<T> node)
            {
                Node<T> tmp = Head;
                Head = node;
                Head.Next = tmp;
                Count++;
                if(Count ==1)
                {
                    Tail = Head;
                }
            }
            public void AddLast(T value)
            {
                AddLast(new Node<T>(value));
            }
             private void AddLast(Node<T> node)
            {
                if (isEmpty)
                    Head = node;
                else
                    Tail.Next = node;

                Tail = node;
                Count++;
            }
            public void RemoveFirst()
            {
                if (isEmpty)
                    throw new InvalidOperationException();

                Head = Head.Next;
                if (Count == 1)
                    Tail = null;
                Count--;
            }
            public void RemoveLast()
            {
                if (isEmpty)
                    throw new InvalidOperationException();
                if(Count == 1)
                {
                    Head = Tail = null;
                }
                else
                {
                    var current = Head;
                    while(current != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                    Count--;
                }

                Head = Head.Next;
            }
            public bool isEmpty => Count == 0;
        }
    }

