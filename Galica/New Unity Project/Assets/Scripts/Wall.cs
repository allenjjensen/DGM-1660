﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {


    private void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.GetComponent<Health>().IncrementHealth(-1);

    }



}