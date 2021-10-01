using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public MovePlayer mp;
    public MouseLook ml;
    public SpaceShipMove sh;
    public ShopSpawn ss;
    public Image shop;
    public Image shop2;
    public Image crosshair;

    public Text Status1;
    public Text Status2;
    public Text Status3;
    public Text Status4;
    public Text Status5;

    public Text StatusR1;
    public Text StatusR2;
    public Text StatusR3;
    public Text StatusR4;
    public Text StatusR5;

    public Text StatusA1;
    public Text StatusA2;
    public Text StatusA3;
    public Text StatusA4;
    public Text StatusA5;

    public Text kolvo1;
    public Text kolvo2;
    
    float equip = 0f;
    int statuspos = 1;
    private float k;
    private float k2;
    private float k3;
    private float k4;
    private float k5;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        sh = GameObject.FindGameObjectWithTag("SpaceShip").GetComponent<SpaceShipMove>();
        if (shop.gameObject.activeSelf == true || shop2.gameObject.activeSelf == true)
        {

            mp.speed = 0f;
            ml.sensitivity = 0f;
            Cursor.visible = true;
            crosshair.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            mp.speed = 10f;
            ml.sensitivity = 5f;
            Cursor.visible = false;
            crosshair.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
        }

        status();
        if (Status1.text.Length > 0)
        {
            repairamount();
        }
        if (Status1.text.Length == 4 && Status2.text.Length == 4 && Status3.text.Length == 4 &&
            Status4.text.Length == 4 && Status5.text.Length == 4)
        {
            sh.repair = true;
        }
    }

    public void exit()
    {
        shop.gameObject.SetActive(false);
        shop2.gameObject.SetActive(false);
        kolvo1.text = "0";
        kolvo2.text = "0";
        crosshair.gameObject.SetActive(true);
    }
    public void status()
    {
        if (sh.check == true && Status1.text.Length == 0)
        {
            k = UnityEngine.Random.Range(0,2);
            if (k == 0)
            {
                k = 1.5f;
            }
            if (k == 1)
            {
                k = 1;
            }
            k2 = UnityEngine.Random.Range(0,2);
            if (k2 == 0)
            {
                k2 = 1.5f;
            }
            if (k2 == 1)
            {
                k2 = 1;
            }
            k3 = UnityEngine.Random.Range(0,2);
            if (k3 == 0)
            {
                k3 = 1.5f;
            }
            if (k3 == 1)
            {
                k3 = 1;
            }
            k4 = UnityEngine.Random.Range(0,2);
            if (k4 == 0)
            {
                k4 = 1.5f;
            }
            if (k4 == 1)
            {
                k4 = 1;
            }
            k5 = UnityEngine.Random.Range(0,2);
            if (k5 == 0)
            {
                k5 = 1.5f;
            }
            if (k5 == 1)
            {
                k5 = 1;
            }
            
            Status1.text = UnityEngine.Random.Range(0, 100) + "%";
            Status2.text = UnityEngine.Random.Range(0, 100) + "%";
            Status3.text = UnityEngine.Random.Range(0, 100) + "%";
            Status4.text = UnityEngine.Random.Range(0, 100) + "%";
            Status5.text = UnityEngine.Random.Range(0, 100) + "%";
            StatusA1.text = equip + "/" + k;
            StatusA2.text = equip + "/" + k2;
            StatusA3.text = equip + "/" + k3;
            StatusA4.text = equip + "/" + k4;
            StatusA5.text = equip + "/" + k5;
        }

        if (sh.repair == true)
        {
            Status1.text = "";
            Status2.text = "";
            Status3.text = "";
            Status4.text = "";
            Status5.text = "";
            StatusR1.text = "";
            StatusR2.text = "";
            StatusR3.text = "";
            StatusR4.text = "";
            StatusR5.text = "";
            StatusA1.text = equip + "/" + k;
            StatusA2.text = equip + "/" + k2;
            StatusA3.text = equip + "/" + k3;
            StatusA4.text = equip + "/" + k4;
            StatusA5.text = equip + "/" + k5;
            statuspos = 1;
        }

        if (sh.check == true && StatusR1.text.Length == 0)
        {
            if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 75)
            {
                StatusR1.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 75 &&
                     int.Parse(Status1.text.Substring(0, Status1.text.Length - 1)) >= 40)
            {
                StatusR1.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 40 &&
                     Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 1)
            {
                StatusR1.text = UnityEngine.Random.Range(1, 40) + "%";
            }
            else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) == 0)
            {
                StatusR1.text = "0%";
            }

            //-----------------------------------------------------------------------
            if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 75)
            {
                StatusR2.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 75 &&
                     int.Parse(Status2.text.Substring(0, Status2.text.Length - 1)) >= 40)
            {
                StatusR2.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 40 &&
                     Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 1)
            {
                StatusR2.text = UnityEngine.Random.Range(1, 40) + "%";
            }
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) == 0)
            {
                StatusR2.text = "0%";
            }

            //-----------------------------------------------------------------------
            if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 75)
            {
                StatusR3.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 75 &&
                     int.Parse(Status3.text.Substring(0, Status3.text.Length - 1)) >= 40)
            {
                StatusR3.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 40 &&
                     Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 1)
            {
                StatusR3.text = UnityEngine.Random.Range(1, 40) + "%";
            }
            else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) == 0)
            {
                StatusR3.text = "0%";
            }

            //-----------------------------------------------------------------------
            if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 75)
            {
                StatusR4.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 75 &&
                     int.Parse(Status4.text.Substring(0, Status4.text.Length - 1)) >= 40)
            {
                StatusR4.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 40 &&
                     Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
            {
                StatusR4.text = UnityEngine.Random.Range(0, 40) + "%";
            }
            else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) == 0)
            {
                StatusR4.text = "0%";
            }

            //-----------------------------------------------------------------------
            if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) >= 75)
            {
                StatusR5.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 75 &&
                     int.Parse(Status5.text.Substring(0, Status5.text.Length - 1)) >= 40)
            {
                StatusR5.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 40 &&
                     Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
            {
                StatusR5.text = UnityEngine.Random.Range(0, 40) + "%";
            }
            else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) == 0)
            {
                StatusR5.text = "0%";
            }
        }
    }

    public void repair()
    {
        int ch = -1;

        if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 75 &&
            Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) <= 99)
        {

            ch = UnityEngine.Random.Range(1, 3);
            switch (ch)
            {
                case 1:
                    Status1.text = "100%";
                    break;

                case 2:
                    Status1.text = "100%";
                    break;

                case 3:
                    Status1.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 75 &&
                 int.Parse(Status1.text.Substring(0, Status1.text.Length - 1)) >= 50)
        {
            ch = UnityEngine.Random.Range(1, 2);
            switch (ch)
            {
                case 1:
                    Status1.text = "100%";
                    break;

                case 2:
                    Status1.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 50 &&
                 Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 1)
        {
            ch = UnityEngine.Random.Range(1, 5);
            switch (ch)
            {
                case 1:
                    Status1.text = "100%";
                    break;

                case 2:
                    Status1.text = "0%";
                    break;

                case 3:
                    Status1.text = "0%";
                    break;
                case 4:
                    Status1.text = "0%";
                    break;
                case 5:
                    Status1.text = "0%";
                    break;
            }
        }

    }

    public void repair2()
    {
        int ch = -1;
        if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 75 &&
            Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) <= 99)
        {

            ch = UnityEngine.Random.Range(1, 3);
            switch (ch)
            {
                case 1:
                    Status2.text = "100%";
                    break;

                case 2:
                    Status2.text = "100%";
                    break;

                case 3:
                    Status2.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 75 &&
                 int.Parse(Status2.text.Substring(0, Status2.text.Length - 1)) >= 50)
        {
            ch = UnityEngine.Random.Range(1, 2);
            switch (ch)
            {
                case 1:
                    Status2.text = "100%";
                    break;

                case 2:
                    Status2.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 50 &&
                 Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 1)
        {
            ch = UnityEngine.Random.Range(1, 5);
            switch (ch)
            {
                case 1:
                    Status2.text = "100%";
                    break;

                case 2:
                    Status2.text = "0%";
                    break;

                case 3:
                    Status2.text = "0%";
                    break;
                case 4:
                    Status2.text = "0%";
                    break;
                case 5:
                    Status2.text = "0%";
                    break;
            }
        }
    }

    public void repair3()
    {
        int ch = -1;
        if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 75 &&
            Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) <= 99)
        {

            ch = UnityEngine.Random.Range(1, 3);
            switch (ch)
            {
                case 1:
                    Status3.text = "100%";
                    break;

                case 2:
                    Status3.text = "100%";
                    break;

                case 3:
                    Status3.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 75 &&
                 int.Parse(Status3.text.Substring(0, Status3.text.Length - 1)) >= 50)
        {
            ch = UnityEngine.Random.Range(1, 2);
            switch (ch)
            {
                case 1:
                    Status3.text = "100%";
                    break;

                case 2:
                    Status3.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 50 &&
                 Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 1)
        {
            ch = UnityEngine.Random.Range(1, 5);
            switch (ch)
            {
                case 1:
                    Status3.text = "100%";
                    break;

                case 2:
                    Status3.text = "0%";
                    break;

                case 3:
                    Status3.text = "0%";
                    break;
                case 4:
                    Status3.text = "0%";
                    break;
                case 5:
                    Status3.text = "0%";
                    break;
            }
        }
    }

    public void repair4()
    {
        int ch = -1;
        if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 75 &&
            Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) <= 99)
        {

            ch = UnityEngine.Random.Range(1, 3);
            switch (ch)
            {
                case 1:
                    Status4.text = "100%";
                    break;

                case 2:
                    Status4.text = "100%";
                    break;

                case 3:
                    Status4.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 75 &&
                 int.Parse(Status4.text.Substring(0, Status4.text.Length - 1)) >= 50)
        {
            ch = UnityEngine.Random.Range(1, 2);
            switch (ch)
            {
                case 1:
                    Status4.text = "100%";
                    break;

                case 2:
                    Status4.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 50 &&
                 Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
        {
            ch = UnityEngine.Random.Range(1, 5);
            switch (ch)
            {
                case 1:
                    Status4.text = "100%";
                    break;

                case 2:
                    Status4.text = "0%";
                    break;

                case 3:
                    Status4.text = "0%";
                    break;
                case 4:
                    Status4.text = "0%";
                    break;
                case 5:
                    Status4.text = "0%";
                    break;
            }
        }
    }

    public void repair5()
    {
        int ch = -1;
        if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) >= 75 &&
            Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) <= 99)
        {

            ch = UnityEngine.Random.Range(1, 3);
            switch (ch)
            {
                case 1:
                    Status5.text = "100%";
                    break;

                case 2:
                    Status5.text = "100%";
                    break;

                case 3:
                    Status5.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 75 &&
                 int.Parse(Status5.text.Substring(0, Status5.text.Length - 1)) >= 50)
        {
            ch = UnityEngine.Random.Range(1, 2);
            switch (ch)
            {
                case 1:
                    Status5.text = "100%";
                    break;

                case 2:
                    Status5.text = "0%";
                    break;
            }

        }
        else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 50 &&
                 Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) >= 1)
        {
            ch = UnityEngine.Random.Range(1, 5);
            switch (ch)
            {
                case 1:
                    Status5.text = "100%";
                    break;

                case 2:
                    Status5.text = "0%";
                    break;

                case 3:
                    Status5.text = "0%";
                    break;
                case 4:
                    Status5.text = "0%";
                    break;
                case 5:
                    Status5.text = "0%";
                    break;
            }
        }
    }

    public void plus()
    {
        int i = Convert.ToInt32(kolvo1.text);
        if (i <= 9)
        {
            i += 1;
        }

        kolvo1.text = i + "";
    }

    public void minus()
    {
        int i = Convert.ToInt32(kolvo1.text);
        i -= 1;
        if (i < 0)
        {
            i = 0;
        }

        kolvo1.text = i + "";
    }

    public void plus1()
    {
        int i = Convert.ToInt32(kolvo2.text);
        if (i <= 9)
        {
            i += 1;
        }

        kolvo2.text = i + "";
    }

    public void minus1()
    {
        int i = Convert.ToInt32(kolvo2.text);
        i -= 1;
        if (i < 0)
        {
            i = 0;
        }

        kolvo2.text = i + "";
    }


    public void click1()
    {
        ss.c = Convert.ToInt32(kolvo1.text);
        ss.i = 1;

    }

    public void click2()
    {
        ss.c = Convert.ToInt32(kolvo2.text);
        ss.i = 2;
    }
    private RepairMagic rm;
    public void repairamount()
    {
        rm = sh.GetComponent<RepairMagic>();
        
        //сколько деталей нужно для починки
        
        
        //распределение статуса деталей 
        
        float big = 1f;
        float low = 0.5f;

        switch (statuspos)
        {

            case 1:
                if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 100)
                {
                    if (rm.littled == true)
                    {
                        equip = equip + low;
                        StatusA1.text = equip + "/" + k;
                        rm.littled = false;
                    }

                    if (rm.bigd == true)
                    {
                        equip = equip + big;
                        StatusA1.text = equip + "/" + k;
                        rm.bigd = false;
                    }

                    if (equip >= k)
                    {
                        equip = 0;
                        statuspos = 2;
                    }
                }
                else
                {
                    equip = 0;
                    statuspos = 2;
                }
                break;
            case 2:
                if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 100)
                {
                    if (rm.littled == true)
                    {
                        equip = equip + low;
                        StatusA2.text = equip + "/" + k2;
                        rm.littled = false;
                    }

                    if (rm.bigd == true)
                    {
                        equip = equip + big;
                        StatusA2.text = equip + "/" + k2;
                        rm.bigd = false;
                    }

                    if (equip >= k)
                    {
                        equip = 0;
                        statuspos = 3;
                    }
                }
                else
                {
                    equip = 0;
                    statuspos = 3;
                }
                break;
            case 3:
                if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 100)
                {
                    if (rm.littled == true)
                    {
                        equip = equip + low;
                        StatusA3.text = equip + "/" + k3;
                        rm.littled = false;
                    }

                    if (rm.bigd == true)
                    {
                        equip = equip + big;
                        StatusA3.text = equip + "/" + k3;
                        rm.bigd = false;
                    }

                    if (equip >= k)
                    {
                        equip = 0;
                        statuspos = 4;
                    }
                }
                else
                {
                    equip = 0;
                    statuspos = 4;
                }
                break;
            case 4:
                if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 100)
                {
                    if (rm.littled == true)
                    {
                        equip = equip + low;
                        StatusA4.text = equip + "/" + k3;
                        rm.littled = false;
                    }

                    if (rm.bigd == true)
                    {
                        equip = equip + big;
                        StatusA4.text = equip + "/" + k3;
                        rm.bigd = false;
                    }

                    if (equip >= k)
                    {
                        equip = 0;
                        statuspos = 5;
                    }
                }
                else
                {
                    equip = 0;
                    statuspos = 5;
                }
                break;
            case 5:
                if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 100)
                {
                    if (rm.littled == true)
                    {
                        equip = equip + low;
                        StatusA5.text = equip + "/" + k3;
                        rm.littled = false;
                    }

                    if (rm.bigd == true)
                    {
                        equip = equip + big;
                        StatusA5.text = equip + "/" + k3;
                        rm.bigd = false;
                    }

                    if (equip >= k)
                    {
                        equip = 0;
                        statuspos = 0;
                    }
                }
                else
                {
                    equip = 0;
                    statuspos = 0;
                }
                break;
            
        }
    }

    public void repairbtn1()
    {
        if (statuspos >= 1||statuspos == 0)
        {
            
            Status1.text = 100 + "%";
        }
    }
    public void repairbtn2()
    {
        
        if (statuspos >= 2 || statuspos == 0 )
        {
            
            Status2.text = 100 + "%";
        }
    }
    public void repairbtn3()
    {
        
        if (statuspos >= 3||statuspos == 0)
        {
            
            Status3.text = 100 + "%";
        }
    }
    public void repairbtn4()
    {
        
        if (statuspos >= 4||statuspos == 0)
        {
            
            Status4.text = 100 + "%";
        }
    }
    public void repairbtn5()
    {
        Debug.Log(statuspos);
        if (statuspos == 0 || statuspos >= 5)
        {
            Debug.Log(statuspos);
            Status5.text = 100 + "%";
        }
    }
}
