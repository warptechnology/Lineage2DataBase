using Lineage2DataBase.Services.Abstractions;
using Lineage2DataBase.Services.Models;

namespace Lineage2DataBase.Services.Services;

/// <inheritdoc/>
public class SkillsService : ISkillsService
{
    /// <summary>
    /// создает новый экземпляр <see cref="SkillsService"/>.
    /// </summary>
    public SkillsService()
    {
        
    }

    /// <inheritdoc/>
    public Task<IEnumerable<Skill>> GetSkillsAsync(string className, int level, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

}

