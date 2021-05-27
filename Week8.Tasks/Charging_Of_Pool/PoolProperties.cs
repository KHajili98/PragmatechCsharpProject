using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charging_Of_Pool
{
    public static class PoolProperties
    {

        public static decimal GetVolume (decimal height, decimal length, decimal width)
        {
            return height * width * length;
        }


        public static decimal CalculateTime (decimal volume, decimal pipe1, decimal pipe2)
        {
            decimal elapsedTime = volume / (pipe1 + pipe2);
            return elapsedTime;
        }



    }
}
