using System.Collections.Generic;

namespace QuesToolApp
{
    /// <summary>
    /// Represents a Quest.
    /// </summary>
    public abstract class Quest
    {
        public string Name;
        public string Title;
        public string Description;
        public List<Icon> Icons = new List<Icon>();
        public List<Step> Steps = new List<Step>();

        public enum Category { MajorQuest }
        public enum SubCategory { UE }

        protected Category category;
        protected SubCategory subCategory;
        protected int minimumTurn;
        protected string[] tags;

        public QuestContextSolo context;
        public RepetitionRules repetitionRules;

        public Quest(Category category, SubCategory subCategory, int minimumTurn)
        {
            this.category = category;
            this.subCategory = subCategory;
            this.minimumTurn = minimumTurn;
            ConfigLocalization();
            ConfigGUI();
        }

        protected virtual void ConfigLocalization() { }

        protected virtual void ConfigGUI() { }

    }

    public class LocalizationVar
    {
        private string key;
        private string source;

        public LocalizationVar(string key, string source)
        {
            this.key = key;
            this.source = source;
        }

        public string Localize(string localizationKey)
        {
            return "";
        }
    }

    public class QuestContextSolo
    {
        public string ParticipantsVarName;

        public QuestContextSolo()
        {
        }

        public QuestContextSolo(string varName)
        {
            this.ParticipantsVarName = varName;
        }
    }

    public class RepetitionRules
    {
        private int numberOfOccurrencesPerGame;
        private int numberOfOccurrencesPerEmpire;
        private int numberOfConcurrentInstances;

        public RepetitionRules(int perGame, int perEmpire, int instances)
        {
            this.numberOfOccurrencesPerGame = perGame;
            this.numberOfOccurrencesPerEmpire = perEmpire;
            this.numberOfConcurrentInstances = instances;
        }
    }

    public class ObjectiveSet
    {
        public string Politics;
        public string title;
        public string description;
        public string tooltipDescription;
        public string outcomeCompleted;
        private Objective objective;

        public ObjectiveSet(string Politics)
        {
            this.Politics = Politics;
        }

        public ObjectiveSet Title(string title)
        {
            this.title = title;
            return this;
        }

        public ObjectiveSet Description(string description)
        {
            this.description = description;
            return this;
        }

        public ObjectiveSet TooltipDescription(string tooltipDescription)
        {
            this.tooltipDescription = tooltipDescription;
            return this;
        }

        public ObjectiveSet OutcomeCompleted(string outcomeCompleted)
        {
            this.outcomeCompleted = outcomeCompleted;
            return this;
        }

        public ObjectiveSet Objective(string name, string value)
        {
            this.objective = new Objective(name, value);
            return this;
        }
    }

    public class Objective
    {
        public string Name;
        public string Value;

        public Objective(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }

    public class Step
    {
        public string Name;
        public List<ObjectiveSet> objectiveSets = new List<ObjectiveSet>();

        public Step(string Name)
        {
            this.Name = Name;
        }

        public ObjectiveSet AddObjectiveSet(string Politics)
        {
            ObjectiveSet newObjectiveSet = new ObjectiveSet(Politics);
            objectiveSets.Add(newObjectiveSet);
            return newObjectiveSet;
        }
    }
}
