using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //フレームごとに等速で横移動
        transform.Translate(-0.005f, 0, 0);

        //画面外に出たらオブジェクト破壊
        if (transform.position.x < -5f && transform.position.x > 5f)
        {
            Destroy(gameObject);
        }

    }


}
