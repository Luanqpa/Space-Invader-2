using UnityEngine;

public class KirbyMovement : MonoBehaviour
{
    public float KirbyMovementSpeed = 5f; //speeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeed
    private float horizontalInput;
    private int currentX = 0;
    
}

public class KirbyHp : MonoBehaviour
{
    public int kirbyHp = 1;
}

public class KirbyFireRate : MonoBehaviour
{
    public int kirbyFireRate = 3;  // lorsque j'appui sur espace, je tire en continue x balles par sec
}