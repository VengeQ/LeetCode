
namespace LeetCode
{
    public class ParkingSystem
    {
        readonly int[] carTypes = new int[4];

        public ParkingSystem(int big, int medium, int small)
        {
            carTypes[1] = big;
            carTypes[2] = medium;
            carTypes[3] = small;
        }

        public bool AddCar(int carType)
        {
            carTypes[carType]--;

            return carTypes[carType]-- > 0;
        }
    }
}
