using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    // move Speed Line
    public float moveSpeed;
    // position of Line (Left or Right)
    public float xDirection;

    // Start is called before the first frame update
    void Start()
    {
        // Set move Speed
        moveSpeed = 12;
    }

    // Update is called once per frame
    void Update()
    {
        //Move Left = -1 or Right = 1
        xDirection = Input.GetAxisRaw("Horizontal");
        //Move on screen
        float moveStep = xDirection * moveSpeed * Time.deltaTime;
        //Line can display on screen where can see
        if ((transform.position.x <= -11 && xDirection == -1) || (transform.position.x >= 11 && xDirection == 1))
            return;
        //Move
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
