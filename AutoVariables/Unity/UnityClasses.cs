namespace UnityEngine;

public class Time {
	public static float deltaTime;
	public static float time;
}

public struct Vector2 {
	public float x;
	public float y;

	public Vector2(float x, float y) {
		this.x = x;
		this.y = y;
	}
	
	public static Vector2 operator +(Vector2 l, Vector2 r) {
		return new Vector2 {
			x = l.x + r.x,
			y = l.y + r.y
		};
	}
	
	public static Vector2 operator -(Vector2 l, Vector2 r) {
		return new Vector2 {
			x = l.x - r.x,
			y = l.y - r.y
		};
	}
	
	public static Vector2 operator *(Vector2 l, Vector2 r) {
		return new Vector2 {
			x = l.x * r.x,
			y = l.y * r.y
		};
	}
	
	public static Vector2 operator /(Vector2 l, Vector2 r) {
		return new Vector2 {
			x = l.x / r.x,
			y = l.y / r.y
		};
	}
	
	public static Vector2 operator *(Vector2 l, float r) {
		return new Vector2 {
			x = l.x * r,
			y = l.y * r
		};
	}
	
	public static Vector2 operator /(Vector2 l, float r) {
		return new Vector2 {
			x = l.x / r,
			y = l.y / r
		};
	}
	
	public static Vector2 operator *(float r, Vector2 l) {
		return new Vector2 {
			x = l.x * r,
			y = l.y * r
		};
	}
	
	public static Vector2 operator /(float r, Vector2 l) {
		return new Vector2 {
			x = l.x / r,
			y = l.y / r
		};
	}
}

public struct Vector3 {
	public float x;
	public float y;
	public float z;

	public Vector3(float x, float y, float z) {
		this.x = x;
		this.y = y;
		this.z = z;
	}
	
	public static Vector3 operator +(Vector3 l, Vector3 r) {
		return new Vector3 {
			x = l.x + r.x,
			y = l.y + r.y,
			z = l.z + r.z
		};
	}
	
	public static Vector3 operator -(Vector3 l, Vector3 r) {
		return new Vector3 {
			x = l.x - r.x,
			y = l.y - r.y,
			z = l.z - r.z
		};
	}
	
	public static Vector3 operator *(Vector3 l, Vector3 r) {
		return new Vector3 {
			x = l.x * r.x,
			y = l.y * r.y,
			z = l.z * r.z
		};
	}
	
	public static Vector3 operator /(Vector3 l, Vector3 r) {
		return new Vector3 {
			x = l.x / r.x,
			y = l.y / r.y,
			z = l.z / r.z
		};
	}
	
	public static Vector3 operator *(Vector3 l, float r) {
		return new Vector3 {
			x = l.x * r,
			y = l.y * r,
			z = l.z * r
		};
	}
	
	public static Vector3 operator /(Vector3 l, float r) {
		return new Vector3 {
			x = l.x / r,
			y = l.y / r,
			z = l.z / r
		};
	}
	
	public static Vector3 operator *(float r, Vector3 l) {
		return new Vector3 {
			x = l.x * r,
			y = l.y * r,
			z = l.z * r
		};
	}
	
	public static Vector3 operator /(float r, Vector3 l) {
		return new Vector3 {
			x = l.x / r,
			y = l.y / r,
			z = l.z / r
		};
	}
}