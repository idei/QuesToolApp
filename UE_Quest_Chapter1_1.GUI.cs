using System;
using System.Collections.Generic;
using System.Text;

namespace QuesToolApp
{
    public partial class UE_Quest_Chapter1_1 : Quest
    {
        protected override void ConfigGUI()
        {
            Name = "UE_Quest-Chapter1.1";
            Title = string.Format("%{0}-Title", Name);                                  // Chapter 1. A Hidden Rebellion - Part 1
            Description = string.Format("%{0}-Description", Name);                      // It's like a knife through your heart...
            Icons.Add(new Icon("Bitmaps/Dynamic/Quests/UE/UEQuest_Chapter1a", "Quest"));

            Step step1 = new Step("Step1");

            step1.AddObjectiveSet("Politics06")
                .Title("%UE_Quest-Chapter1.1-C1Step1")                                  // Intimidate
                .Description("%UE_Quest-Chapter1.1-C1Description")                      // The moral response, the effective response, is to turn to violence....
                .TooltipDescription("%UE_Quest-Chapter1.1-C1ObjectiveTooltip")          // Empire Manpower begins accruing after System Manpower is full....
                .OutcomeCompleted("%UE_Quest-Chapter1.1-C1Outcome")                     // Victory! Without even a single weapon fired in anger....
                .Objective("Step2_1_Objective1", _questDef.ManpowerAmountName.Localize("%UE_Quest-Chapter1.1-C1Objective"));   // Reach $ManpowerAmountName [manPowerColored] capacity in your Empire.

            step1.AddObjectiveSet("Politics01")
                .Title("%UE_Quest-Chapter1.1-C2Step1")                                  // Bribe
                .Description("%UE_Quest-Chapter1.1-C2Description")                      // The leaders will need punishing, but the foot soldiers of this rebellion would be better ...
                .TooltipDescription("%UE_Quest-Chapter1.1-C2ObjectiveTooltip")          // Raise Dust through Trade Companies, Marketplace activity, and Economic Unlocks,...
                .OutcomeCompleted("%UE_Quest-Chapter1.1-C2Outcome")                     // Dust. Buys armies, builds fleets--and gets tongues waggling....
                .Objective("Step2_2_Objective1", _questDef.ManpowerAmountName.Localize("%UE_Quest-Chapter1.1-C2Objective"));   // Stockpile $DustAmoutName [dustColored] in your Empire.

            step1.AddObjectiveSet("Politics01")
                .Title("%UE_Quest-Chapter1.1-C2Step1")                                  // Bribe
                .Description("%UE_Quest-Chapter1.1-C2Description")                      // The leaders will need punishing, but the foot soldiers of this rebellion would be better ...
                .TooltipDescription("%UE_Quest-Chapter1.1-C2ObjectiveTooltip")          // Raise Dust through Trade Companies, Marketplace activity, and Economic Unlocks,...
                .OutcomeCompleted("%UE_Quest-Chapter1.1-C2Outcome")                     // Dust. Buys armies, builds fleets--and gets tongues waggling....
                .Objective("Step2_2Bis_Objective1", _questDef.ManpowerAmountName.Localize("%UE_Quest-Chapter1.1-C2Objective"));// Stockpile $DustAmoutName [dustColored] in your Empire.

            step1.AddObjectiveSet("Politics01")
                .Title("%UE_Quest-Chapter1.1-C2Step1")                                  // Bribe
                .Description("%UE_Quest-Chapter1.1-C2Description")                      // The leaders will need punishing, but the foot soldiers of this rebellion would be better ...
                .TooltipDescription("%UE_Quest-Chapter1.1-C2ObjectiveTooltip")          // Raise Dust through Trade Companies, Marketplace activity, and Economic Unlocks,...
                .OutcomeCompleted("%UE_Quest-Chapter1.1-C2Outcome")                     // Dust. Buys armies, builds fleets--and gets tongues waggling....
                .Objective("Step2_2Ter_Objective1", _questDef.ManpowerAmountName.Localize("%UE_Quest-Chapter1.1-C2Objective"));// Stockpile $DustAmoutName [dustColored] in your Empire.

            step1.AddObjectiveSet("Politics02")
                .Title("%UE_Quest-Chapter1.1-C3Step1")                                  // Locate
                .Description("%UE_Quest-Chapter1.1-C3Description")                      // Better to keep this matter private, or else be made a laughing stock ...
                .TooltipDescription("%UE_Quest-Chapter1.1-C3ObjectiveTooltip")          // Send Explorer ships to Systems with Curiosities and use the "Start Expedition"...
                .OutcomeCompleted("%UE_Quest-Chapter1.1-C3Outcome")                     // Success! Your exploratory fleet found--and crushed--the rebellion ...
                .Objective("Step2_3_Objective1", _questDef.ManpowerAmountName.Localize("%UE_Quest-Chapter1.1-C3Objective"));   // Explore $LoopCountName Curiosities..

            Steps.Add(step1);
        }
    }

}
