using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private DateTime startTime;
    private TextMeshProUGUI text;
    private DateTime curTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = DateTime.Now;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        curTime = System.DateTime.Now;
        text.text = "hello";
    }
}
