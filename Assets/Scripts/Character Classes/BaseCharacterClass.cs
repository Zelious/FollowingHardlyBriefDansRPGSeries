using UnityEngine;
using System.Collections;

public class BaseCharacterClass
{
	string characterClassName;
	string characterClassDescription;

	// Stats
	int stamina;
	int enduance;
	int strength;
	int intellect;

	public string CharacterClassName
	{
		get
		{
			return characterClassName;
		}

		set
		{
			characterClassName = value;
		}
	}

	public string CharacterClassDescription
	{
		get
		{
			return characterClassDescription;
		}
		
		set
		{
			characterClassDescription = value;
		}
	}

	public int Stamina
	{
		get
		{
			return stamina;
		}
		
		set
		{
			stamina = value;
		}
	}

	public int Enduance
	{
		get
		{
			return enduance;
		}
		
		set
		{
			enduance = value;
		}
	}

	public int Strength
	{
		get
		{
			return strength;
		}
		
		set
		{
			strength = value;
		}
	}

	public int Intellect
	{
		get
		{
			return intellect;
		}
		
		set
		{
			intellect = value;
		}
	}
    
}











