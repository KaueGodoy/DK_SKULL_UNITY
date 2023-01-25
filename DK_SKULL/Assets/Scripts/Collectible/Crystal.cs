using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour, ICollectible
{
    public static event Action OnCrystalCollected;

    public void Collect()
    {
        Debug.Log("Crystal collected");
        Destroy(gameObject);
        OnCrystalCollected?.Invoke();
    }

  
}
