using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    void Start()
    {
        //create a Dictionary with string key and int value pairs
        Dictionary<string, int> cityPopulation = new Dictionary<string, int>();
        cityPopulation.Add("Tokyo", 38000000);
        cityPopulation.Add("Delhi", 25700000);
        cityPopulation.Add("Shangai", 23700000);
        cityPopulation.Add("San Paulo", 21100000);
        cityPopulation.Add("Mexico City", 21000000);

        //Read all the data
        Debug.Log("City Population");

        foreach(KeyValuePair<string, int> city in cityPopulation)
        {
           Debug.Log("City: " + city.Key + ", Population" + city.Value);
        }

       Debug.Log("Total number of cities: " + cityPopulation.Count);
    }
}
