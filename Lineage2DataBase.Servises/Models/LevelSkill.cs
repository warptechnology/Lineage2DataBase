namespace Lineage2DataBase.Services.Models
{
    /// <summary>
    /// Представляет навык, доступный на определенном уровне.
    /// </summary>
    public class LevelSkill
    {
        /// <summary>
        /// Уровень, на котором доступен навык.
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Навык, доступный на этом уровне.
        /// </summary>
        public Skill? Skill { get; set; } = null;
    }
}