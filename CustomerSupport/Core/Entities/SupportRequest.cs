namespace CustomerSupport.Core.Entities
{
    public class SupportRequest
    {
        public int Level { get; }
        public string Description { get; }

        public SupportRequest(int level, string description)
        {
            Level = level;
            Description = description;
        }
    }
}