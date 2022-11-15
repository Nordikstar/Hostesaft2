 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{

    private float move, movespeed, rotation, rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 5f;
        rotationSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;

    }


    private void LateUpdate()
    {
        transform.Translate(0f, move, 0f);
            transform.Rotate(0f, 0f, rotation);
    }

}