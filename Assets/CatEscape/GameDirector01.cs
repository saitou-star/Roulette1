using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UIを使うので忘れずに追加

public class GameDirector01 : MonoBehaviour
{
    GameObject hpGauge;
    float time;
    public Text timeText;
    public GameObject gameOverText;

    // Image hpImage;　　追加
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");

        // GameOverテキストを非表示
        gameOverText.SetActive(false);

        // hpImage = hpGauge.GetComponent<Image>()　　追加
;    }


    void Update(){
        time += Time.deltaTime;
        timeText.text = $"Time:{time:F2}";
    }


    public void DecreaseHp()
    {
        // HPゲージを減らして、HPが０以下になったらGameOverテキストを表示
        Image hpImage = this.hpGauge.GetComponent<Image>();
        hpImage.fillAmount -= 0.1f;
        if(hpImage.fillAmount <= 0.0f){
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }


        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        // this.hpImage.fillAmount -= 0.1f;   書き換え、上と入れ替え
    }
}
