using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDisplay : MonoBehaviour
{

    public Unit unit;

    public Text nameText;
    public Text descriptionText;

    public Image artworkImage;

    public Text costText;
    public Text attackText;
    public Text defenseText;


    void Start()
    {
        nameText.text = unit.name;
        descriptionText.text = unit.description;

        artworkImage.sprite = unit.artwork;

        costText.text = unit.Cost.ToString();
        attackText.text = unit.attack.ToString();
        defenseText.text = unit.defense.ToString();
    }

}
