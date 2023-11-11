namespace DSAPractice.LinkedList;

public class ReverseLinkedList : ISolution
{
    public string Title => "Reverse Linked List";

    public string Answer()
    {
        // [1,2,3,4,5]
        var result = Solution(new ListNode
        {
            Val = 1,
            Next = new ListNode
            {
                Val = 2,
                Next = new ListNode
                {
                    Val = 3,
                    Next = new ListNode 
                    {
                        Val = 4,
                        Next = new ListNode
                        {
                            Val = 5,
                            Next = null
                        }
                    }
                }
            }
        });

        return $"{result.Val}";
    }

    private ListNode? Solution(ListNode head)
    {
        ListNode? prev = null;
        ListNode curr = head;

        while (curr is not null)
        {
            var tmp = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = tmp;
        }

        return prev;
    }
}

public class ListNode
{
    public int Val { get; set; }

    public ListNode? Next { get; set; }

    public ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }
}
