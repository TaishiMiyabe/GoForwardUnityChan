using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;

    //時間計測用の変数
    private float delta = 0;
    //キューブの生成間隔
    private float span = 1.5f;
    //キューブの生成位置(X座標)
    private float genPosX = 12;
    //キューブ生成位置のオフセット
    private float offsetY = 0.3f;
    //キューブの縦方向の間隔
    private float spaceY = 6.9f;
    //キューブの生成位置のオフセット
    private float offsetX = 0.5f;
    //キューブの横方向の間隔
    private float spaceX = 0.4f;

    //キューブの生成個数の上限
    private int maxBlockNum = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Canvas").GetComponent<UIController>().isGameOver)//ゲームオーバーでないなら、キューブを生成する。
        {
            this.delta += Time.deltaTime;

            if (this.delta > this.span)
            {
                this.delta = 0;

                //生成するブロック数をランダムで
                int n = Random.Range(1, maxBlockNum + 1);

                for (int i = 0; i < n; i++)
                {
                    GameObject go = Instantiate(cubePrefab) as GameObject;//as の役割。なくても動く
                    go.transform.position = new Vector2(this.genPosX, this.offsetY + i * this.spaceY);
                }
            }
        }
    }
}
