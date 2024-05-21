namespace Project_ExercisesLogic;

public static class PizzaParty
{
    public static string PizzaCalculationMethod(int nPeopleCount,int nPizzaCount,int nSliceCount)
    {
        int nTotalSlices = nPizzaCount * nSliceCount;
        int nSlicesPerPerson = nTotalSlices / nPeopleCount;
        int nLeftover = nTotalSlices % nPeopleCount;

        return $"{nPeopleCount} people with {nPizzaCount} pizzas\r\nEach person gets {nSlicesPerPerson} pieces of pizza.\r\nThere are {nLeftover} leftover pieces.";
    }
}