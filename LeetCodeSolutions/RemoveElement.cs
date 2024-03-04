namespace LeetCodeSolutions;

//Leetcode 27.Remove Element
public class RemoveElement
{
    //76ms beats 99.93% of users
    public int Remove(int[] nums, int val)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if(val!=nums[i])
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
    }

    public void Test()
    {
        int[] nums = new int[8] { 0,1,2,2,3,0,4,2 }; // Input array
        int[] expectedNums = new int[5] { 0,1,4,0,3 }; // The expected answer with correct length
        int val = 2;

        int k = Remove(nums, val); // Calls your implementation

        Console.WriteLine(k == expectedNums.Length);
        for (int i = 0; i < 5; i++) {
            Console.WriteLine( nums[i]+"-"+ (nums[i] == expectedNums[i]));
        }
    }
}