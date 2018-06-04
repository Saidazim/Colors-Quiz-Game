using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public Color color, defaultColor;
    public GameObject mainCube;
    private Color lastColor;

    void Start()
    {
        lastColor = mainCube.GetComponent<Renderer>().material.color;
    }

    void Update()
    {
        if (!mainCube.GetComponent<GameController>().lose)
        {
            if (transform.position.x < -8.5f)
                Destroy(gameObject);
            if (transform.position.x < -1.5f)
                GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, color, Time.deltaTime);
            transform.position -= new Vector3(0.03f, 0, 0);
        }

        if (mainCube.GetComponent<Renderer>().material.color != lastColor)
        {
            lastColor = mainCube.GetComponent<Renderer>().material.color;
            transform.position = new Vector3(0, transform.position.y, 0);
            GetComponent<Renderer>().material.color = defaultColor;
        }
    }

    void OnDestroy()
    {
        if (mainCube)
            mainCube.GetComponent<GameController>().lose = true;
    }
}
