﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Job
    {
        protected int attack = 50;
        protected int health;

        public Job(int health)
        {
            this.health = health;
        }
    }
}
