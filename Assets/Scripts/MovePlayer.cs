using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 20.0f;
    public float jump = 1;
    public float gravity = 0.01f;
    public float horizontInput;
    public float verticalInput;
    Vector3 move_Direction;
    CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        horizontInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        if (player.isGrounded)
        {
            move_Direction = new Vector3(horizontInput, 0, verticalInput);
            move_Direction = transform.TransformDirection(move_Direction);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                move_Direction.y += jump;
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                player.height = 1.0f;
            }
            else
            {
                player.height = 1.7f;
            }


        }
        move_Direction.y -= gravity;
        player.Move(move_Direction * speed * Time.deltaTime);
    }

}
