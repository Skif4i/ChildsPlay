using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovableObject2D : MonoBehaviour
{
    public float speed = 5f; // Скорость перемещения
    public KeyCode upKey = KeyCode.W; // Ключевая кнопка для перемещения вверх
    public KeyCode downKey = KeyCode.S; // Ключевая кнопка для перемещения вниз
    public KeyCode leftKey = KeyCode.A; // Ключевая кнопка для перемещения влево
    public KeyCode rightKey = KeyCode.D; // Ключевая кнопка для перемещения вправо

    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            movement.y += 1;
        }
        if (Input.GetKey(downKey))
        {
            movement.y -= 1;
        }
        if (Input.GetKey(leftKey))
        {
            movement.x -= 1;
        }
        if (Input.GetKey(rightKey))
        {
            movement.x += 1;
        }

        transform.Translate(movement * speed * Time.deltaTime);

        CheckCollisions();
    }

    void CheckCollisions()
    {
        Collider2D collider = GetComponent<Collider2D>();
        if (collider != null)
        {
            Vector2 size = collider.bounds.size;
            Vector2 position = transform.position;

            Collider2D[] hitColliders = Physics2D.OverlapBoxAll(position + new Vector2(-size.x / 2, -size.y / 2), size, 0);
            foreach (Collider2D hitCollider in hitColliders)
            {
                if (hitCollider.gameObject != gameObject && hitCollider.GetType() == typeof(Collider2D))
                {
                    Destroy(gameObject);
                    LoadNewScene();
                    break;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            LoadNewScene();
        }
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
