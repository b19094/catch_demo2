using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using point;
using OculusSampleFramework;

public class Commit : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "commitfile")
        {
            Canvas.SetActive(true);

            GameObject.Destroy(collision.gameObject.GetComponent<DistanceGrabbable>());
            GameObject.Destroy(collision.gameObject.GetComponent<Rigidbody>());

            //collision.gameObject.layer = LayerMask.NameToLayer("point");
            collision.gameObject.AddComponent<Point>();

            Point point = collision.gameObject.GetComponent<Point>();

            collision.gameObject.AddComponent<EventTrigger>();
            EventTrigger trigger = collision.gameObject.GetComponent<EventTrigger>();
            EventTrigger.Entry entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback.AddListener((eventDate) => { point.OnPointerClick(); });
            trigger.triggers.Add(entry);
        }
        
    }
}
