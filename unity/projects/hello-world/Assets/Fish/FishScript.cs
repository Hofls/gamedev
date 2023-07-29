using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public Rigidbody2D body;
    public float jumpHeight = 5;
    public ScoreScript scoreScript;
    public bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            body.velocity = Vector2.up * jumpHeight;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreScript.gameOver();
        isAlive = false;
    }

}
