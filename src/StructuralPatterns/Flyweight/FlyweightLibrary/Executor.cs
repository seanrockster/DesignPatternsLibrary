﻿using DesignPatternsLibrary.PatternExecutors;
using FlyweightLibrary.DotNetStringExample;
using FlyweightLibrary.ForestExample;

namespace FlyweightLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Flyweight - Flyweight Library - Structural Pattern";

        public override void Execute()
        {
            DotNetStringExecutor.Execute();
            ForestExecutor.Execute();
        }
    }
}