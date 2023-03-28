using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
    [SerializeField]
    private GameObject fireBreath;
    [SerializeField]
    private Transform mouth;

    private bool isBreathing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            GameObject bigFireBreath = Instantiate(fireBreath, mouth.transform.position, mouth.transform.rotation);
            Destroy(bigFireBreath, 0.6f);
        }
    }
}
