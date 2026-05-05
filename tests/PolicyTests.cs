using SignalSimCapacityLab;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(79, 79, 20, 11, 4);
        if (Policy.Score(signalcase_1) != 141) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(82, 88, 26, 10, 12);
        if (Policy.Score(signalcase_2) != 158) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(71, 82, 18, 21, 9);
        if (Policy.Score(signalcase_3) != 104) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
