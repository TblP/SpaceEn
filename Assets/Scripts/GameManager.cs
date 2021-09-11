using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public MovePlayer mp;
    public MouseLook ml;
    public SpaceShipMove sh;
    public Image shop;
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
        if (shop.gameObject.activeSelf == true)
        {
            
            mp.speed = 0f;
            ml.sensitivity = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        { 
            mp.speed = 10f;
            ml.sensitivity = 5f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        status();
        if (Status1.text.Length == 4 && Status2.text.Length == 4 && Status3.text.Length == 4 && Status4.text.Length == 4 && Status5.text.Length == 4)
        {
            sh.repair = true;
        }
    }
    public void exit()
    {
        shop.gameObject.SetActive(false);
    }
    public void status()
    {   
        if (sh.check == true && Status1.text.Length == 0)
        {
            Status1.text = UnityEngine.Random.Range(0, 100) + "%";
            Status2.text = UnityEngine.Random.Range(0, 100) + "%";
            Status3.text = UnityEngine.Random.Range(0, 100) + "%";
            Status4.text = UnityEngine.Random.Range(0, 100) + "%";
            Status5.text = UnityEngine.Random.Range(0, 100) + "%";
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
        }
        if (sh.check == true && StatusR1.text.Length == 0)
        {
            if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 75)
            {
                StatusR1.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 75 && int.Parse(Status1.text.Substring(0, Status1.text.Length - 1)) >= 40)
            {
                StatusR1.text = UnityEngine.Random.Range(40, 100) + "%";

            } else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 40 && Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 1)
            {
                StatusR1.text = UnityEngine.Random.Range(1, 40) + "%";
            } else if (Convert.ToInt32(Status1.text.Substring(0,Status1.text.Length-1)) == 0)
            {
                StatusR1.text = "0%";
            }
            //-----------------------------------------------------------------------
            if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 75)
            {
                StatusR2.text = UnityEngine.Random.Range(60, 100) + "%";
            }
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 75 && int.Parse(Status2.text.Substring(0, Status2.text.Length - 1)) >= 40)
            {
                StatusR2.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 40 && Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 1)
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
            else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 75 && int.Parse(Status3.text.Substring(0, Status3.text.Length - 1)) >= 40)
            {
                StatusR3.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 40 && Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 1)
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
            else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 75 && int.Parse(Status4.text.Substring(0, Status4.text.Length - 1)) >= 40)
            {
                StatusR4.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 40 && Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
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
            else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 75 && int.Parse(Status5.text.Substring(0, Status5.text.Length - 1)) >= 40)
            {
                StatusR5.text = UnityEngine.Random.Range(40, 100) + "%";

            }
            else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 40 && Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
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
        
        if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 75 && Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) <= 99)
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
        else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 75 && int.Parse(Status1.text.Substring(0, Status1.text.Length - 1)) >= 50)
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
        else if (Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) < 50 && Convert.ToInt32(Status1.text.Substring(0, Status1.text.Length - 1)) >= 1)
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
        Debug.Log(ch);
    }
    public void repair2()
    {
        int ch = -1;
            if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >= 75 && Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) <= 99)
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
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 75 && int.Parse(Status2.text.Substring(0, Status2.text.Length - 1)) >= 50)
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
            else if (Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) < 50 && Convert.ToInt32(Status2.text.Substring(0, Status2.text.Length - 1)) >=1)
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
        if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 75 && Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) <= 99)
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
        else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 75 && int.Parse(Status3.text.Substring(0, Status3.text.Length - 1)) >= 50)
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
        else if (Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) < 50 && Convert.ToInt32(Status3.text.Substring(0, Status3.text.Length - 1)) >= 1)
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
        if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 75 && Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) <= 99)
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
        else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 75 && int.Parse(Status4.text.Substring(0, Status4.text.Length - 1)) >= 50)
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
        else if (Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) < 50 && Convert.ToInt32(Status4.text.Substring(0, Status4.text.Length - 1)) >= 1)
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
        if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) >= 75 && Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) <= 99)
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
        else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 75 && int.Parse(Status5.text.Substring(0, Status5.text.Length - 1)) >= 50)
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
        else if (Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) < 50 && Convert.ToInt32(Status5.text.Substring(0, Status5.text.Length - 1)) >= 1)
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
}
