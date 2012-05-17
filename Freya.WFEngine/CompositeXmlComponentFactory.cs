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

namespace Freya.WFEngine
{
    public class CompositeXmlComponentFactory<TComponent> : IXmlComponentFactory<TComponent>
    {
        private readonly List<IXmlComponentFactory<TComponent>> factories = new List<IXmlComponentFactory<TComponent>>();

        public void Register(IXmlComponentFactory<TComponent> componentFactory) {
            if (componentFactory == null)
                throw new ArgumentNullException("componentFactory");

            this.factories.Add(componentFactory);
        }

        public void RegisterAll(IEnumerable<IXmlComponentFactory<TComponent>> factoriesEnumeration) {
            this.factories.AddRange(factoriesEnumeration);
        }

        public bool CanHandle(Type activityType) {
            return this.factories.Any(f => f.CanHandle(activityType));
        }

        public TComponent CreateComponent(Type componentType, XmlElement configuration) {
            IXmlComponentFactory<TComponent> factory = this.factories.First(f => f.CanHandle(componentType));
            return factory.CreateComponent(componentType, configuration);
        }
    }
}
