using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour
{
    public float speed = 10.0f;
    public bool check = false;
    public bool repair = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
        Move();
    }
    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //остановка
        if (check == true)
        {
            if (speed > 0)
            {
                speed -= 0.06f;
            }
        }
        
        if (speed < 0f)
        {
            speed = 0;
        }
        //старт после починки
        if (repair == true)
        {
           check = false;
           speed += 0.05f;
        }
    }
    void Destroy()
    {
        if (gameObject.transform.position.x >= 70)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.CompareTag("Barrier"))
        {
            check = true;
        }
    }
}
