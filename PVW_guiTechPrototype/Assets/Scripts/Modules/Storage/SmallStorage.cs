using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmallStorage : MonoBehaviour {

	string m_size = "S";
	int m_holes = 2;
	int m_health = 20;

	int currentTech = 0;
	int maxTech = 2;

	IDictionary<string, int> m_storage = new Dictionary<string, int>();

	void Start()
	{
		m_storage.Add("metal", 100);
		m_storage.Add("oxygen", 100);
		m_storage.Add("water", 100);
	}

	void Upgrade()
	{
		if (currentTech < maxTech) {
						m_storage ["metal"] *= 2;
						m_storage ["oxygen"] *= 2;
						m_storage ["water"] *= 2;
                        currentTech++;
				} else {
			Debug.Log("Already at max tech level.");
				}
	}
}
