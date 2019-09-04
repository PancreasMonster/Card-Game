using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Cards/Unit")]

public class Unit : ScriptableObject
{
    public new string name;
    [TextArea]
    public string description;

    public Sprite artwork;

    public int Cost;
    public int attack;
    public int defense;
}

[CreateAssetMenu(fileName = "New Action", menuName = "Cards/Action")]
public class Action : ScriptableObject
{
    public new string name;
    [TextArea]
    public string description;

    public Sprite artwork;

    public int Cost;
}

[CreateAssetMenu(fileName = "New Project", menuName = "Cards/Project")]
public class Project : ScriptableObject
{
    public new string name;
    public string objective;
    public string reward;

    public Sprite artwork;

    public int Cost;
}
