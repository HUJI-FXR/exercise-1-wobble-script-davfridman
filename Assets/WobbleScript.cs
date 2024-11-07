using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WobbleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(Random.Range(-1.5f, 1.5f) * Time.time),
                                              Mathf.Sin(2.01f * Time.time),
                                              Mathf.Sin(Mathf.PI * Time.time));

        transform.localScale = new Vector3(Mathf.Cos(Mathf.Sqrt(Time.time)),
                                           Mathf.Cos(Time.time),
                                           Mathf.Cos(4.34f * Time.time));
        transform.Rotate(3, 6, 9);

        GetComponent<Rigidbody>().mass = Random.Range(0, 1f);
      }
}
