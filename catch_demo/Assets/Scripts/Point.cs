using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace point {
    public class Point : MonoBehaviour
    {
        private GameObject info;
        private GameObject obj;


        // Start is called before the first frame update
        void Start()
        {
            //親オブジェクトを指定できるようにする
            GameObject tree = GameObject.Find("Tree");
            GameObject canvas = tree.transform.Find("information").gameObject;
            info = canvas.transform.Find("Text").gameObject;

            obj = this.gameObject;
        }

        public void OnPointerClick()
        {
            info.GetComponent<Text>().text = obj.GetComponent<Text>().text;
        }


    }

}
