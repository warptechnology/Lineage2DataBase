using Lineage2DataBase.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        /// <summary>
        /// qwerty_1
        /// </summary>
        /// <param name="skillsService"></param>
        /// <param name="logger"></param>
        public SkillController(ISkillsService skillsService,
                    ILogger<SkillController> logger)
        {
            _skillsService = skillsService;
            _logger = logger;
        }

        /// <summary>
        /// qwerty
        /// </summary>
        /// <param name="className">qwerty_0_1</param>
        /// <param name="level">qwerty_0_2</param>
        /// <param name="cancellationToken">qwerty_0_3</param>
        /// <returns>qwerty_0_0_1</returns>
        [HttpGet("GetSkills")]
        public async Task<IActionResult> GetSkillsAsync(string className, int level, CancellationToken cancellationToken = default)
        {
            try
            {
                var skills = await _skillsService.GetSkillsAsync(className, level, cancellationToken);
                return Ok(skills);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting skills for class {ClassName} at level {Level}", className, level);
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
