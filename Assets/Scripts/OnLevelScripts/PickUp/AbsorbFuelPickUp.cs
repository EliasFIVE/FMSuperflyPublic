public class AbsorbFuelPickUp : PickUpAbsorbtion
{
    public override void AbsorbPickUp()
    {
        FuelTracker.Instance.ChangeFuelByValue(pickUpValue);
    }
}
