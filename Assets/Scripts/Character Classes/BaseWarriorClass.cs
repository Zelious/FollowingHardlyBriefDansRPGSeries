using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass 
{


	// Constructor
    public BaseWarriorClass()
	{
		CharacterClassName = "Warrior";
		CharacterClassDescription = "Krog Smash!";
		Stamina = 15;
		Enduance = 12;
		Strength = 14;
		Intellect = 10;
	}

    
}
