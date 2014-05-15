using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SolarPanel : MonoBehaviour {

    string m_size = "s";
    int m_holes = 4;
    int m_health = 50;

    int currentTech = 0;
    int maxTech = 2;

    IDictionary<string, int> m_storage = Dictionary<string, int>();

    void Start()
    {
        m_storage.Add["Power_gen", 1];
    }

    void Upgrade()
    {
        if (currentTech < maxTech)
        {
            m_storage["Power_gen"] *= 2;
        }
        else Debug.Log("Already at max tech level.");
    }
}
