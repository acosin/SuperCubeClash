﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArrowDownClick : MonoBehaviour, IPointerClickHandler
{

    private GameManager gm;
    public void OnPointerClick(PointerEventData eventData)
    {
        gm.rotateBlocks("south");
    }

    // Use this for initialization
    void Start()
    {

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

}
