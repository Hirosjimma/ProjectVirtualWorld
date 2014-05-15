using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CleaningService : MonoBehaviour {

    string m_size = "S";
    int m_holes = 2;
    int m_health = 15;

    IDictionary<string, int> m_effect = new Dictionary<string, int>();

    int currentTech = 0;
    int maxTech = 2;

	// Use this for initialization
	void Start () {
        m_effect["Trash"] = -4;
        m_effect["Crew"] = -1;
	}

    void Upgrade()
    {
        if (currentTech < maxTech)
        {
            m_effect["Trash"] *= 2;
            currentTech++;
        }
        else Debug.Log("Already at max tech level");
    }
}
