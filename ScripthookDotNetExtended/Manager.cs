using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;

namespace ScripthookDotNetExtended
{
    public class Manager : Script 
    {
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
                    Game.DisplayText("Taxi lights: " + Vehicle.ARE_TAXI_LIGHTS_ON(Player.Character.CurrentVehicle));
                    Vehicle.OPEN_CAR_DOOR(Player.Character.CurrentVehicle, 2);
                }
            }
        }
    }
}
