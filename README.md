# Auto-Scale-Variables
I gave variables a measurement scale (km, m, cm) and made them autoconvert to each other, including vector2 and vector3

---
It's fucking easy, '''Meter(1000) + KiloMeter(1)''' results in 2000 in the SI unit, you can read, convert, etc...
<br>Im working now on adding conversion from velocity to position automatically based on deltatime and this shit
<br>Also handles degrees and radians and can use them together

### WIP
- Prevent illegal convertions (ex: Force to Acceleration without providing mass)
- Auto convert from Newtons to m/s (based on specified mass)
- Velocity (m/s) to position (based on deltatime)
- More idunno
