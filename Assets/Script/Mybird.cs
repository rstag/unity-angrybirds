using UnityEngine;

public class Mybird : MonoBehaviour
{
    //Color blueColor = new Color(0f, 0f, 1f, 1f);
    private void onMouseDown()
    {
        Debug.Log("on Mouse click");
        GetComponent<SpriteRenderer>().color = Color.red;
        //GetComponent<SpriteRenderer>().color = blueColor;

    }

    private void onKeyDown()
    {
        Debug.Log("on 1");
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    private void onMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
}
