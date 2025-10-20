using UnityEngine;

public class Target : MonoBehaviour
{
    public float speed;
    public int pointValue;
    public Vector3 size;

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    public void Hit()
    {
        ScoreManager.Instance.UpdateScore(pointValue);
        Destroy(gameObject);
    }
}