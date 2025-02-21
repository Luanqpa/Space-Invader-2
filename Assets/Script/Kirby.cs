using UnityEngine;

public class KirbyMovement : MonoBehaviour
{
    public float KirbyMovementSpeed = 5f; //speeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeed
    private float horizontalInput;
    private int currentX = 0;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        MoveKirby();
    }

    private void MoveKirby()
    {
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * KirbyMovementSpeed * Time.deltaTime;
        transform.position += movement;
        currentX += (int)horizontalInput;
    }
}


public class KirbyHp : MonoBehaviour
{
    public int kirbyHp = 1;

    public void TakeDamage(int damage)
    {
        
    }



    public void Die()
    {
        Debug.Log("skill issues")
    }
}

public class KirbyFireRate : MonoBehaviour
{
    public int kirbyFireRate = 3;  // lorsque j'appui sur espace, je tire en continue x balles par sec, en vrai jsp
}