using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StarData
{
    public int snow1, snow2, snow3, snow4, snow5, snow6, snow7, snow8, snow9, snow10;
    public int city1, city2, city3, city4, city5, city6, city7, city8, city9, city10;
    public int spirit1, spirit2, spirit3;



    public SerializableDictionary<string, bool> starsCollected;

    public StarData()
    {
        this.snow1 = 0;
        this.snow2 = 0;
        this.snow3 = 0;
        this.snow4 = 0;
        this.snow5 = 0;
        this.snow6 = 0;
        this.snow7 = 0;
        this.snow8 = 0;
        this.snow9 = 0;
        this.snow10 = 0;

        this.city1 = 0;
        this.city2 = 0;
        this.city3 = 0;
        this.city4 = 0;
        this.city5 = 0;
        this.city6 = 0;
        this.city7 = 0;
        this.city8 = 0;
        this.city9 = 0;
        this.city10 = 0;

        this.spirit1 = 0;
        this.spirit2 = 0;
        this.spirit3 = 0;




        starsCollected = new SerializableDictionary<string, bool>();
    }
}
