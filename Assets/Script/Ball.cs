using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum BallColors
{
    White, Red , Yellow , Green , Brown, blue , Pink ,black
}



public class Ball : MonoBehaviour
{

    [SerializeField] private int point;

    public int Point
    {
        get { return point; }
    }

    [SerializeField] private BallColors ballColors;

    [SerializeField] private MeshRenderer rd;

    private void Awake()
    {
        rd = GetComponent<MeshRenderer>();
    }

    public void SetColorAndPoint(BallColors color)
    {
        switch (color)
        {
            case BallColors.White:
                point = 0;
                rd.material.color = Color.white;
                break;
            case BallColors.Red:
                point = 1;
                rd.material.color = Color.red;
                break;
            case BallColors.Yellow:
                point = 0;
                rd.material.color = Color.yellow;
                break;
            case BallColors.Green:
                point = 0;
                rd.material.color = Color.green;
                break;
            case BallColors.Brown:
                point = 0;
                rd.material.color = new Color(91, 42, 6, 255);
                break;
            case BallColors.blue:
                point = 0;
                rd.material.color = Color.blue;
                break;
            case BallColors.Pink:
                point = 0;
                rd.material.color = Color.magenta;
                break;
            case BallColors.black:
                point = 0;
                rd.material.color = Color.black;
                break;
        }
    }
}


