namespace AutoScaleVariables.Demo;

public class PhysicsObject {
	public Mass mass;
	public float drag;

	public Angle3 rotation;
	public Length3 position;
	
	public Velocity3 velocity;
	public Acceleration3 accel;

	public void Update() {
		Force dragForce = Equations.Drag(drag, velocity);
		
		accel -= dragForce;
		
		velocity += accel;
		position += velocity;
	}
}