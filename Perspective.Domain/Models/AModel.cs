namespace Perspective.Domain
{
    public abstract class AModel
    {
        public string Name{get;set;}
        public int Id{get;set;}
        
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}