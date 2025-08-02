using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2DataBase.Services.Models
{
    /// <summary>
    /// Представляет навык в базе данных Lineage2.
    /// </summary>
    public record Skill
    {
        /// <summary>
        /// имя навыка.
        /// </summary>
        public string Name  { get; init; }=string.Empty;

        /// <summary>
        /// 
        /// уровень навыка.
        /// </summary>
        public int Level { get; init; }

        /// <summary>
        /// описание навыка.
        /// </summary>
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// сила навыка.
        /// </summary>
        public int Power { get; init; }

        //TODO: добавить другие свойства, которые могут быть полезны для навыков, такие как время восстановления, стоимость маны и т.д.
    }
}
