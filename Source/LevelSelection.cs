using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour, IDataPersistence
{
    private int startLevel = 5;

    public int CurrentStage;
    public Button[] lvlButtons;
    public Image[] lockImage;

    public GameObject[] level1Star;
    public GameObject[] level2Star;
    public GameObject[] level3Star;
    public GameObject[] level4Star;
    public GameObject[] level5Star;
    public GameObject[] level6Star;
    public GameObject[] level7Star;
    public GameObject[] level8Star;
    public GameObject[] level9Star;
    public GameObject[] level10Star;

    private int snow1, snow2, snow3, snow4, snow5, snow6, snow7, snow8, snow9, snow10;
    private int city1, city2, city3, city4, city5, city6, city7, city8, city9, city10;
    private int spirit1, spirit2, spirit3;



    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", startLevel);

        if (CurrentStage == 1)
        {
            for (int i = 0; i < lvlButtons.Length; i++)
            {
                if (i + startLevel > levelAt)
                {
                    lvlButtons[i].interactable = false;
                    lockImage[i].gameObject.SetActive(true);
                }
            }
        }
        if (CurrentStage == 2)
        {
            for (int i = 0; i < lvlButtons.Length; i++)
            {
                if (i + startLevel + 10 > levelAt)
                {
                    lvlButtons[i].interactable = false;
                    lockImage[i].gameObject.SetActive(true);
                }
            }
        }
        if (CurrentStage == 3)
        {
            for (int i = 0; i < lvlButtons.Length; i++)
            {
                if (i + startLevel + 18 > levelAt)
                {
                    lvlButtons[i].interactable = false;
                    lockImage[i].gameObject.SetActive(true);
                }
            }
        }

        /////////////////////snow///////////////////////////////
        if (CurrentStage == 1)
        {
            //snow1 set star
            if (snow1 < 5)
            {
                return;
            }
            else if (snow1 >= 5 && snow1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (snow1 >= 7 && snow1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }
            //snow2 set star
            if (snow2 < 5)
            {
                return;
            }
            else if (snow2 >= 5 && snow2 < 7)
            {
                level2Star[0].SetActive(false);
            }
            else if (snow2 >= 7 && snow2 < 10)
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
            }
            else
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
                level2Star[2].SetActive(false);
            }
            //snow3 set star
            if (snow3 < 5)
            {
                return;
            }
            else if (snow3 >= 5 && snow3 < 7)
            {
                level3Star[0].SetActive(false);
            }

            else if (snow3 >= 7 && snow3 < 10)
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
            }
            else
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
                level3Star[2].SetActive(false);
            }
            //snow4 set star
            if (snow4 < 5)
            {
                return;
            }
            else if (snow4 >= 5 && snow4 < 7)
            {
                level4Star[0].SetActive(false);
            }

            else if (snow4 >= 7 && snow4 < 10)
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
            }
            else
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
                level4Star[2].SetActive(false);
            }
            //snow5 set star
            if (snow5 < 5)
            {
                return;
            }
            else if (snow5 >= 5 && snow5 < 7)
            {
                level5Star[0].SetActive(false);
            }

            else if (snow5 >= 7 && snow5 < 10)
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
            }
            else
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
                level5Star[2].SetActive(false);
            }
            //snow6 set star
            if (snow6 < 5)
            {
                return;
            }
            else if (snow6 >= 5 && snow6 < 7)
            {
                level6Star[0].SetActive(false);
            }

            else if (snow6 >= 7 && snow6 < 10)
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
            }
            else
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
                level6Star[2].SetActive(false);
            }
            //snow7 set star
            if (snow7 < 5)
            {
                return;
            }
            else if (snow7 >= 5 && snow7 < 7)
            {
                level7Star[0].SetActive(false);
            }

            else if (snow7 >= 7 && snow7 < 10)
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
            }
            else
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
                level7Star[2].SetActive(false);
            }
            //snow8 set star
            if (snow8 < 5)
            {
                return;
            }
            else if (snow8 >= 5 && snow8 < 7)
            {
                level8Star[0].SetActive(false);
            }

            else if (snow8 >= 7 && snow8 < 10)
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
            }
            else
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
                level8Star[2].SetActive(false);
            }
            //snow9 set star
            if (snow9 < 5)
            {
                return;
            }
            else if (snow9 >= 5 && snow9 < 7)
            {
                level9Star[0].SetActive(false);
            }

            else if (snow9 >= 7 && snow9 < 10)
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
            }
            else
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
                level9Star[2].SetActive(false);
            }
            //snow10 set star
            if (snow10 < 5)
            {
                return;
            }
            else if (snow10 >= 5 && snow10 < 7)
            {
                level10Star[0].SetActive(false);
            }

            else if (snow10 >= 7 && snow10 < 10)
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
            }
            else
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
                level10Star[2].SetActive(false);
            }
        }
        /////////////////////city///////////////////////////////
        if (CurrentStage == 2)
        {
            //city1 set star
            if (city1 < 5)
            {
                return;
            }
            else if (city1 >= 5 && city1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (city1 >= 7 && city1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }
            //city2 set star
            if (city2 < 5)
            {
                return;
            }
            else if (city2 >= 5 && city2 < 7)
            {
                level2Star[0].SetActive(false);
            }
            else if (city2 >= 7 && city2 < 10)
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
            }
            else
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
                level2Star[2].SetActive(false);
            }
            //city3 set star
            if (city3 < 5)
            {
                return;
            }
            else if (city3 >= 5 && city3 < 7)
            {
                level3Star[0].SetActive(false);
            }
            else if (city3 >= 7 && city3 < 10)
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
            }
            else
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
                level3Star[2].SetActive(false);
            }
            //city4 set star
            if (city4 < 5)
            {
                return;
            }
            else if (city4 >= 5 && city4 < 7)
            {
                level4Star[0].SetActive(false);
            }
            else if (city4 >= 7 && city4 < 10)
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
            }
            else
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
                level4Star[2].SetActive(false);
            }
            //city5 set star
            if (city5 < 5)
            {
                return;
            }
            else if (city5 >= 5 && city5 < 7)
            {
                level5Star[0].SetActive(false);
            }
            else if (city5 >= 7 && city5 < 10)
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
            }
            else
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
                level5Star[2].SetActive(false);
            }
            //city6 set star
            if (city6 < 5)
            {
                return;
            }
            else if (city6 >= 5 && city6 < 7)
            {
                level6Star[0].SetActive(false);
            }
            else if (city6 >= 7 && city6 < 10)
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
            }
            else
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
                level6Star[2].SetActive(false);
            }
            //city7 set star
            if (city7 < 5)
            {
                return;
            }
            else if (city7 >= 5 && city7 < 7)
            {
                level7Star[0].SetActive(false);
            }
            else if (city7 >= 7 && city7 < 10)
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
            }
            else
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
                level7Star[2].SetActive(false);
            }
            //city8 set star
            if (city8 < 5)
            {
                return;
            }
            else if (city8 >= 5 && city8 < 7)
            {
                level8Star[0].SetActive(false);
            }
            else if (city8 >= 7 && city8 < 10)
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
            }
            else
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
                level8Star[2].SetActive(false);
            }
            //city9 set star
            /*
            if (city9 < 5)
            {
                return;
            }
            else if (city9 >= 5 && city9 < 7)
            {
                level9Star[0].SetActive(false);
            }
            else if (city9 >= 7 && city9 < 10)
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
            }
            else
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
                level9Star[2].SetActive(false);
            }
            //city10 set star
            if (city10 < 5)
            {
                return;
            }
            else if (city10 >= 5 && city10 < 7)
            {
                level10Star[0].SetActive(false);
            }
            else if (city10 >= 7 && city10 < 10)
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
            }
            else
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
                level10Star[2].SetActive(false);
            }
            */


        }
        /////////////////////sprit///////////////////////////////
        if (CurrentStage == 3)
        {
            //spirit1 set star
            if (spirit1 < 5)
            {
                return;
            }
            else if (spirit1 >= 5 && spirit1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (spirit1 >= 7 && spirit1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }

        }
        
    }

    public void Update()
    {
        /////////////////////snow///////////////////////////////
        if (CurrentStage == 1)
        {
            //snow1 set star
            if (snow1 < 5)
            {
                return;
            }
            else if (snow1 >= 5 && snow1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (snow1 >= 7 && snow1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }
            //snow2 set star
            if (snow2 < 5)
            {
                return;
            }
            else if (snow2 >= 5 && snow2 < 7)
            {
                level2Star[0].SetActive(false);
            }
            else if (snow2 >= 7 && snow2 < 10)
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
            }
            else
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
                level2Star[2].SetActive(false);
            }
            //snow3 set star
            if (snow3 < 5)
            {
                return;
            }
            else if (snow3 >= 5 && snow3 < 7)
            {
                level3Star[0].SetActive(false);
            }

            else if (snow3 >= 7 && snow3 < 10)
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
            }
            else
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
                level3Star[2].SetActive(false);
            }
            //snow4 set star
            if (snow4 < 5)
            {
                return;
            }
            else if (snow4 >= 5 && snow4 < 7)
            {
                level4Star[0].SetActive(false);
            }

            else if (snow4 >= 7 && snow4 < 10)
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
            }
            else
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
                level4Star[2].SetActive(false);
            }
            //snow5 set star
            if (snow5 < 5)
            {
                return;
            }
            else if (snow5 >= 5 && snow5 < 7)
            {
                level5Star[0].SetActive(false);
            }

            else if (snow5 >= 7 && snow5 < 10)
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
            }
            else
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
                level5Star[2].SetActive(false);
            }
            //snow6 set star
            if (snow6 < 5)
            {
                return;
            }
            else if (snow6 >= 5 && snow6 < 7)
            {
                level6Star[0].SetActive(false);
            }

            else if (snow6 >= 7 && snow6 < 10)
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
            }
            else
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
                level6Star[2].SetActive(false);
            }
            //snow7 set star
            if (snow7 < 5)
            {
                return;
            }
            else if (snow7 >= 5 && snow7 < 7)
            {
                level7Star[0].SetActive(false);
            }

            else if (snow7 >= 7 && snow7 < 10)
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
            }
            else
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
                level7Star[2].SetActive(false);
            }
            //snow8 set star
            if (snow8 < 5)
            {
                return;
            }
            else if (snow8 >= 5 && snow8 < 7)
            {
                level8Star[0].SetActive(false);
            }

            else if (snow8 >= 7 && snow8 < 10)
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
            }
            else
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
                level8Star[2].SetActive(false);
            }
            //snow9 set star
            if (snow9 < 5)
            {
                return;
            }
            else if (snow9 >= 5 && snow9 < 7)
            {
                level9Star[0].SetActive(false);
            }

            else if (snow9 >= 7 && snow9 < 10)
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
            }
            else
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
                level9Star[2].SetActive(false);
            }
            //snow10 set star
            if (snow10 < 5)
            {
                return;
            }
            else if (snow10 >= 5 && snow10 < 7)
            {
                level10Star[0].SetActive(false);
            }

            else if (snow10 >= 7 && snow10 < 10)
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
            }
            else
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
                level10Star[2].SetActive(false);
            }
        }
        /////////////////////city///////////////////////////////
        if (CurrentStage == 2)
        {
            //city1 set star
            if (city1 < 5)
            {
                return;
            }
            else if (city1 >= 5 && city1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (city1 >= 7 && city1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }
            //city2 set star
            if (city2 < 5)
            {
                return;
            }
            else if (city2 >= 5 && city2 < 7)
            {
                level2Star[0].SetActive(false);
            }
            else if (city2 >= 7 && city2 < 10)
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
            }
            else
            {
                level2Star[0].SetActive(false);
                level2Star[1].SetActive(false);
                level2Star[2].SetActive(false);
            }
            //city3 set star
            if (city3 < 5)
            {
                return;
            }
            else if (city3 >= 5 && city3 < 7)
            {
                level3Star[0].SetActive(false);
            }
            else if (city3 >= 7 && city3 < 10)
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
            }
            else
            {
                level3Star[0].SetActive(false);
                level3Star[1].SetActive(false);
                level3Star[2].SetActive(false);
            }
            //city4 set star
            if (city4 < 5)
            {
                return;
            }
            else if (city4 >= 5 && city4 < 7)
            {
                level4Star[0].SetActive(false);
            }
            else if (city4 >= 7 && city4 < 10)
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
            }
            else
            {
                level4Star[0].SetActive(false);
                level4Star[1].SetActive(false);
                level4Star[2].SetActive(false);
            }
            //city5 set star
            if (city5 < 5)
            {
                return;
            }
            else if (city5 >= 5 && city5 < 7)
            {
                level5Star[0].SetActive(false);
            }
            else if (city5 >= 7 && city5 < 10)
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
            }
            else
            {
                level5Star[0].SetActive(false);
                level5Star[1].SetActive(false);
                level5Star[2].SetActive(false);
            }
            //city6 set star
            if (city6 < 5)
            {
                return;
            }
            else if (city6 >= 5 && city6 < 7)
            {
                level6Star[0].SetActive(false);
            }
            else if (city6 >= 7 && city6 < 10)
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
            }
            else
            {
                level6Star[0].SetActive(false);
                level6Star[1].SetActive(false);
                level6Star[2].SetActive(false);
            }
            //city7 set star
            if (city7 < 5)
            {
                return;
            }
            else if (city7 >= 5 && city7 < 7)
            {
                level7Star[0].SetActive(false);
            }
            else if (city7 >= 7 && city7 < 10)
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
            }
            else
            {
                level7Star[0].SetActive(false);
                level7Star[1].SetActive(false);
                level7Star[2].SetActive(false);
            }
            //city8 set star
            if (city8 < 5)
            {
                return;
            }
            else if (city8 >= 5 && city8 < 7)
            {
                level8Star[0].SetActive(false);
            }
            else if (city8 >= 7 && city8 < 10)
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
            }
            else
            {
                level8Star[0].SetActive(false);
                level8Star[1].SetActive(false);
                level8Star[2].SetActive(false);
            }
            //city9 set star
            /*
            if (city9 < 5)
            {
                return;
            }
            else if (city9 >= 5 && city9 < 7)
            {
                level9Star[0].SetActive(false);
            }
            else if (city9 >= 7 && city9 < 10)
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
            }
            else
            {
                level9Star[0].SetActive(false);
                level9Star[1].SetActive(false);
                level9Star[2].SetActive(false);
            }
            //city10 set star
            if (city10 < 5)
            {
                return;
            }
            else if (city10 >= 5 && city10 < 7)
            {
                level10Star[0].SetActive(false);
            }
            else if (city10 >= 7 && city10 < 10)
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
            }
            else
            {
                level10Star[0].SetActive(false);
                level10Star[1].SetActive(false);
                level10Star[2].SetActive(false);
            }
            */


        }
        /////////////////////sprit///////////////////////////////
        if (CurrentStage == 3)
        {
            //spirit1 set star
            if (spirit1 < 5)
            {
                return;
            }
            else if (spirit1 >= 5 && spirit1 < 7)
            {
                level1Star[0].SetActive(false);
            }
            else if (spirit1 >= 7 && spirit1 < 10)
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
            }
            else
            {
                level1Star[0].SetActive(false);
                level1Star[1].SetActive(false);
                level1Star[2].SetActive(false);
            }

        }
    }

    public void LoadCollectableData(StarData data)
    {
        snow1 = data.snow1;
        snow2 = data.snow2;
        snow3 = data.snow3;
        snow4 = data.snow4;
        snow5 = data.snow5;
        snow6 = data.snow6;
        snow7 = data.snow7;
        snow8 = data.snow8;
        snow9 = data.snow9;
        snow10 = data.snow10;

        city1 = data.city1;
        city2 = data.city2;
        city3 = data.city3;
        city4 = data.city4;
        city5 = data.city5;
        city6 = data.city6;
        city7 = data.city7;
        city8 = data.city8;
        city9 = data.city9;
        city10 = data.city10;

        spirit1 = data.spirit1;
        spirit2 = data.spirit2;
        spirit3 = data.spirit3;   
    }

    public void SaveCollectableData(StarData data)
    {
    }


}
