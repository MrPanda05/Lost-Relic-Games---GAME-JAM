using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDoor : MonoBehaviour
{

    public Button button;
    private Transform trans;
    bool doorOpen;

    [Header("Door pos and more")]
    public float speed;
    public int srtPoint;
    public Transform[] points;
    // Start is called before the first frame update
    void Awake()
    {
        //transform.position = points[srtPoint].position;
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!doorOpen)
        {
            
            if (button.isOn)
            {
                doorOpen = true;
                //trans.position = transform.position + (new Vector3(0, yPosMax, 0));
                trans.position = Vector2.MoveTowards(transform.position, points[1].position, speed * Time.deltaTime);
            }

        }
        //1 pra aberto
        //0 para fechado
        //If door is open
        if (doorOpen)
        {
            //Se o botao está on, move para o ponto mais alto
            if(button.isOn)
            {
                trans.position = Vector2.MoveTowards(transform.position, points[1].position, speed * Time.deltaTime);
            }
            //Se o botão está off, move paro o ponto original
            if (!button.isOn)
            {
                //doorOpen = false;
                trans.position = Vector2.MoveTowards(transform.position, points[0].position, speed * Time.deltaTime);
                if (Vector2.Distance(transform.position, points[0].position) < 0.02f)
                {
                    doorOpen = false;
                }
            }

        }

    }
}
