using System;
using System.Net.Http.Headers;
using UnityEngine;

public class MiddlePipeScript : MonoBehaviour
{
    public LogicScript logic;
    private bool scored;

    void Start()
    {
        if (logic == null)
        {
            logic = FindAnyObjectByType<LogicScript>();

            if (logic == null)
                logic = new GameObject("Logic").AddComponent<LogicScript>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (scored || logic == null)
            return;

        Rigidbody2D birdBody = collision.GetComponentInParent<Rigidbody2D>();
        if (birdBody != null && collision.GetComponentInParent<BirdScript>() != null)
        {
            scored = true;
            logic.AddScore();
        }
    }
}
