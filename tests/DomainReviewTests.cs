using BeaconSimInfectionStack;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(43, 41, 22, 73);
        if (DomainReviewLens.Score(item) != 134) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "watch") throw new Exception("domain lane mismatch");
    }
}
