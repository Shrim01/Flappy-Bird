using System.Collections;
using System.Collections.Generic;
using Date;
using UnityEngine;

public class spri : MonoBehaviour
{
    void Start()
    {
        if (GameData.background!=null)
            gameObject
            .GetComponent<SpriteRenderer>()
            .sprite=GameData.background;
    }
}