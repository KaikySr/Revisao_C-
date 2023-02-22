public class Stack<T>
{
    private T[] lista = new T[10];
    private int topo {get;set;} = -1;
   
    public void Push(T item)
    {
        topo++;
        lista[topo] = item;
    }

    public void Pop()
    {
        if(topo < 0 )
            return;

        lista[topo] = default(T);
        topo--;
    }

    bool IsEmpty()
    {
        if(topo <= 0)
            return true; 
        else
            return false;
    }

    int Size()
    {
        int count = 0;

        foreach(T i in lista)
        {
            count++;
        }

        return count;        
    }

    public void Clear()
    {
        for (int i = 0; i < lista.Count(); i++)
        {
            lista[i] = default(T);
        }

        topo = -1;
    }

    public override string ToString()
    {
        string resultado = "";

        for (int i = topo; i <= 0; i--)
        {
            resultado = $"(i) - ([lista[i]])";
        }

        return resultado;

        // string padrao = "";
        
        // foreach (T i in lista)
        // {
        //     padrao += i?.ToString() + "/n";
        // }

        // return padrao;
    }
}