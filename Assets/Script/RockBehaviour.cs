using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rock;

    public Vector3 limitUpPosition;

    public Vector3 limitDownPosition;

    private bool isRising;

    public float speed;

    public float timer;

    public float angle;

    private void Awake()
    {
        rock = transform.gameObject;
        isRising = true;
    }

    // Update is called once per frame
    void Update()
    {
        PosSetter();
        timer += Time.deltaTime;
        if (timer > 2){
            timer = 0;
            angle = Random.Range(1,4.6f);
        }
        rock.transform.Rotate(0, angle, 0);
    }

    public void PosSetter()
    {
        if (isRising)
        {
            rock.transform.position = transform.position + new Vector3(0, speed, 0);
        }
        else
        {
            rock.transform.position = transform.position + new Vector3(0, -speed, 0);
        }

        if (rock.transform.position.y >= limitUpPosition.y)
        {
            isRising = false;
        }
        else if (rock.transform.position.y <= limitDownPosition.y)
        {
            isRising = true;
        }
    }
}
