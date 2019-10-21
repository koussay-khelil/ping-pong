using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public  float speed = 30; 
    public string axe; 



    // Update is called once per frame
    void FixedUpdate()
    {
        float axis = Input.GetAxisRaw(axe) * speed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, axis);
    }
}
