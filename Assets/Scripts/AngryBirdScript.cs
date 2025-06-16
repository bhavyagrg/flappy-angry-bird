using UnityEngine;

public class AngryBirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.linearVelocity = Vector2.up * 3;
        
    }
}
