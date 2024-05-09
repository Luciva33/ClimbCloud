using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class CameraController : MonoBehaviour
// {
//     GameObject player;

//     void Start()
//     {
//         this.player = GameObject.Find("cat");
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         Vector3 playerPos = this.player.transform.position;

//         transform.position = new Vector3(
//             transform.position.x, playerPos.y, transform.position.z
//         );

//     }
// }

public class CameraController : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //this.player = GameObject.Find("cat");

    }

    // Update is called once per frame
    // void LateUpdate()
    // {
    //     Vector3 playerPos = this.player.position;
    //     transform.position = new Vector3(
    //         transform.position.x,
    //         playerPos.y,
    //         transform.position.z
    //     );

    // } 

    void LateUpdate()
    {
        Vector3 playerPos = this.player.position;
        /*
        transform.position = new Vector3(
            transform.position.x,
            playerPos.y,
            transform.position.z
        );
        */
        Vector3 targetPos = new Vector3(
            transform.position.x,
            playerPos.y,
            transform.position.z
        );
        transform.position = Vector3.Lerp(
            transform.position,
            targetPos,
            0.02f);


    }
}

