using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform posicaoPlayer;
    RaycastHit2D hitUp;
    RaycastHit2D hitDown;
    RaycastHit2D hitRight;
    RaycastHit2D hitLeft;
    public float distanceUpDown, distanceRightLeft;
    public LayerMask layerMask;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        hitUp = Physics2D.Raycast(posicaoPlayer.transform.position, Vector2.up, distanceUpDown, layerMask);
        hitDown = Physics2D.Raycast(posicaoPlayer.position, Vector2.down, distanceUpDown, layerMask);
        hitRight = Physics2D.Raycast(posicaoPlayer.position, Vector2.right, distanceRightLeft, layerMask);
        hitLeft = Physics2D.Raycast(posicaoPlayer.position, Vector2.left, distanceRightLeft, layerMask);
        //Debug.DrawRay(posicaoPlayer.position, Vector2.up * hitUp.point, Color.green);




        SistemaColisaoCamera();
    }

    void SistemaColisaoCamera()
    {

        //Debug.DrawRay(posicaoPlayer.position, Vector2.up * hitUp.distance, Color.red);
        //Debug.DrawRay(posicaoPlayer.position, Vector2.right * hitRight.distance, Color.blue);
        
        if (hitUp.collider == null && hitDown.collider == null)
        {

            transform.position = new Vector2(transform.position.x, posicaoPlayer.position.y);
        }
        if (hitRight.collider == null && hitLeft.collider == null)
        {
            transform.position = new Vector2(posicaoPlayer.position.x, transform.position.y);
        }

        if (hitUp.collider != null)
        {
            Debug.Log("Esta encostando");
        }
    }
}
