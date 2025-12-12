using UnityEngine;

public class Peggle : MonoBehaviour
{
    public int maxHits;
    public int PointsAwarded;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(maxHits + " hits remaining.");
        maxHits--;
        ScoreManager.Instance.AddScore(PointsAwarded);

        DarkenColor();

        if (maxHits <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Peggle: WAAAHHHH!!");
        }
    }

    private void DarkenColor()
    {
        if (sr != null)
        {
            // Apply a darkening factor, e.g. 90% of previous brightness
            Color c = sr.color;
            sr.color = c * 0.9f; 
        }
    }
}