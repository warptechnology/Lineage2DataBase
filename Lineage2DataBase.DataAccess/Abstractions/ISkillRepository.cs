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
        /// <param name="cancellationToken">cancellationToken</param>
        /// <param name="className">className</param>
        /// <param name="level">  lvl  </param>
        Task<List<SkillEntity>> GetSkillByClass(string className, int level, CancellationToken cancellationToken = default);
    }
}
