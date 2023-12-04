using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public GameObject player;

    
    void Update()
    {
        // フレームごとに等速で落下させる
        transform.Translate(0, -0.1f, 0);

        // 画面外に出たらオブジェクトを破棄する
        if(transform.position.y < -5.0f){
            Destroy(gameObject);
        }
        
    }

    // 他のオブジェクトのコライダーに当たった時実行
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.name == "player"){

            // 監督スクリプトにプレイヤと衝突した事を伝える
            GameObject director = GameObject.Find("GameDirector01");
            director.GetComponent<GameDirector01>().DecreaseHp();

            // 衝突した場合は矢を消す
            Destroy(gameObject);
        }
    }

}
