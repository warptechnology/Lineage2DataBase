using Lineage2DataBase.DataAccess.Abstractions;
using Lineage2DataBase.Services.Abstractions;
using Lineage2DataBase.Services.Models;
using Microsoft.Extensions.Logging;

namespace Lineage2DataBase.Services.Services;

/// <inheritdoc/>
public class SkillsService : ISkillsService
{
    
    private readonly ILogger<SkillsService> _logger;
    private readonly ISkillRepository _skillsRepository;

    /// <summary>
    /// создает новый экземпляр <see cref="SkillsService"/>.
    /// </summary>
    /// <param name="logger">логгер для сервиса.</param>
    /// <param name="skillsRepository">репозиторий для работы со скиллами.</param>
    public SkillsService(ILogger<SkillsService> logger ,
                        ISkillRepository skillsRepository )
    {
        _logger = logger;
        _skillsRepository = skillsRepository;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Skill>> GetSkillsAsync(string className, int level, CancellationToken cancellationToken = default)
    {
        //1 получить id  навыков по классу и уровню
        //2 получить из базы данные по этим навыкам
        //3 собрать список этих скиллов и вернуть его

        var skills = await _skillsRepository.GetSkillByClass(className, level, cancellationToken);
        return skills.Select(skill => new Skill
        {
            Name = skill.Name,
            Level = 0,
            Description = "qweasd",
            Power = 100500
        });
    }

}

