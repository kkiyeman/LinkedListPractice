using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyNode
{

    public int value;

    public MyNode next;

}
public class MyLinkedList
{

    public MyNode head;
    public MyNode tail;

    LinkedList<int> linkedlist;

    MyNode CreateNode(int value)
    {
        MyNode node = new MyNode();
        node.value = value;

        if (head == null || tail == null)
        {
            head = node;
            tail = node;
        }

        return node;
    }


    #region AddNode
    public void AddNodeToTail(int value)
    {
        MyNode node = CreateNode(value);

        tail.next = node;
        tail = node;      
    }

    public void AddNodeToFront(int value)
    {
        MyNode node = CreateNode(value);
        node.next = head;
        head = node;
    }

    public void AddNodeAt(int value, int index)
    {
        MyNode node = CreateNode(value);

        int count = 0;
        MyNode curNode = head;
        while(curNode.next != null)
        {
            curNode = curNode.next;
            count++;
            if (count == index)
                break;
        }

        if(curNode.next !=null)
        {
            node.next = curNode.next;
            curNode.next = node;
        }
        else
        {
            curNode.next = node;
            tail = node;
        }
        
        

    }
    #endregion

    public MyNode GetNode(int value)
    {
        
        MyNode curNode = head;
        while (curNode.next != null)
        {
            curNode = curNode.next;
            
            if (curNode.value == value)
                return curNode;
        }
        Debug.LogWarning($"찾으시는 노드가 없습니다.");
        return null;
    }
    
    public MyNode GetNodeAt(int index)
    {
        int count = 0;
        MyNode curNode = head;
        while (curNode.next != null)
        {
            curNode = curNode.next;
            count++;
            if (count == index)
                return curNode;
        }
        Debug.LogWarning($"찾으시는 노드가 없습니다.");
        return null;
    }

    public int FindNode(int value)
    {
        int count = 0;
        MyNode curNode = head;
        while (curNode.next != null)
        {
            curNode = curNode.next;
            count++;
            if (curNode.value == value)
                return count;
        }

        return -1;//찾지 못했다
    }

    public void RemoveNode(int value)
    {

        MyNode curNode = head;
        MyNode prevNode = head;
        while(curNode.next != null)
        {
            prevNode = curNode;
            curNode = curNode.next;
            if(curNode.value == value)
            {
                prevNode.next = curNode.next;
                return;
            }
        }
        

    }

    public void RemoveNodeAt(int index)
    {
        int count = 0;
        MyNode curNode = head;
        MyNode prevNode = head;
        while (curNode.next != null)
        {
            prevNode = curNode;
            curNode = curNode.next;
            count++;
            if (count == index)
            {
                prevNode.next = curNode.next;
                return;
            }
        }
    }

}
