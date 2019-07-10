using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject scrollbar;
    float scroll_pos = 0;
    float[] post;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        post = new float[transform.childCount];
        float distance = 1f / (post.Length - 1f);
        for (int i = 0; i < post.Length; i++)
        {
            post[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < post.Length; i++)
            {
                if (scroll_pos < post[i] + (distance / 2) && scroll_pos > post[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, post[i], 0.15f);

                }
            }
        }
    }
}
