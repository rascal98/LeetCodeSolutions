namespace LeetCodeSolutions;



//LeetCode 26. Remove Duplicates from Sorted Array
public class RemoveDuplicatesFromSortedArray
{
    //counting unique numbers and sorting the main array
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int index=0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[index])
            {
                index++;
                nums[index] = nums[i];
            }
        }
        return index+1;
    }
    //assert
    public void Test()
    {
        int[] nums = new int[2] { 1,2 }; // Input array
        int[] expectedNums = new int[2] { 1,2 }; // The expected answer with correct length

        int k = RemoveDuplicates(nums); // Calls your implementation

        Console.WriteLine("Test : " + (k == expectedNums.Length));
        for (int i = 0; i < k; i++)
        {
            Console.WriteLine(nums[i] == expectedNums[i]);
        }
    }
}