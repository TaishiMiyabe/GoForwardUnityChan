using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

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

        if (collision.gameObject.tag != "UnityChan")
        {
            Debug.Log("aaa");
            GetComponent<AudioSource>().Play(); // GetComponent<AudioSource>().volume = 1; じゃダメだったのはなぜ？
        }
    }
}
