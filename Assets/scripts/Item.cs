using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
  public enum ItemType
    {
        Semeno,
        Psecica,
    }

    public ItemType itemType;
    public int amount;
}
