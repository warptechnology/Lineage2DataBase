using Lineage2DataBase.Services.Models;
namespace Lineage2DataBase.Services.Abstractions;

/// <summary>
///     
/// </summary>
public interface ISkillsService
{
    /// <summary>
    ///         
    /// </summary>
    /// <param name="className"></param>
    /// <param name="level"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<Skill>> GetSkillsAsync(string className, int level, CancellationToken cancellationToken = default);
}

