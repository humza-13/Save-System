using Phoenix.Singleton;
using UnityEngine;

namespace Phoenix.SaveLoad
{
    public class SaveTest : PersistentSingleton<SaveTest>
    {
        public ISaveable data1;

        private IDataService dataHandler;

        protected override void Awake()
        {
            base.Awake();
            dataHandler = new DataService(new Serializer());
            data1 = new GameData("Test")
            {
                Level = "1"
            };
            if (data1 is GameData gameData)
            {
                dataHandler.Save<GameData>(gameData);
            }
        }

        public void Save()
        {
            data1 = new GameData("Test")
            {
                Level = "2"
            };
            if (data1 is GameData gameData)
            {
                dataHandler.Save<GameData>(gameData);
            }
            
        }

        public void Load()
        {
            Debug.Log(dataHandler.Load<GameData>(data1.Key).Level);
        }
        
    }
}