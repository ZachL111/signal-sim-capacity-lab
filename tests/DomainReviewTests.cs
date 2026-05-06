using SignalSimCapacityLab;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(67, 25, 14, 49);
        if (DomainReviewLens.Score(item) != 166) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
