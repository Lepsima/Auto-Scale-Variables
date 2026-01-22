# Auto-Scale-Variables
I gave variables a measurement scale (km, m, cm, N, kN, sec, hour, m/s, km/s, etc) and made them autoconvert to each other
<br> Also conversion between Acceleraion -> Velocity -> Length, Force/Mass/Acceleration and more
<br> The point is that it forces you to use the correct units and types to convert your variables so you make less mistakes

# Included Types and Features
- Dimensions: float / vector2 / vector3 where it makes sense (no vector2 for time for ex)
- Units: Time, Angle, Direction, ForceAccel, Force, Mass, Acceleration, Velocity, Length
- Auto conversions, ex: ```Length += Velocity``` is automatically converted to ```Length += Velocity * Time.deltaTime```
- You can specify the time frame, for ex: ```Length += Velocity.Length(Unit.Seconds(20));```
- Not all interactions between these have been implemented yet, only the most used 

# Code Example
```cs
private Mass mass = Unit.KiloGram(10);

private void ApplyForce(Force force) {
  Acceleration thrust = new(force, mass);
  Direction3 direction = transform.forward();
  Velocity += thrust * direction;
}
```

# Unity Inspector Integration
Includes a special type for most classes with a few common units to select from
<br>You can access these as floats or their base type and the value will automatically scale to the SI unit
<img width="480" height="297" alt="Demo01" src="https://github.com/user-attachments/assets/943821be-f812-4e01-9b84-2f5dc163c99a" />
