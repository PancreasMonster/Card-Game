using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    public List<GameObject> discardPile;
//    private static CardManager cardManager;
    // Start is called before the first frame update
    void Start()
    {
//           cardManager = FindObjectOfType<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Deck deck;

    public void ShuffleDiscardIntoDeck()
    {
        System.Random rnd = new System.Random();
        Shuffle.ShuffleList(discardPile, rnd);          //shuffle discard pile
        deck.DrawDiscard();

    }
}
