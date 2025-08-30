namespace Lineage2DataBase.Sdk.Dto;
/// <summary>
/// Represents a skill in the Lineage 2 game.
/// </summary>
public record SkillDto
{
    /// <summary>
    /// Название скилла.
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// Уровень скилла.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Описание скилла.
    /// </summary>
    public string Description { get; init; } = string.Empty;

    /// <summary>
    /// Скилл активный или пассивный.
    /// </summary>
    public bool IsActive { get; init; }

    /// <summary>
    /// Расход маны на использование скилла.
    /// </summary>
    public float MpConsume { get; init; }

    /// <summary>
    /// Оружие, с которым можно использовать скилл.
    /// </summary>
    public string WeaponsAllowed { get; init; } = string.Empty; //TODO: переделать на enum

    /// <summary>
    /// Цель скилла (например, SELF, PARTY, ENEMY).
    /// </summary>
    public string Target { get; init; } = "SELF";//TODO: переделать на enum
}

