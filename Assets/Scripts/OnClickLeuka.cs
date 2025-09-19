using UnityEngine;
using TMPro;

public class OnClickLeuka : MonoBehaviour
{
        public GameManager gameManager;
        private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();


        if (animator == null)
            Debug.LogWarning("No Animator attached to " + gameObject.name);

        Collider2D collider = GetComponent<Collider2D>();
        if (collider == null)
            Debug.LogWarning("No Collider2D attached to " + gameObject.name);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                Debug.Log("Clicked via Raycast!");
                animator.SetTrigger("PlayAnim");
            }
        }
    }

    void OnMouseDown() // Tähän Vois tehdä Sellasen että siinä Olis Semmonen Ajastin Milloin Voi Klikata Uudelleen
        {
            Debug.Log("Clicked!");
            animator.SetTrigger("PlayAnim");

            if (gameManager != null)
                gameManager.AddPoint();

        }

}
