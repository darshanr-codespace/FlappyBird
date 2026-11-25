using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D myRigidBody2d;
    public LogicScript logic;
    public float flyStrength = 10;

    public bool isBirdAlive = true;
    void Start()
    {
        gameObject.name = "Sparrow";
        gameObject.tag = "Player";
        if (logic == null)
        {
            logic = FindAnyObjectByType<LogicScript>();

            if (logic == null)
                logic = new GameObject("Logic").AddComponent<LogicScript>();
        }
    }

    // Update is called once per frame 
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isBirdAlive)
            myRigidBody2d.linearVelocity = Vector2.up * flyStrength;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isBirdAlive)
            return;

        isBirdAlive = false;
        logic.GameOver();
    }
}
