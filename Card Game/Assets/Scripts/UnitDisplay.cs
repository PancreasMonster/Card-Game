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

    public Text attackText;
    public Text defenseText;

    public GameObject[] productionCogs;

    void Start()
    {
        nameText.text = unit.name;
        descriptionText.text = unit.description;

        artworkImage.sprite = unit.artwork;

        attackText.text = unit.attack.ToString();
        defenseText.text = unit.defense.ToString();

        for (int i = 0; i < unit.Cost; i++)
        {
            productionCogs[i].SetActive(true);
        }
    }

}
