using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class checkButton : MonoBehaviour {

    bool button_control = false;
    public GameObject check;
    public void pressed(BaseEventData eventData)
    {
        button_control = true;
    }
    public void notpressed(BaseEventData eventData)
    {
        button_control = false;
    }

    // Update is called once per frame
    void Update () {
        if (button_control)
            check.GetComponent<SpriteRenderer>().color = Color.green;
        else
            check.GetComponent<SpriteRenderer>().color = Color.red;

    }
}