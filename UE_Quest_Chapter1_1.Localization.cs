using static QuesToolApp.QuestLocalization;

namespace QuesToolApp
{
    public partial class UE_Quest_Chapter1_1
    {
        private readonly QuestLocalization localization = new QuestLocalization("UE_Quest-Chapter1.1");

        protected override void ConfigLocalization()
        {
            localization[Key.Title] = "Chapter 1. A Hidden Rebellion - Part 1";
            localization[Key.Description] = "It's like a knife through your heart.\n" +
                "\"You joke, Hadri,\" you say, knowing the Sheredyn never jokes.\n" +
                "He shakes his head. \"The weapon signature leaves no doubts.\"\n" +
                "You stare out at the starfield, anger growing.A United Empire fleet fired upon by a fellow UE vessel of obsolete design. . .\n" +
                "\"How old--\"\n" +
                "\"Twenty-five solar cycles at least, Your Imperial Majesty. We think there must be an outpost out there somewhere.\"\n" +
                "The knife twists.This is no reactionary rebellion.This is something fomented decades ago, meticulously planned, kept hidden" +
                " with a military - like focus.Few would possess the courage, the resources, the sheer iron will to see through such an undertaking." +
                " Who would do such a thing ? You thought the uprisings were a thing of the past, crushed forever when you disposed of" +
                " Duke Anatov and finally united the empire all those years ago.Your heart chills.Could Lena, bitter ungrateful Lena, have " +
                "hatched such a diabolical plot? Or maybe it was Hadri, so called First Protector Hadri Lenko, so near and yet so far from the " +
                "seat of power? Or perhaps it was Petra Mandzukic, she who could trace her line to the great Mezari clans, who lusted over a greater power . . .\n" +
                "No, no, no!This way lies madness.They are loyal subjects.\n" +
                "I will find the perpetrator. Slowly.Methodically.\n" +
                "You cling to the thought, a lifeline in an ocean of dark musings.\n" +
                "Hadri coughs. \"What is your command, Your Imperial Majesty?\"";
            localization[Key.Reward] = "Outpost: Traitor's Reach";
            localization[Key.Outpost] = "Traitor's Reach";
            localization[Key.TooltipsOutpostTitle] = "Traitor's Reach";

            localization[Key.ChoiceStep, 1] = "Intimidate";
            localization[Key.ChoiceDescription, 1] = "The moral response, the effective response, is to turn to violence. Or at least its threat. " +
                "We will grow our glorious armies, march across the stars, and the enemy will know we come for them.";
            localization[Key.ChoiceObjective, 1] = "Reach $ManpowerAmountName [manPowerColored] capacity in your Empire.";
            localization[Key.ChoiceObjectiveTooltip, 1] = "Empire Manpower begins accruing after System Manpower is full. " +
                "To raise capacity unlock new Stages of the Military quadrant of the Technology Tree, or possess more Systems.";
            localization[Key.ChoiceOutcome, 1] = "Victory! Without even a single weapon fired in anger. Balking at the build-up " +
                "of your military forces, the rebels surrendered their fleet. Although their ships were too archaic to be useful, " +
                "they had developed an interesting new technology. The biggest shock, however, was the identity of the rebel leader. " +
                "Your sister, Lena wasn't blessed with only one child, Viktoria. She had another. An identical twin. Julinka.";

            localization[Key.ChoiceStep, 2] = "Bribe";
            localization[Key.ChoiceDescription, 2] = "The leaders will need punishing, but the foot soldiers of this rebellion " +
                "would be better treated as weak, misguided souls. Souls who should learn of the financial inducements the Emperor " +
                "is offering for information.";
            localization[Key.ChoiceObjective, 2] = "Stockpile $DustAmoutName [dustColored] in your Empire.";
            localization[Key.ChoiceObjectiveTooltip, 2] = "Raise Dust through Trade Companies, Marketplace activity, and Economic Unlocks, among other methods";
            localization[Key.ChoiceOutcome, 2] = "Dust. Buys armies, builds fleets--and gets tongues waggling. The rebel outpost " +
                "fell easily. You named it Traitor's Reach as a warning to others. The biggest shock, however, was the identity of " +
                "the rebel leader. Your sister, Lena wasn't blessed with only one child, Viktoria. She had another. An identical twin. Julinka.";

            localization[Key.ChoiceStep, 3] = "Locate";
            localization[Key.ChoiceDescription, 3] = "Better to keep this matter private, or else be made a laughing stock. Sending " +
                "a small fleet to locate and deal with the rebel outpost--discreetly and efficiently--is the right response.";
            localization[Key.ChoiceObjective, 3] = "Explore $LoopCountName Curiosities.";
            localization[Key.ChoiceObjectiveTooltip, 3] = "Send Explorer ships to Systems with Curiosities and use the \"Start Expedition\" " +
                "Fleet Action or add the Curiosities to the Construction Queue if you own the System.";
            localization[Key.ChoiceOutcome, 3] = "Success! Your exploratory fleet found--and crushed--the rebellion. Not much was worth keeping, " +
                "but the records did provide some interesting insights. The biggest shock, however, was the identity of the rebel leader. Your sister, " +
                "Lena wasn't blessed with only one child, Viktoria. She had another. An identical twin. Julinka.";

        }
    }
}
