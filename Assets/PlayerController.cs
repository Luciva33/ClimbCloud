using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使うために必要

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigit2D;
    Animator animator;
    float jumpForce = 340.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigit2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //ジャンプする
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigit2D.AddForce(transform.up * this.jumpForce);
            // this.rigit2D.AddForce(Vector2.up * this.jumpForce); //ネコちゃんの位置関係なくグローバル空間に力を加える
        }

        //左右移動する
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        //プレイヤーの速度
        float speedx = Mathf.Abs(this.rigit2D.velocity.x);

        //スピード制限
        if (speedx < this.maxWalkSpeed)
        {
            this.rigit2D.AddForce(transform.right * key * this.walkForce);
        }

        //動く方向に応じて反転
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //プレイヤーの速度に応じてアニメーション速度を変える
        this.animator.speed = speedx / 2.0f;

    }
    //ゴールに到達
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("GOAL!!");
        SceneManager.LoadScene("ClearScene");
    }

}
