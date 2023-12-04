using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        
    }

    public void LButtonDown(){
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown(){
        transform.Translate(3, 0, 0);
    }

    void Update()
    {



        // 左矢印が押されたとき
        if(Input.GetKeyDown(KeyCode.LeftArrow))LButtonDown();  // 1行の時は｛｝を省略できる

        // 右矢印が押されたとき
        if(Input.GetKeyDown(KeyCode.RightArrow))RButtonDown();

        // 上矢印が押されたとき
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.Translate(0, 3, 0);  // 上に３動かす
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.Translate(0, -3, 0);  // 下に３動かす
        }

        // if(Input.GetKey(KeyCode.LetfArrow)){
        //     transform.Translate(-3*Time.deltaTime, 0, 0);
        // }
        
    }
}
