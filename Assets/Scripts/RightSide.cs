﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player1")
        {
            other.gameObject.transform.position = new Vector3(-2.7f, other.gameObject.transform.position.y, -.5f);
        }
    }
}
