using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSpawn : MonoBehaviour
{
    public GameObject[] shopPrefabs;
    public GameObject[] shopPrefabsonmap;
    public int i;
    public int b;
    public int c;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnShop();
    }
    void spawnShop()
    {
        switch (i)
        {
            case 1:
                b = 0;
                if (b < c) // количество объектов на карте vs количество купленных
                {
                    Debug.Log("1"); // cпавн объекта 1 
                    
                }
                
                break;
            case 2:
                b = 0;
                if (b < c)
                {
                    Debug.Log("2"); // cпавн объекта 2

                }
                break;
            case 3:
                b = 0;
                if (b < c)
                {
                    Debug.Log("3");
                    
                }
                break;
            case 4:
                b = 0;
                if (b < c)
                {
                    Debug.Log("4");
                    
                }
                break;
            case 5:
                b = 0;
                if (b < c)
                {
                    Debug.Log("5");
                   
                }
                break;
        }       
    }
   

}
