using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass 
{
    
	public void MageClass()
	{
		// newcharacter.class = "Class here"

		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise wizard";
		Stamina = 12;
		Enduance = 14;
		Strength = 10;
		Intellect = 15;

	}
    
}
