using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string Name;
    public int Cost;
    public string Type;

    public string Ability;
    public int attack;
    public int defense;

    public string cardText;
    public string flavorText;

    public Vector3 current;
    public Vector3 target;
    public float speed = 10.0f;
    public bool moving = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        current = transform.position;
        if (moving == true)
        {
            print("moving...");
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
        if (current == transform.position)
        {
            print("Stopped Moving");
            moving = false;
        }
    }
}
