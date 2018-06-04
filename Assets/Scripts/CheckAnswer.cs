using UnityEngine;
using System.Collections;

public class CheckAnswer : MonoBehaviour {

    private GameObject mainCube;

    void Start()
    {
        mainCube = GameObject.Find("Main Cube");
    }

    void OnMouseDown()
    {
        if (GetComponent<Renderer>().material.color == mainCube.GetComponent<Renderer>().material.color)
            mainCube.GetComponent<GameController>().next = true;
        else
            mainCube.GetComponent<GameController>().lose = true;
    }
}
