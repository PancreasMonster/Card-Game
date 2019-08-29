using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    public int handSize;
    public int currenthandSize;

    // Start is called before the first frame update
    void Start()
    {
        handSize = 4;
        DrawHand();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DrawHand()
    {
        if (currenthandSize < handSize)
        {
            currenthandSize++;
        }
    }
}
