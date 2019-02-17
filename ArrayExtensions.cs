using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (accuracy < 0 || accuracy > 1)
                throw new ArgumentException();

            int count = BitConverter.GetBytes(decimal.GetBits((decimal)accuracy)[3])[2];

            for (int i = 0; i < array.Length; i++)
            {
                double sum1 = 0;
                for (int j = 0; j < i; j++)
                {
                    sum1 += Math.Round(array[j], count);
                }

                double sum2 = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum2 += Math.Round(array[j], count);
                }
                if (sum1 == sum2)
                    return i;
            }

            return null;
        }
    }
}
