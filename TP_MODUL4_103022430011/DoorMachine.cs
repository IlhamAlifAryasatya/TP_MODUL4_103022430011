public class DoorMachine
{
    private enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        TampilkanState();
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            TampilkanState();
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            TampilkanState();
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    private void TampilkanState()
    {
        if (currentState == State.Terkunci)
        {
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}