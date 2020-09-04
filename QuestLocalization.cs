using System.Collections.Generic;

namespace QuesToolApp
{
    public class QuestLocalization
    {
        public enum Key
        {
            Title, Description, Reward, Outpost, TooltipsOutpostTitle,
            ChoiceStep, ChoiceDescription, ChoiceObjective, ChoiceObjectiveTooltip, ChoiceOutcome
        };

        private readonly string questName;
        private readonly Dictionary<string, string> locales = new Dictionary<string, string>();

        public QuestLocalization(string questName)
        {
            this.questName = questName;
        }

        public string GetKey(Key key)
        {
            return string.Format("{0}-{1}", questName, key);
        }

        public string GetKey(Key key, int option)
        {
            return string.Format("{0}-{1}{2}", questName, key, option);
        }

        private string GetValue(Key key)
        {
            return locales[GetKey(key)];
        }

        private string GetValue(int option, Key key)
        {
            return locales[GetKey(key, option)];
        }

        private void SetValue(Key key, string value)
        {
            locales[GetKey(key)] = value;
        }

        private void SetValue(string value, int option, Key key)
        {
            locales[GetKey(key, option)] = value;
        }

        public string this[Key key]
        {
            get => GetValue(key);

            set => SetValue(key, value);
        }

        public string this[Key key, int index]
        {
            get => GetValue(index, key);

            set => SetValue(value, index, key);
        }
    }
}
