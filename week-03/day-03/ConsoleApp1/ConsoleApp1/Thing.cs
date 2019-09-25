﻿using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete()
        {
            completed = true;
        }

        public bool GetCompletedStatus()
        {
            return completed;
        }

        public string getThingName()
        {
            return name;
        }
    }
}