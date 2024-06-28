public abstract class BaseState
{
    //Instance of enemy class
    public Enemy enemy;
    //instance of state machine class
    public StateMachine stateMachine;


    public abstract void Enter();
    public abstract void Perform();
    public abstract void Exit();
}