using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSpawn : MonoBehaviour
{
    public int i;
    public int c;

    public GameObject[] shopPrefabs;
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
                if (c != 0) // c - выбранное кол-во в магазине (gamemanager)
                {
                    Instantiate(shopPrefabs[0], gameObject.transform.position, shopPrefabs[0].transform.rotation);
                    c = c - 1;
                }

                if (c == 0)
                {
                    i = 0;
                }

                break;
            case 2:

                if (c != 0)
                {
                    Instantiate(shopPrefabs[1], gameObject.transform.position, shopPrefabs[1].transform.rotation);
                    c = c - 1;
                }
                if (c == 0)
                {
                    i = 0;
                }
                break;
        }

    }
}
