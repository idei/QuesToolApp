using System;

namespace QuesToolApp
{
    public partial class UE_Quest_Chapter1_1 : Quest
    {
        private object CurrentEmpire;
        private object[] AllEmpires;
        private System RebelSystem;
        private System.Planet RebelPlanet;
        private int ManpowerAmount;
        private int DustAmout;
        private int LoopCount;
        private string DustResources;
        private string EmpireManpowerStock;
        private string PoliticalEffectMilitary;
        private string PoliticalEffectIndustry;
        private string PoliticalEffectScience;
        private string NewSystemName;
        private string Expression;
        public LocalizationVar ManpowerAmountName;
        public LocalizationVar DustAmountName;
        public LocalizationVar LoopCountName;

        public UE_Quest_Chapter1_1(Category category, SubCategory subCategory, int minimumTurn) : base(category, subCategory, minimumTurn)
        {
            this.tags = new String[] { "BeginTurn" };
            this.context = new QuestContextSolo();
            this.repetitionRules = new RepetitionRules(0, 1, 0);
            this.CurrentEmpire = Globals.Empire;
            this.AllEmpires = Globals.Empires;

            this.ManpowerAmount = 800;
            this.DustAmout = 600;
            this.DustResources = "EmpireMoney";
            this.LoopCount = 10;
            this.EmpireManpowerStock = "EmpireManpower";

            this.PoliticalEffectMilitary = "PopulationEventUE01.1Military";
            this.PoliticalEffectIndustry = "PopulationEventUE01.1Industry";
            this.PoliticalEffectScience = "PopulationEventUE01.1Science";

            this.RebelSystem = Globals.RebelSystem;

            this.RebelPlanet = this.RebelSystem.Planets;

            this.NewSystemName = "%UE_Quest-Chapter1.1Outpost";   // Traitor's Reach (english/ES2_Localization_Quest_Locales.xml Line 1653)

            this.Expression = "Property(Context, MaximumEmpireManpowerStock) > 800";

            ManpowerAmountName = new LocalizationVar("$ManpowerAmountName", "$ManpowerAmount");
            DustAmountName = new LocalizationVar("$DustAmoutName", "$DustAmout");
            LoopCountName = new LocalizationVar("$LoopCountName", "$LoopCount");

            /*
			<LocalizationVar LocalizationKey="$ManpowerAmountName" Source="$ManpowerAmount"/>
			<LocalizationVar LocalizationKey="$DustAmoutName" Source="$DustAmout"/>
			<LocalizationVar LocalizationKey="$LoopCountName" Source="$LoopCount"/>
			*/

        }
    }
}
