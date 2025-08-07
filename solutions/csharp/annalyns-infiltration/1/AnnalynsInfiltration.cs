static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return (knightIsAwake == false) ? true : false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake == true) ? true : false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (!archerIsAwake && prisonerIsAwake) ? true : false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {

        return ((petDogIsPresent && !archerIsAwake) || (prisonerIsAwake && !archerIsAwake && !knightIsAwake)) ? true : false;
    }
}
