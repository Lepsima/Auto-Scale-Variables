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

/*
   public static Force2 MicroNewton(Vector2 value) {
   	return new Force2(value, 0.000001f);
   }

   public static Force2 MilliNewton(Vector2 value) {
   	return new Force2(value, 0.001f);
   }

   public static Force2 CentiNewton(Vector2 value) {
   	return new Force2(value, 0.01f);
   }

   public static Force2 DeciNewton(Vector2 value) {
   	return new Force2(value, 0.1f);
   }

   public static Force2 Newton(Vector2 value) {
   	return new Force2(value);
   }

   public static Force2 DecaNewton(Vector2 value) {
   	return new Force2(value, 10);
   }

   public static Force2 HectoNewton(Vector2 value) {
   	return new Force2(value, 100);
   }

   public static Force2 KiloNewton(Vector2 value) {
   	return new Force2(value, 1000);
   }

   public static Force2 MegaNewton(Vector2 value) {
   	return new Force2(value, 1000000);
   }

   public static Length2 MicroMeter(Vector2 value) {
   	return new Length2(value, 0.000001f);
   }

   public static Length2 MilliMeter(Vector2 value) {
   	return new Length2(value, 0.001f);
   }

   public static Length2 CentiMeter(Vector2 value) {
   	return new Length2(value, 0.01f);
   }

   public static Length2 DeciMeter(Vector2 value) {
   	return new Length2(value, 0.1f);
   }

   public static Length2 Meter(Vector2 value) {
   	return new Length2(value);
   }

   public static Length2 DecaMeter(Vector2 value) {
   	return new Length2(value, 10);
   }

   public static Length2 HectoMeter(Vector2 value) {
   	return new Length2(value, 100);
   }

   public static Length2 KiloMeter(Vector2 value) {
   	return new Length2(value, 1000);
   }

   public static Length2 MegaMeter(Vector2 value) {
   	return new Length2(value, 1000000);
   }

   public static Velocity2 MicroMeterSecond(Vector2 value) {
   	return new Velocity2(value, 0.000001f);
   }

   public static Velocity2 MilliMeterSecond(Vector2 value) {
   	return new Velocity2(value, 0.001f);
   }

   public static Velocity2 CentiMeterSecond(Vector2 value) {
   	return new Velocity2(value, 0.01f);
   }

   public static Velocity2 DeciMeterSecond(Vector2 value) {
   	return new Velocity2(value, 0.1f);
   }

   public static Velocity2 MeterSecond(Vector2 value) {
   	return new Velocity2(value);
   }

   public static Velocity2 DecaMeterSecond(Vector2 value) {
   	return new Velocity2(value, 10);
   }

   public static Velocity2 HectoMeterSecond(Vector2 value) {
   	return new Velocity2(value, 100);
   }

   public static Velocity2 KiloMeterSecond(Vector2 value) {
   	return new Velocity2(value, 1000);
   }

   public static Velocity2 MegaMeterSecond(Vector2 value) {
   	return new Velocity2(value, 1000000);
   }

   public static Acceleration2 MicroMeterS2(Vector2 value) {
   	return new Acceleration2(value, 0.000001f);
   }

   public static Acceleration2 MilliMeterS2(Vector2 value) {
   	return new Acceleration2(value, 0.001f);
   }

   public static Acceleration2 CentiMeterS2(Vector2 value) {
   	return new Acceleration2(value, 0.01f);
   }

   public static Acceleration2 DeciMeterS2(Vector2 value) {
   	return new Acceleration2(value, 0.1f);
   }

   public static Acceleration2 MeterS2(Vector2 value) {
   	return new Acceleration2(value);
   }

   public static Acceleration2 DecaMeterS2(Vector2 value) {
   	return new Acceleration2(value, 10);
   }

   public static Acceleration2 HectoMeterS2(Vector2 value) {
   	return new Acceleration2(value, 100);
   }

   public static Acceleration2 KiloMeterS2(Vector2 value) {
   	return new Acceleration2(value, 1000);
   }

   public static Acceleration2 MegaMeterS2(Vector2 value) {
   	return new Acceleration2(value, 1000000);
   }
*/