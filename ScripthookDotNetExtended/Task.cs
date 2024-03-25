using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripthookDotNetExtended
{
    public static class Task
    {
        public static void TASK_CAR_DRIVE_WANDER(GTA.Ped driver, GTA.Vehicle vehicle, float targetSpeed, int drivingStyle)
        {
            if (driver == null)
                return;

            if (vehicle == null)
                return;

            Function.Call("TASK_CAR_DRIVE_WANDER", driver, vehicle, targetSpeed, drivingStyle);
        }
    }
}
