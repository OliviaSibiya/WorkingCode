using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Sword sword;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(sword.swordName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
