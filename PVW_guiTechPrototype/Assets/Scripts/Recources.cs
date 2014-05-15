using UnityEngine;
using System.Collections;

public class Recources : MonoBehaviour {

	private int r_Cash;
	private int r_Health;
    private int r_Damage;
    private int r_Science;
	
	private int r_Metal;
	private int r_maxMetal;
	
	private int r_Power;
	private int r_maxPower;

	private int r_Crew;
	private int r_maxCrew;

	private int r_Water;
	private int r_maxWater;

	private int r_Oxygen;
	private int r_maxOxygen;

	private int r_Food;
	private int r_maxFood;

	private int r_Waste;
	private int r_maxWaste;

	private int r_Trash;
	private int r_maxTrash;

	private int r_Medecine;
	private int r_maxMedecine;

	void Start()
	{
		r_Cash = 100;
		r_Health = 100;
        r_Damage = 0;
        r_Science = 100;

		r_maxCrew = 5;
		r_Crew = 100;

		r_maxFood = 100;
		r_Food = 100;

		r_maxMedecine = 100; 
		r_Medecine = 100;

		r_maxMetal = 100;
		r_Metal = 100;

		r_maxOxygen = 100;
		r_Oxygen = 100;

		r_maxPower = 100;
		r_Power = 100;

		r_maxTrash = 100;
		r_Trash = 100;

		r_maxWaste = 100;
		r_Waste = 100;

		r_maxWater = 100;
		r_Water = 100;
	}

	public void modifyCash(int modifier = 0)
	{
		r_Cash += modifier;
	}

	public void modifyHealth(int modifier = 0)
	{
		r_Health += modifier;
	}

	public void modifyDamage(int modifier = 0)
	{
		r_Damage += modifier;
	}

    public void modifyScience(int modifier = 0)
    {
        r_Science += modifier;
    }

	public void modifyMaxCrew(int modifier = 0)
	{
		r_maxCrew += modifier;
	}

	public void modifyCrew(int modifier = 0)
	{
		r_Crew += modifier;
	}

	public void modifyMaxFood(int modifier = 0)
	{
		r_maxFood += modifier;
	}

	public void modifyFood(int modifier = 0)
	{
		r_Food += modifier;
	}

	public void modifyMaxMedecine(int modifier = 0)
	{
		r_maxMedecine += modifier;
	}

	public void modifyMedecine(int modifier = 0)
	{
		r_Medecine += modifier;
	}

	public void modifyMaxOxygen(int modifier = 0)
	{
		r_maxOxygen += modifier;
	}

	public void modifyOxygen(int modifier = 0)
	{
		r_Oxygen += modifier;
	}

	public void modifyMaxPower(int modifier = 0)
	{
		r_maxPower += modifier;
	}

	public void modifyPower(int modifier = 0)
	{
		r_Power += modifier;
	}

	public void modifyMaxTrash(int modifier = 0)
	{
		r_maxTrash += modifier;
	}

	public void modifyTrash(int modifier = 0)
	{
		r_Trash += modifier;
	}

	public void modifyMaxWaste(int modifier = 0)
	{
		r_maxWaste += modifier;
	}

	public void modifyWaste(int modifier = 0)
	{
		r_Waste += modifier;
	}

	public void modifyMaxWater(int modifier = 0)
	{
		r_maxWater += modifier;
	}

	public void modifyWater(int modifier = 0)
	{
		r_Water += modifier;
	}

	public void modifyMaxMetal(int modifier = 0)
	{
		r_maxMetal += modifier;
	}

	public void modifyMetal(int modifier = 0)
	{
		r_Metal += modifier;
	}
}
