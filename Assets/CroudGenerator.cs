using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CroudGenerator : MonoBehaviour
{
    public GameObject prefab;
    class Cloud
    {
        public Vector3 pos;
        public Vector3 localScale;
        public Cloud(Vector3 pos, Vector3 localScale)
        {
            this.pos = pos;
            this.localScale = localScale;
        }
    }
    List<Cloud> cloudList = new List<Cloud>();

    float span = 1.0f;
    float delta = 0;


    // Start is called before the first frame update
    void Start()
    {
        cloudList.Add(new Cloud(new Vector3(-1.1f, 15.5f, 0f), new Vector3(0.6f, 1, 1)));
        // cloudList.Add(new Cloud(new Vector3(1f, 16.6f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-1.6f, 13.0f, 0f), new Vector3(0.7f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(1.4f, 13.2f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-1f, 11f, 0f), new Vector3(0.8f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(1.1f, 9f, 0f), new Vector3(0.9f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-1.6f, 7.7f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(1.6f, 6.4f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-0.1f, 4.2f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(1.4f, 2.5f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-1.6f, 1.8f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-0.2f, -0.7f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(1.6f, -2.1f, 0f), new Vector3(1f, 1f, 1f)));
        cloudList.Add(new Cloud(new Vector3(-1.6f, -2.8f, 0f), new Vector3(1f, 1f, 1f)));
        // cloudList.Add(new Cloud(new Vector3(-1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)));
        // cloudList.Add(new Cloud(new Vector3(0f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)));
        // cloudList.Add(new Cloud(new Vector3(1.55f, -5.1f, 0f), new Vector3(1.1f, 1f, 1f)));

        for (int i = 0; i < cloudList.Count; i++)
        {

            GameObject go = Instantiate(prefab);
            go.transform.position = cloudList[i].pos;
            go.transform.localScale = cloudList[i].localScale;
        }
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(prefab);
            int px = Random.Range(-3, 20);
            go.transform.position = new Vector3(4, px, 0);
        }
    }

}