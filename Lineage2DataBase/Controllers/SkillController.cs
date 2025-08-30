using Lineage2DataBase.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lineage2DataBase.Sdk.Dto;
using Mapster;
using System.Collections;

namespace Lineage2DataBase.Api.Controllers
{
    ///<summary>
    /// qwerty_2
    ///</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private readonly ILogger<SkillController> _logger;
        private readonly ISkillsService _skillsService;
        private readonly IClassService _classService;
        /// <summary>
        /// qwerty_1
        /// </summary>
        /// <param name="skillsService"></param>
        /// <param name="logger"></param>
        /// <param name="classService"></param>
        public SkillController(ISkillsService skillsService,
                    ILogger<SkillController> logger,
                    IClassService classService)
        {
            _skillsService = skillsService;
            _logger = logger;
            _classService = classService;
        }

        /// <summary>
        /// Возвращает список навыков последнего уровня для указанного класса и уровня персонажа.
        /// </summary>
        /// <example>
        /// GET api/Skill/GetSkills?className=Artisan level=36
        /// </example>
        /// <param name="className"> название класса персонажа для которого нужно получить скиллы </param>
        /// <param name="level">Уровень персонажа для которого нужно получить скиллы</param>
        /// <param name="ct"> Токен отмены асинхронной операции </param>
        [HttpGet("get-skill")]
        public async Task<ActionResult<IEnumerable<SkillDto>>> GetSkillsAsync(string className, int level, CancellationToken ct)
        {
            try
            {
                IEnumerable<Services.Models.Skill> skills = await _skillsService.GetSkillsAsync(className, level, ct);
                return Ok(skills.Adapt<IEnumerable<SkillDto>>());

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting skills for class {ClassName} at level {Level}", className, level);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }

        /// <summary>
        /// Обновляет или добавляет класс
        /// </summary>
        /// <param name="classDto"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        [HttpPost("update-class")]
        public async Task<IActionResult> AddSkills([FromBody] ClassDto classDto, CancellationToken ct)
        {
            await _classService.AddOrUpdateClassAsync(classDto.Adapt<Services.Models.Class>(), ct);
            // Логика для добавления навыков
            return Ok();
        }
    }
}
