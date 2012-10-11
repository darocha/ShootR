﻿namespace ShootR
{
    public class GameConfiguration
    {
        public GameConfiguration()
        {
            // How frequently the Update loop is executed
            UPDATE_INTERVAL = 20; // Must evenly divide into DRAW_INTERVAL
            // How frequently the Draw loop is executed.  Draw is what triggers the client side pings, it must be larger than UPDATE_INTERVAL but
            DRAW_INTERVAL = 40;            
            MAX_CAMERA_SPEED = 500;
            // Every X state changes request a ping back
            REQUEST_PING_EVERY = 5;
        }

        public int DRAW_INTERVAL { get; set; }
        public int UPDATE_INTERVAL { get; set; }
        public int MAX_CAMERA_SPEED { get; set; }
        public int REQUEST_PING_EVERY { get; set; }
    }
}