using Lineage2DataBase.DataAccess.Abstractions;
using Lineage2DataBase.DataAccess.Entities;

namespace Lineage2DataBase.DataAccess.Repositories
{
    /// <summary>
    ///     
    /// </summary>
    public class SkillRepository : ISkillRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public Task<IEnumerable<SkillEntity>> GetSkillByClass() => Task.FromResult(new List<SkillEntity> { new() });
    }
}
