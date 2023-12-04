using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;   // [SerializeField]  もしくは public
    public GameObject flag;
    public GameObject distance;    

    void Start()
    {
        // this.car = GameObject.Find("car");
        // this.flag = GameObject.Find("flag");
        // this.distance = GameObject.Find("distance");

        
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "Distance:" + length.ToString("F2") + "m";
    }
}
