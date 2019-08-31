using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotation : MonoBehaviour
{
    // Start is called before the first frame update
    Quaternion target;
    public bool hand = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hand) target = Quaternion.Euler(0, -90, -90);
        else target = Quaternion.Euler(0, 90, 90);

        float speed = 10F;
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
}
