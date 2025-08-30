using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lineage2DataBase.Sdk.Dto;

public class ClassDto
{
    public string Name { get; init; } = string.Empty;
    public List<LevelSkillDto> Skills { get; init; } = new();
}


/*
 {
    "Name": "Fighter",
    "Skills": [
        {
            "Level": 1,
            "Skills": {
                "Name": "Power Strike",
                "Level": 5,
                "Description": "A powerful strike that deals increased damage.",
                "IsActive": true,
                "MpConsume": 10.0,
                "WeaponsAllowed": "SWORD",
                "Target": "ENEMY"
            }
        },
        {
            "Level": 5,
            "Skills": {
                "Name": "Armor Mastery",
                "Level": 1,
                "Description": "Increases defense when wearing any armor.",
                "IsActive": false,
                "MpConsume": 0.0,
                "WeaponsAllowed": "SHIELD",
                "Target": "SELF"
            }
        }

 }
 */

