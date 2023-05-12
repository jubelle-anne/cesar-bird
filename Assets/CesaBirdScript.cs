using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CesaBirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapVelocity;
    public LogicManager logic;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdAlive) {
            myRigidbody.velocity = Vector2.up * flapVelocity; // flap cesar!!
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
