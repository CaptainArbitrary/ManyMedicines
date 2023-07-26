using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

// This is a test. Do not merge this into main.

namespace MMeds
{
    public class HediffCompProperties_TreatToxicBuildup : HediffCompProperties
    {
        public float severityPerDay;

        public HediffCompProperties_TreatToxicBuildup()
        {
            compClass = typeof(HediffComp_TreatToxicBuildup);
        }
    }
}
