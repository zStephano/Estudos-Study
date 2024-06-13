// See https://aka.ms/new-console-template for more information
int[] nums = { 11, 15, 2, 7, 30, 37, 23 };
int target = 9;
var result = TwoSumOne(nums, target);

int[] TwoSumOne(int[] nums, int target)
{

    int[] result = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                result[0] = i;
                result[1] = j;
                Console.WriteLine($"Nums {nums[i]} and {nums[j]} in positions {result[0]} and {result[1]} has the result target as {nums[i] + nums[j]}");
                return result;
            }
        }
    }
    return result;
}
