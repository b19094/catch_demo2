using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public GameObject Tree;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        // ツリーを元にオブジェクトを生成する
        GameObject obj = Instantiate(Tree, Tree.transform.position + new Vector3(0.0f, 0.0f, -10.0f), Tree.transform.rotation);

        Canvas.SetActive(false);
    }
}
