using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	Simulation m_Simulation = null;

	void Start()
	{
		GameObject scriptHolder = GameObject.Find("ScriptHolder");

		m_Simulation = scriptHolder.GetComponent<Simulation>();
	}

	void OnGUI()
	{
		GUILayout.Box("Main Menu");

		if (GUILayout.Button ("Start simulation"))
						m_Simulation.StartSimulation();
	}
}