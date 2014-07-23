using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class RarityGenerator : MonoBehaviour
{
    public enum WeaponRarity
    {
        Common,
        Special,
        Rare,
        UltraRare,
        Legendary
    }

    public bool generateNewRarity = false;
    public int numberOfNewItems = 100;

    //public List<WeaponRarity> Rarities = new List<WeaponRarity>();

    public int numberOfCommon = 0;
    public int numberOfSpecial = 0;
    public int numberOfRare = 0;
    public int numberOfUltraRare = 0;
    public int numberOfLegendary = 0;

	// Use this for initialization
	void Start () {
	    GenerateNewRarities(numberOfNewItems);
	}
	
	// Update is called once per frame
	void Update () {

	    if (generateNewRarity)
	    {
	        generateNewRarity = false;
            GenerateNewRarities(numberOfNewItems);
	    }
	}

    public void GenerateNewRarities(int numberofItems)
    {
        for (int i = 0; i < numberofItems; i++)
        {
            int random = (int) (1000 * Random.value);

            if (random <= 500)
            {
                numberOfCommon++;
            }
            else if (random > 600 && random <= 900)
            {
                numberOfSpecial++;
            }
            else if (random > 900 && random <= 975)
            {
                numberOfRare++;
            }
            else if (random > 975 && random <= 995)
            {
                numberOfUltraRare++;
            }
            else if(random > 995 && random <=1000)
            {
                numberOfLegendary++;
            }



            //int rand1 = (int) (Random.value * 10);
            //int rand2 = (int) (Random.value * 10);
            //int rand3 = (int)(Random.value * 10);   
        }

    }
}
