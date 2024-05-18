using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer myRenderer;
    float offset;

    void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Increase offset based on time
        offset += Time.deltaTime * speed;
        // Keep offset between 0 and 1
        if (offset > 1)
            offset -= 1;
        // Apply the offset to the material
        myRenderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}