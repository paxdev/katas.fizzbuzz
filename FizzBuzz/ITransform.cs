namespace FizzBuzz;

public interface ITransform 
{
    /* The problem with this solution is that each Transform has to know it should return empty string when there is no match
     * Also the responsibility of applying the transform should happen in one place => refactoring go!
     */
    string Apply(int i);
}