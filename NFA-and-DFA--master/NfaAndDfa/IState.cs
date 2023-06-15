namespace NfaAndDfa
{

    internal interface IState
    {
        string Name { get; }
        bool IsFinal { get; }
    }
}