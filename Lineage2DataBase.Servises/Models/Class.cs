namespace Lineage2DataBase.Services.Models
{
    /// <summary>
    /// / Представляет класс персонажа в игре.
    /// </summary>
    public class Class
    {
        /// <summary>
        /// Уникальный идентификатор класса.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название класса.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Список навыков, доступных для этого класса на разных уровнях.
        /// </summary>
        public List<LevelSkill> Skills { get; set; } = new();
    }
}