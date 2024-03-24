using GTA;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripthookDotNetExtended
{
    public static class Vehicle
    {
        public enum WINDOW { LeftFront, RightFront, LeftRead, RightRear }

        public static void BURST_CAR_TYRE(GTA.Vehicle vehicle, int wheelId)
        {
            if (vehicle == null)
                return;

            GTA.Native.Function.Call("BURST_CAR_TYRE", vehicle, wheelId);
        }





        // REMOVE_CAR_WINDOW
        [Description("Removes the window from the vehicle. There are no animations for this.")]
        public static void REMOVE_CAR_WINDOW(GTA.Vehicle vehicle, int windowId)
        {
            if (vehicle == null)
                return;

            if (windowId < 0 || windowId > 3)
                return;

            GTA.Native.Function.Call("REMOVE_CAR_WINDOW", vehicle, windowId);
        }
        [Description("Removes the window from the vehicle. There are no animations for this.")]
        public static void REMOVE_CAR_WINDOW(GTA.Vehicle vehicle, WINDOW windowId)
        {
            if (vehicle == null)
                return;

            GTA.Native.Function.Call("REMOVE_CAR_WINDOW", vehicle, (int)windowId);
        }
        [Description("Resets the suspension on the vehicle.")]
        public static void RESET_CAR_WHEELS(GTA.Vehicle vehicle, bool onlyDamaged)
        {
            if (vehicle == null)
                return;

            Function.Call("RESET_CAR_WHEELS", vehicle, !onlyDamaged);
        }
        [Description("Opens the car boot.")]
        public static void POP_CAR_BOOT(GTA.Vehicle vehicle)
        {
            if (vehicle == null)
                return;

            Function.Call("POP_CAR_BOOT", vehicle);
        }
        [Description("Opens the desired car door.")]
        public static void OPEN_CAR_DOOR(GTA.Vehicle vehicle, int doorId)
        {
            if (vehicle == null)
                return;

            Function.Call("OPEN_CAR_DOOR", vehicle, doorId);
        }
        [Description("Allows garbage collector to deal with this vehicle.")]
        public static void MARK_CAR_AS_NO_LONGER_NEEDED(GTA.Vehicle vehicle)
        {
            if (vehicle == null)
                return;

            Function.Call("MARK_CAR_AS_NO_LONGER_NEEDED", vehicle);
        }
        public static void MARK_CAR_AS_CONVOY_VEHICLE(GTA.Vehicle vehicle, bool state)
        {
            if (vehicle == null)
                return;

            Function.Call("MARK_CAR_AS_CONVOY_VEHICLE", vehicle, state);
        }
        [Description("Returns true if the Taxi Lights are on, even if they're broken.")]
        public static bool ARE_TAXI_LIGHTS_ON(GTA.Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            return Function.Call<bool>("ARE_TAXI_LIGHTS_ON", vehicle);
        }

    }
}
