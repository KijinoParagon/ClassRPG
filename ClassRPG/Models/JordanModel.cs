namespace ClassRPG.Models
{
    public class JordanModel
    {
        public string? Name { get; set; }
        public string? Color { get; set; }
        public Class CharacterClass { get; set; }
    }

    public enum Class
    {
        Warrior,
        Rogue,
        Priest
    }
}
