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
    
    public class HediffCompProperties_CureToxicBuildup : HediffCompProperties
    {
        public float severityPerDay;

        public HediffCompProperties_CureToxicBuildup()
        {
            compClass = typeof(HediffComp_CureToxicBuildup);
        }
    }

    public class HediffComp_CureToxicBuildup : HediffComp
    {
        public HediffCompProperties_CureToxicBuildup Props => (HediffCompProperties_CureToxicBuildup)props;

        public override void CompPostTick(ref float severityAdjustment)
        {
            Hediff ToxicBuildup = Pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.ToxicBuildup);
            if (ToxicBuildup == null) { return; }

            ToxicBuildup.Severity += Props.severityPerDay / 60000f;
        }
    }
}
