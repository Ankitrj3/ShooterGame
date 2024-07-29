
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,2f);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        GamePlayManager.instance.IncrementScore();
    }
}
