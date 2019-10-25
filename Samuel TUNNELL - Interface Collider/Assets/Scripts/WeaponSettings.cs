using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSettings : MonoBehaviour
{
    [Header("Weapon Settings")]
	//How fast the weapon fires, higher value means faster rate of fire
	[Tooltip("How fast the weapon fires, higher value means faster rate of fire.")]
    
    public int bulletType;
    public float fireRate = 5f;
	public float bulletForce = 400f;

public void typeUpdate()
{
    if(bulletType == 0)
    {
        fireRate = 11f;
        bulletForce = 250f;
    }
    if(bulletType == 1)
    {
        fireRate = 5f;
        bulletForce = 400f;
    }
}

}
