using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerStorage : MonoBehaviour {

    string m_size = "S";
    int m_holes = 4;
    int m_health = 50;

    int currentTech = 0;
    int maxTech = 2;

    IDictionary<string, int> m_storage = new Dictionary<string, int>();

    void Start()
    {
        m_storage["power"] = 1000;
    }

    void Upgrade()
    {
        if (currentTech < maxTech)
        {
            m_storage["power"] *= 2;
            currentTech++;
        }
        else Debug.Log("Already at max tech level");
    }
}
