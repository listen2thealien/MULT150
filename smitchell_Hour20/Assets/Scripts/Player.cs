using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("References")]
    public GameManager manager;
    public Material normalMat;
    public Material phasedMat;

    [Header("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f;
    public float phaseCooldown = 2f;

    private Renderer mesh;
    private Collider collision;
    private bool canPhase = true;

    private void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        collision = GetComponent<Collider>();
    }

    private void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

        Vector3 position = transform.position;
        position.x += xMove;
        position.x = Mathf.Clamp(position.x, -bounds, bounds);
        transform.position = position;

        if (Input.GetButtonDown("Jump") && canPhase)
        {
            canPhase = false;
            mesh.material = phasedMat;
            collision.enabled = false;

            Invoke(nameof(PhaseIn), phaseCooldown);
        }
    }

    private void PhaseIn()
    {
        canPhase = true;
        mesh.material = normalMat;
        collision.enabled = true;
    }
}