using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour 
{
    
	BaseCharacterClass class1 = new BaseMageClass();
	BaseCharacterClass class2 = new BaseWarriorClass();

	void Start () 
    {
	
	}

	void Update () 
    {
	
	}

	void OnGUI()
	{
		GUILayout.Label(class1.CharacterClassName);
		GUILayout.Label(class1.CharacterClassDescription);
		GUILayout.Label("Intellect: " + class1.Intellect);
		GUILayout.Label(class2.CharacterClassName);
		GUILayout.Label(class2.CharacterClassDescription);
		GUILayout.Label("Strength: " + class1.Strength);
	}
    
}
