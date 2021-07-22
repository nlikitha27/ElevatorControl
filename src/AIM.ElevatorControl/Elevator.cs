using System.Collections.Generic;

namespace AIM.ElevatorControl
{
    public class Elevator : IElevator
    {
        // Assume we have 3 floors.
        private readonly int[] floors = new int[3];

        /// <summary>
        /// Provide all floors requests. 
        /// </summary>
        /// <returns>Collection of floor requests</returns>
        public int[] All()
        {
            List<int> result = new List<int>();

            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                    result.Add(i);
            }
            return result.ToArray();
        }

        /// <summary>
        /// Assign individual floor request.
        /// </summary>
        /// <param name="floor">Floor Number</param>
        /// <param name="direction"></param>
        public void FloorRequest(int floor, int? direction = null)
        {
            // TOOD: use direction for floor calls
            floors[floor] = 1;
        }

        public int? Next()
        {
            int? result = null;
            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                {
                    floors[i] = 0;  
                    result = i;
                    break;
                }
            }
            return result;
        }

    }
}
