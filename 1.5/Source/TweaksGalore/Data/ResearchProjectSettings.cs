﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace TweaksGalore
{
    public class ResearchProjectSettings : IExposable
    {
        public float baseCost;
        public TechLevel techLevel;
        public int techprintCount;
        public float techprintCommonality;
        public float techprintMarketValue;
        public bool heldByEmpire;
        public bool heldByOutlanders;

        public void ExposeData()
        {
            Scribe_Values.Look(ref baseCost, "baseCost");
            Scribe_Values.Look(ref techLevel, "techLevel");
            Scribe_Values.Look(ref techprintCount, "techprintCount");
            Scribe_Values.Look(ref techprintCommonality, "techprintCommonality");
            Scribe_Values.Look(ref techprintMarketValue, "techprintMarketValue");
            Scribe_Values.Look(ref heldByEmpire, "heldByEmpire");
            Scribe_Values.Look(ref heldByOutlanders, "heldByOutlanders");
        }
    }
}
