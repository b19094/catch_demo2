using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryTree : MonoBehaviour
{
    LineRenderer linerend;

    public GameObject master;
    public GameObject Canvas;
    public GameObject Box;

    int x = -5;
    int cnt = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        linerend = master.gameObject.GetComponent<LineRenderer>();

        cnt = FileDataBase.instance.commitfileList.Count - 1;
        x = -5 + (cnt * 3);

        Vector3 pos = new Vector3(x, 0, 0);

        // 頂点を追加。
        linerend.positionCount++;

        // 線を引く場所を指定する
        linerend.SetPosition(cnt, pos);


        GameObject point = FileDataBase.instance.commitfileList[cnt];
        point.gameObject.transform.parent = GameObject.Find("Tree").transform;
        point.transform.localPosition = new Vector3(0.0f, 1.0f, (float)x);
        point.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);

        point.gameObject.layer = LayerMask.NameToLayer("point");

        Canvas.SetActive(false);
        Box.SetActive(false);
    }
}
