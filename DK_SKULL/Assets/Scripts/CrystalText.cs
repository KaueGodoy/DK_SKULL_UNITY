using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CrystalText : MonoBehaviour
{
    public TextMeshProUGUI crystalText;
    int crystalCount;

    private void OnEnable()
    {
        Crystal.OnCrystalCollected += IncrementCrystalCount;
    }

    private void OnDisable()
    {
        Crystal.OnCrystalCollected -= IncrementCrystalCount;
    }


    public void IncrementCrystalCount()
    {
        crystalCount++;
        crystalText.text = $"Crystals: {crystalCount}";
    }
}
