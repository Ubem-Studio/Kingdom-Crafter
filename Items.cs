using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public enum ItemType {
        Food,
        Wood,
        Leather,
        Stone,
        Iron,
        Oil,
    }

    public ItemType itemType;
    public int amount;
    public bool isStackable;

    
}
