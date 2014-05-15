using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmallCrew : MonoBehaviour {

    string m_size = "S";
    int m_holes = 4;
    int m_health = 40;

    IDictionary<string, int> m_storage = new Dictionary<string, int>();

    int currentTech = 0;
    int maxTech = 2;

    void Start()
    {
        m_storage["Crew"] = 3;
    }

    void Upgrade()
    {
        if (currentTech < maxTech)
        {
            m_storage["Crew"] += 1;
            currentTech++;
        }
        else Debug.Log("Already at max tech level");
    }
}
