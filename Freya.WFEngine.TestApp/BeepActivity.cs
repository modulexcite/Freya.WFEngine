﻿#region License
// 
// Author: Lukas Paluzga <sajagi@freya.cz>
// Copyright (c) 2012, Lukas Paluzga
//  
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
//  
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freya.WFEngine.TestApp
{
    public class BeepActivity : SingleExitPointActivity, IBeepActivity
    {
        public BeepActivity(string exitState) : base(exitState) {
        }

        public void Invoke() {
            Console.Beep();
            this.UpdateState();
        }
    }
}
