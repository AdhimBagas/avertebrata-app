﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    float x, y;
    public GameObject bankhewan;
    public int kontrol;
    // Start is called before the first frame update
    void Start()
    {
        x = transform.localScale.x;
        y = transform.localScale.y;
    }

    void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        transform.localScale = new Vector2(x*1.2f, y/1.2f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector2 (x,y);
        bankhewan.GetComponent<bank_hewan>().control(kontrol);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
