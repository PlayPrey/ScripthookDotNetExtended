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

        [Description("Adds a blip for the desired vehicle. The blip parameter needs to be refering to an already initialized Blip as this will use that blip.")]
        public static void ADD_BLIP_FOR_CAR(GTA.Vehicle vehicle, ref GTA.Blip blip)
        {
            // Obviously the vehicle should exist..
            if (vehicle == null)
                return;


            // The blip needs to exist before this native gets called.
            if (blip == null)
                return;

            Function.Call("ADD_BLIP_FOR_CAR", vehicle, blip);
        }
        [Description("Adds the desired vehicle to the mission deletion list. When the mission is complete the vehicle will despawn.")]
        public static void ADD_CAR_TO_MISSION_DELETION_LIST(GTA.Vehicle vehicle)
        {
            if(vehicle == null) return;
            Function.Call("ADD_CAR_TO_MISSION_DELETION_LIST", vehicle);
        }
        [Description("Adds a check for a stuck car (controlled by the AI). To check if the vehicle is stuck use IS_CAR_STUCK. TO remove the stuck check use REMOVE_STUCK_CAR_CHECK.")]
        public static void ADD_STUCK_CAR_CHECK(GTA.Vehicle vehicle, float distance, int timeInMs)
        {
            if( vehicle == null) return;
            Function.Call("ADD_STUCK_CAR_CHECK", vehicle, distance, timeInMs);
        }
        [Description("Same as ADD_STUCK_CAR_CHECK but with built in warp when stuck. The unknown bool is always TRUE in the default missions. pathHandle is always 1 except for one mission where it is -1.")]
        public static void ADD_STUCK_CAR_CHECK_WITH_WARP(GTA.Vehicle vehicle, float distance, int timeInMs, bool restoreIfStuck, bool restoreIfFlipped, bool unknown, int pathHandle)
        {
            if (vehicle == null) return;
            Function.Call("ADD_STUCK_CAR_CHECK_WITH_WARP", vehicle, distance, timeInMs, restoreIfStuck, restoreIfFlipped, unknown, pathHandle);
        }
        [Description("Adds a check for the desired vehicle to see if it's upside down.")]
        public static void ADD_UPSIDEDOWN_CAR_CHECK(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return;
            Function.Call("ADD_UPSIDEDOWN_CAR_CHECK", vehicle);
        }
        public static void APPLY_FORCE_TO_CAR(GTA.Vehicle vehicle, int unknown, float forceX, float forceY, float forceZ, float sourceX, float sourceY, float sourceZ, bool unknown9, bool relativeToCarDirection, bool relativeToSomethingElse, bool unknown12)
        {
            if( vehicle == null) return;
            Function.Call("APPLY_FORCE_TO_CAR", vehicle, unknown, forceX, forceY, forceZ, sourceX, sourceY, sourceZ, unknown9, relativeToCarDirection, relativeToSomethingElse, unknown12);
        }
        [Description("Marks the desired tyre as burst.")]
        public static void BURST_CAR_TYRE(GTA.Vehicle vehicle, int wheelId)
        {
            if (vehicle == null)
                return;

            GTA.Native.Function.Call("BURST_CAR_TYRE", vehicle, wheelId);
        }




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
        [Description("Marks the car as a convoy vehicle, allowing tasked peds to use it.")]
        public static void MARK_CAR_AS_CONVOY_CAR(GTA.Vehicle vehicle, bool state)
        {
            if (vehicle == null)
                return;

            Function.Call("MARK_CAR_AS_CONVOY_CAR", vehicle, state);
        }
        [Description("Returns true if the Taxi Lights are on, even if they're broken.")]
        public static bool ARE_TAXI_LIGHTS_ON(GTA.Vehicle vehicle)
        {
            if (vehicle == null)
                return false;

            return Function.Call<bool>("ARE_TAXI_LIGHTS_ON", vehicle);
        }



        [Description("Returns true if the vehicle counts as a bike.")]
        public static bool IS_THIS_MODEL_A_BIKE(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_BIKE", vehicle);
        }
        [Description("Returns true if the vehicle counts as a boat.")]
        public static bool IS_THIS_MODEL_A_BOAT(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_BOAT", vehicle);
        }
        [Description("Returns true if the vehicle counts as a car.")]
        public static bool IS_THIS_MODEL_A_CAR(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_CAR", vehicle);
        }
        [Description("Returns true if the vehicle counts as a helicopter.")]
        public static bool IS_THIS_MODEL_A_HELI(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_HELI", vehicle);
        }
        [Description("Returns true if the vehicle counts as a plane.")]
        public static bool IS_THIS_MODEL_A_PLANE(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_PLANE", vehicle);
        }
        [Description("Returns true if the vehicle counts as a train.")]
        public static bool IS_THIS_MODEL_A_TRAIN(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_TRAIN", vehicle);
        }
        [Description("Returns true if the vehicle counts as a vehicle in general.")]
        public static bool IS_THIS_MODEL_A_VEHICLE(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_THIS_MODEL_A_VEHICLE", vehicle);
        }
        [Description("Returns true if the vehicle counts as driveable still.")]
        public static bool IS_VEH_DRIVEABLE(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_VEH_DRIVEABLE", vehicle);
        }
        [Description("Returns true if the vehicle has stuck check activated, and is stuck.")]
        public static bool IS_VEH_STUCK(GTA.Vehicle vehicle)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_VEH_STUCK", vehicle);
        }
        [Description("Returns true if desired window is still OK.")]
        public static bool IS_VEH_WINDOW_INTACT(GTA.Vehicle vehicle, int windowId)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_VEH_WINDOW_INTACT", vehicle, windowId);
        }
        [Description("Returns true if desired window is still OK.")]
        public static bool IS_VEH_WINDOW_INTACT(GTA.Vehicle vehicle, WINDOW window)
        {
            if (vehicle == null) return false;

            return Function.Call<bool>("IS_VEH_WINDOW_INTACT", vehicle, (int)window);
        }
    }
}
