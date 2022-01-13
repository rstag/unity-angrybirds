using UnityEngine;

public class CheckBird : MonoBehaviour
{
    private void onMouseDown()
    {
        SpriteRenderer m_SpriteRenderer;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.blue;
    }
}
