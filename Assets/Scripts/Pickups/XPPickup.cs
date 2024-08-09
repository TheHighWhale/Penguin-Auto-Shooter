using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class XPPickup : MonoBehaviour
{
    public int xpValue;

    public abstract void Pickup(Player player);
}
