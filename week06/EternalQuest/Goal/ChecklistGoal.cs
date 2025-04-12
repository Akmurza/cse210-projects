public override int RecordEvent()
{
    TimesCompleted++;
    if (TimesCompleted >= Target)
    {
        IsComplete = true;
        return Points + Bonus;
    }
    return Points;
}