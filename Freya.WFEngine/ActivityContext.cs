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

namespace Freya.WFEngine
{
    public class ActivityContext
    {
        public ActivityContext(string name, object item, string state) {
            this.Name = name;
            this.Item = item;
            this.State = state;
            this.OriginalState = OriginalState;
        }

        /// <summary>
        /// Gets the name of the activity.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets original state of the item. The property value does not change after the activity is executed.
        /// </summary>
        public string OriginalState { get; private set; }

        /// <summary>
        /// Gets or sets the current state of the item. Use the setter to set new state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets the item the activity is performed upon.
        /// </summary>
        public object Item { get; private set; }
    }
}
