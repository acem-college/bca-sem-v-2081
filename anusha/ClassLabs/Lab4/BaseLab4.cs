namespace ClassLabs.Lab4
{
    internal abstract class BaseLab4 : ILab4
    {
        public virtual int Add(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
