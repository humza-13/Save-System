namespace Phoenix.SaveLoad
{
    public abstract class SaveableData
    {
        public string key { get; protected set; }

        protected SaveableData(string key)
        {
            this.key = key;
        }
    }
}