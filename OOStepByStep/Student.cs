﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public override string Introduce()
        {
            return $"{base.Introduce()} I am a student.";
        }
    }
}
