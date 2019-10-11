using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class BubbleTexts : MonoBehaviour
{
    public Sprite[] bubbles;
    private Image renderer;
    private RectTransform rect;

    private int timer = 90;
    

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Image>();
        rect = GetComponent<RectTransform>();

        renderer.sprite = bubbles[Random.Range(0, bubbles.Length)];
        renderer.SetNativeSize();

        rect.localPosition = new Vector3(Random.Range(-260,260), Random.Range(-160,160));
    }

    // Update is called once per frame
    void Update()
    {
        timer--;
        if (timer <= 0)
            Destroy(gameObject);
    }
}
