using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
    public List<GameObject> cards;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Deck deck;

    public void ShuffleDiscard()
    {
        System.Random rnd = new System.Random();
        Shuffle.ShuffleList(cards, rnd);          //shuffle discard pile
    }
}
