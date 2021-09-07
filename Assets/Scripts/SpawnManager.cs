using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject[] enemyOnMap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnSpaceShip();   
    }
    void spawnSpaceShip()
    {
        enemyOnMap = GameObject.FindGameObjectsWithTag("SpaceShip");

        if (enemyOnMap.Length <= 0 && enemyOnMap.Length >= 0)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], gameObject.transform.position, enemyPrefabs[enemyIndex].transform.rotation);
        } 
    }
}
