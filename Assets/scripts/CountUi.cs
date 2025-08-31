using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//ref https://youtu.be/EfUCEwKmcjc?si=czW5ScdVvdd35KNU

public class CountUi : MonoBehaviour
{
    private TextMeshProUGUI GemText;

    void Start()
    {
        GemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateGemText(PlayerInventory Inventory)
    {
        GemText.text = Inventory.Gems.ToString();
    }
}

