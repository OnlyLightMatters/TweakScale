﻿using System;
using System.Linq;
using TweakScale;

namespace TweakScale_RealFuels
{
    [KSPAddon(KSPAddon.Startup.EveryScene, false)]
    internal class MyEditorRegistrationAddon : TweakScale.RescalableRegistratorAddon
    {
        public override void OnStart()
        {
            TweakScale.TweakScaleUpdater.RegisterUpdater((RealFuels.ModuleFuelTanks mod) => new TweakScaleRealFuelUpdater(mod));
        }
    }

    class TweakScaleRealFuelUpdater : TweakScaleUpdater<RealFuels.ModuleFuelTanks>
    {
        public TweakScaleRealFuelUpdater(RealFuels.ModuleFuelTanks pm)
            : base(pm)
        {
        }

        override public void OnRescale(ScalingFactor factor)
        {
            Module.ChangeVolume(BaseModule.volume * factor.absolute.cubic);
        }
    }
}