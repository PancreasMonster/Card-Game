using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    // Start is called before the first frame update
    public DiscardPile discardPile;
    public Deck deck;
    public Hand hand;

    void Start()
    {
        discardPile = FindObjectOfType<DiscardPile>();
        deck = FindObjectOfType<Deck>();
        hand = FindObjectOfType<Hand>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
