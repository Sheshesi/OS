using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleController : MonoBehaviour
{
    public Text pointFP;
    public Text pointSP;

    public int pFP = 0;
    public int pSP = 0;

    public static CircleController Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

}
