using UnityEngine;

public class BlinkingObject : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color blueColor = Color.blue;
    private Color yellowColor = Color.yellow;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();

        
        InvokeRepeating("Blink", 0f, 1f);
    }

    private void Blink()
    {
       
        if (objectRenderer.material.color == blueColor)
        {
            objectRenderer.material.color = yellowColor;
        }
        else
        {
            objectRenderer.material.color = blueColor;
        }
    }
}
