using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;


namespace ScripthookDotNetExtended
{
    public class Manager : Script 
    {
        static Vector3 testSpawnVehicle1 = new Vector3(2245f, 96f, 6f);
        static Vector3 testSpawnVehicle2 = new Vector3(2245f, 135f, 6f); // h180


        public Manager() 
        {
            this.KeyDown += Manager_KeyDown;
        }

        private void Manager_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == System.Windows.Forms.Keys.F8)
            {
                if(Player.Character.CurrentVehicle != null)
                {
                    Blip blip = new Blip(38891);

                    Vehicle.ADD_BLIP_FOR_CAR(Player.Character.CurrentVehicle, ref blip);
                    
                }
            }


            if(e.Key == System.Windows.Forms.Keys.D0)
            {
                foreach (GTA.Vehicle vehicle in World.GetAllVehicles())
                    vehicle.Delete();

                foreach (GTA.Ped ped in World.GetAllPeds())
                    if (ped != Player.Character) ped.Delete();
            }
        }



        private void TestCarConvoy()
        {
            GTA.Vehicle carWanderer = World.CreateVehicle("MULE", testSpawnVehicle1);
            carWanderer.Heading = 180f;
            Ped pedWanderer = carWanderer.CreatePedOnSeat(VehicleSeat.Driver);

            GTA.Vehicle carFollower = World.CreateVehicle("STEED", testSpawnVehicle2);
            carFollower.Heading = 180f;
            Ped pedFollower = carFollower.CreatePedOnSeat(VehicleSeat.Driver);

            pedWanderer.NoLongerNeeded();
            carWanderer.NoLongerNeeded();
            pedFollower.NoLongerNeeded();
            carFollower.NoLongerNeeded();

            Vehicle.MARK_CAR_AS_CONVOY_CAR(Player.Character.CurrentVehicle, true);
            Vehicle.MARK_CAR_AS_CONVOY_CAR(carWanderer, true);
            Vehicle.MARK_CAR_AS_CONVOY_CAR(carFollower, true);

            //Task.TASK_CAR_DRIVE_WANDER(pedWanderer, carWanderer, 10, 0);


            Function.Call("TASK_CAR_MISSION", pedWanderer, carWanderer, Player.Character.CurrentVehicle, 12, 10.0, 2, 0, 10);
            Function.Call("TASK_CAR_MISSION", pedFollower, carFollower, Player.Character.CurrentVehicle, 12, 10.0, 2, 0, 10);

        }
    }
}
