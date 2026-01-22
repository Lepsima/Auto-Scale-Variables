# Auto-Scale-Variables
I gave variables a measurement scale (km, m, cm, N, kN, sec, hour, m/s, km/s, etc) and made them autoconvert to each other
<br> Also conversion between Acceleraion -> Velocity -> Length, Force/Mass/Acceleration and more
<br> The point is that it forces you to use the correct units and types to convert your variables so you make less mistakes

# Included Types and Features
- **Dimensions:** float / vector2 / vector3 where it makes sense (no vector2 for time for ex)
- **Units:** Time, Angle, Direction, ForceAccel, Force, Mass, Acceleration, Velocity, Length
- Auto conversions, ex: ```Length += Velocity``` is automatically converted to ```Length += Velocity * Time.deltaTime```
- You can specify the time frame, for ex: ```Length += Velocity.Length(Unit.Seconds(20));```
- Not all interactions between these have been implemented yet, only the most used

# Unity Inspector Integration
Includes a special type for most classes with a few common units to select from
<br>You can access these as floats or their base type and the value will automatically scale to the SI unit
<img width="480" height="297" alt="Demo01" src="https://github.com/user-attachments/assets/943821be-f812-4e01-9b84-2f5dc163c99a" />

# Code Example
Combining **Force** and **Mass** to create acceleration
Applying an **Acceleration** to a **Velocity** automatically (internally using Time.deltaTime, aslo works in FixedUpdate btw)
```cs
private Mass mass = Unit.KiloGram(10);
private Velocity3 velocity = Unit.MeterSecond(0, 0, 0);

private void ApplyForce(Force force) {
  Acceleration thrust = new(force, mass);      // Get acceleration using force * mass
  Direction3 direction = transform.forward();  // Get normalized direction in 3D space

  // Here the everything on the left of the + operation is multiplied by Time.deltaTime
  // Since the operation is taking place between a VELOCITY and an ACCELERATION
  // If it can be converted, the program will take care of it, or ask you extra parameters
  velocity += thrust * direction;              
}
```
Using a built-in drag formula that uses the correct types
```cs
private Mass mass = Unit.Ton(3);     // 3.000.000g
private Magnitude drag = new(0.1);   // Drag coefficient
private Acceleration3 accel = new(); 

private void ApplyDrag() {
  Acceleration3 dragAccel = mass.Drag(velocity, drag); // Built-in drag, takes mass, velocity and drag coefficient 
  accel += dragAccel; // Plain addition here
}
```

## INCORRECT EXAMPLE
Using a position instead of velocity throws an error because a position cannot be converted to a velocity
```cs
private Length3 pos = new();
private Magnitude drag = new(0.1);

//                             ERROR
Acceleration3 WRONG = mass.Drag(pos, drag);
```
