﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{

    public float speed;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
