public class AbsorbScorePickUp : PickUpAbsorbtion
{
    public override void AbsorbPickUp()
    {
        ScoreTracker.Instance.ChangeScorePointsByValue(pickUpValue);
    }
}
