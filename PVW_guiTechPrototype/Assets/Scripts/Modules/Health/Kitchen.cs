using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Kitchen : MonoBehaviour {

    string m_size = "M";
    int m_holes = 3;
    int m_health = 30;

    IDictionary<string, int> m_effect = new Dictionary<string, int>();

    int currentTech = 0;
    int maxTech = 2;

    void Start()
    {
        m_effect["Food"] = 4;
        m_effect["Crew"] = -1;
    }

    void Upgrade()
    {
        if (currentTech < maxTech)
        {
            m_effect["Food"] *= 2;
            m_effect["Crew"] -= 2;
            currentTech++;
        }
        else Debug.Log("Already at max tech level");
    }
}
