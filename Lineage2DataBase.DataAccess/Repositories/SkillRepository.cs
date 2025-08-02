using Lineage2DataBase.DataAccess.Abstractions;
using Lineage2DataBase.DataAccess.Entities;

namespace Lineage2DataBase.DataAccess.Repositories
{
    /// <summary>
    ///     
    /// </summary>
    public class SkillRepository : ISkillRepository
    {
        private readonly string _connectionString;
        /// <summary>
        /// 
        /// </summary>
        
        public SkillRepository()
        {
            _connectionString = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ///<param name="level">level</param>
        ///<param name="className">className</param>
        ///<param name="cancellationToken">cancellationToken</param>    

        public Task<List<SkillEntity>> GetSkillByClass(string className, int level, CancellationToken cancellationToken = default)
        
          =>  Task.FromResult(new List<SkillEntity> { new() { Name = _connectionString } });
        
    }
}
