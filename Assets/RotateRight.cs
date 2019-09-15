using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private GameObject sofa;
    private bool move = false;

    public void setSofa(GameObject s) { sofa = s; }

    public void OnPointerDown(PointerEventData eventData)
    {
        move = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        move = false;
    }

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        if (move)
            sofa.transform.Rotate(Vector3.down);
    }
}
