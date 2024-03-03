namespace LeetCodeSolutions;
//LeetCode 21.MergeTwoSortedList

//TODO: needs refactor btw 
public class MergeTwoSortedList
{
    List<int> nodeList = new List<int>();

    public void MergeTwoList()
    {
        #region Data

        ListNode list1 = new ListNode();
        list1.val = 4;
        list1.next = new ListNode() { val = 2 };
        ListNode list2 = new ListNode();
        list2.val = 2;
        list2.next = new ListNode() { val = 3 };
        
        #endregion

        //fill nodeList
        AddToList(list1);
        AddToList(list2);
        
        //sort
        nodeList.Sort();
        
        //create new sorted node
        ListNode listNode = null;

        foreach (var item in nodeList)
        {
            if (listNode == null)
            {
                listNode = new ListNode();
                listNode.val = item;
            }
            else
            {
                var lastNode = GetLastNode(listNode);
                lastNode.next = new ListNode(){val=item};
            }
        }
    }
    
    //Adds every node to generic list
    public void AddToList(ListNode list)
    {
        var node = list;
        while (node != null)
        {
            nodeList.Add(node.val);
            node = node.next;
        }
    }
    
    //finds the last node 
    public ListNode GetLastNode(ListNode listNode)
    {
        if (listNode.next != null)
            return GetLastNode(listNode.next);
        
        return listNode;
    }

}
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
