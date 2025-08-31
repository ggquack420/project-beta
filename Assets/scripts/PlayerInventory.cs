using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//ref = https://youtu.be/EfUCEwKmcjc?si=czW5ScdVvdd35KNU
public class PlayerInventory : MonoBehaviour
{
    public int Gems { get; private set; }

    public UnityEvent<PlayerInventory> Ongemcollected;

    public void GemCollected()
    {
        Gems++;
        Ongemcollected?.Invoke(this);

    }
}



