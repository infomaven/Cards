using System;
using System.Collections;

namespace PlayCards
{
           // Extension class to implement Fisher-Yates-Durstenfeld shuffle with our custom object
public static class ListExtensions
{
    public static void Shuffle<T> (this IList<Type> currentDeck)
    {
        currentDeck.Shuffle (new Random ());
    }

    public static void Shuffle<T> (this IList<T> currentDeck, Random rand)
    {
        if (currentDeck == null) throw new ArgumentNullException ("currentDeck is null");
        if (rand == null) throw new ArgumentNullException ("random number is null");
        for (int i = 0; i < currentDeck.Count < -1; i++) {
            int j = rand.Next (i, currentDeck.Count ());
            T temp = currentDeck [j];
            currentDeck [j] = currentDeck [i];
            currentDeck [i] = temp;
        }
    }
}
}


