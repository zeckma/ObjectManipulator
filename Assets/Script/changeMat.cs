using UnityEngine;

public class changeMat : MonoBehaviour
{
	public Material[] materials; // Array material yang bisa di-set dari Inspector
	private Renderer objRenderer;
	private int currentIndex = 0;
	private float timer = 0f;

	void Start()
	{
		objRenderer = GetComponent<Renderer>();

		// Pastikan ada material
		if (materials.Length > 0)
		{
			objRenderer.material = materials[0];
		}
	}

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= 3f)
		{
			// Ganti ke material berikutnya
			currentIndex = (currentIndex + 1) % materials.Length;
			objRenderer.material = materials[currentIndex];

			timer = 0f; // Reset timer
		}
	}
}
