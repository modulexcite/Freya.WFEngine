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
using System.Xml;

namespace Freya.WFEngine.TestApp
{
    public class BeepActivityFactory : IComponentFactory<IActivity>
    {
        public bool CanHandle(Type componentType) {
            return componentType == typeof (BeepActivity);
        }

        public IActivity CreateComponent(Type componentType, IDictionary<string, object> configuration) {
            string exitState = configuration.ContainsKey(SingleExitPointActivity.ExitPointParameterName) 
                ? (string) configuration[SingleExitPointActivity.ExitPointParameterName]
                : null;

            return new BeepActivity(exitState);
        }
    }
}
