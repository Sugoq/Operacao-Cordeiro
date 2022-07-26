using UnityEngine;

public class EndPlataform : MonoBehaviour
{
    public float delayForNextLevel;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("P1"))
        {
            Invoke(nameof(CallNextLevel), delayForNextLevel);
        }
    }

    void CallNextLevel() => LevelManager.instance.NextLevel();

}
