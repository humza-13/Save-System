using System;

namespace Phoenix.SaveLoad
{
    [Serializable]
    public class GameData : SaveableData, ISaveable
    {
        public string Level { get; set; }

        public GameData(string key) : base(key) { }
        public string Key => key;
        
        
    }
}