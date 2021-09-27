using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSpawn : MonoBehaviour
{
    public int i;
    public int b;
    public int c;

    public GameObject[] shopPrefabs;
    public GameObject[] shopPrefabsmap1;
    public GameObject[] shopPrefabsmap2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shopPrefabsmap1 = GameObject.FindGameObjectsWithTag("Shesterenka");
        shopPrefabsmap2 = GameObject.FindGameObjectsWithTag("Wire");
        spawnShop();
        
    }

    void spawnShop()
    {
        switch (i)
        {
            case 1:
                b = shopPrefabsmap1.Length;
                Debug.Log(b);
                Debug.Log(c);
                if (b < c) // количество объектов на карте vs количество купленных
                {
                    Instantiate(shopPrefabs[0], gameObject.transform.position, shopPrefabs[0].transform.rotation);
                }

                break;
            case 2:
                b = shopPrefabsmap2.Length;
                Debug.Log(b);
                Debug.Log(c);
                Debug.Log("2");
                if (b < c)
                {
                    
                    Instantiate(shopPrefabs[1], gameObject.transform.position, shopPrefabs[1].transform.rotation);
                }
                break;
        }

    }
}
