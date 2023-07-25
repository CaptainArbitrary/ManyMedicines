using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using Verse;

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

    public class HediffComp_TreatToxicBuildup : HediffComp
    {
        public HediffCompProperties_TreatToxicBuildup Props => (HediffCompProperties_TreatToxicBuildup)props;

        private readonly int interval = 250;

        public override void CompPostTick(ref float severityAdjustment)
        {

            if (Pawn.IsHashIntervalTick(interval))
            {

                Hediff toxicBuildup = Pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ToxicBuildup);
                if (toxicBuildup == null) { return; }

                toxicBuildup.Severity += Props.severityPerDay / GenDate.TicksPerDay * interval;

            }

        }
    }
}
