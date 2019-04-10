namespace TheWitcher3Thai
{
    public class TranslateResult
    {
        public string Name { get; set; }
        public float AllMessage { get; set; }
        public float Translate { get; set; }
        public float Skip { get; set; }

        public TranslateResult(string name, float all, float skip)
        {
            Name = name;
            AllMessage = all;
            Skip = skip;
            Translate = all - skip;            
        }

        float PercentComplete
        {
            get
            {
                return (Translate / AllMessage) * 100f;
            }
        }

        public override string ToString()
        {
            return $@"{Name} :  {Translate}/{AllMessage} ({PercentComplete.ToString("0.00")}%)";
        }
    }
}
