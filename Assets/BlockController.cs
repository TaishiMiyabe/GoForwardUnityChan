using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    //一回音を鳴らしたオブジェクトはもう音が鳴らないようにする(オブジェクト同士の衝突で2重に音が鳴らないように)
    private bool wasSounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //GetComponent<AudioSource>().volume = 0;

        if (transform.position.y < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag != "UnityChan" && !wasSounded)
        {
            GetComponent<AudioSource>().Play();
            wasSounded = true;
        }
    }
}
