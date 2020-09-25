﻿using System.Linq;
using DesperateDevs.CodeGeneration;

namespace Entitas.CodeGeneration.Plugins
{
    public class ComponentData : CodeGeneratorData
    {
        public ComponentData()
        {
        }

        public ComponentData(CodeGeneratorData data) : base(data)
        {
        }
    }

    public static class ComponentDataExtension
    {
        public static string ToComponentName(this string fullTypeName)
        {
            return fullTypeName.Split('.').Last().RemoveComponentSuffix();
        }
    }
}
