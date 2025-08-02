using Lineage2DataBase.DataAccess.Entities;

namespace Lineage2DataBase.DataAccess.Abstractions
{
    /// <summary>
    ///     
    /// </summary>
    public interface ISkillRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SkillEntity>> GetSkillByClass();
    }
}
