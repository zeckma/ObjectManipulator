using UnityEngine;

public class UpDownMotion : MonoBehaviour
{
	float startY;
	float direction = 1f;
	public float speed = 0.5f;
	public float range = 0.5f;

	void Start()
	{
		startY = transform.position.y;
	}

	void Update()
	{
		float newY = transform.position.y + direction * speed * Time.deltaTime;

		if (newY >= startY + range || newY <= startY - range)
		{
			direction *= -1f; // balik arah
		}

		transform.position = new Vector3(transform.position.x, newY, transform.position.z);
	}
}
