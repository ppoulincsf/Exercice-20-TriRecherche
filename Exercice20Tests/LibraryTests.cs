using Xunit;

namespace Exercice20
{

  public class LibraryTest
  {
    /*
      [Fact]
      [Trait("Category", "BubbleSort")]
      public void BubbleSort_NotEmptyArrayOfNonOrderedValues_OrderedArray ()
      {
        int[] values = { 21, 1, 6, 34, 8 };

        Library.BubbleSort (values);

        Assert.Equal (new[] { 1, 6, 8, 21, 34 }, values);
      }

      
      [Fact]
      [Trait ("Category", "BubbleSort")]
      public void BubbleSort_NotEmptyArrayDuplicates_OrderedArray ()
      {
        int[] values = { 1, 6, 8, 1, 6 };

        Library.BubbleSort (values);

        Assert.Equal (new[] { 1, 1, 6, 6, 8 }, values);
      }

      // A COMPLETER
      // �crivez les tests sp�cifi�s dans l'�nonc�

      [Fact]
      [Trait ("Category", "BubbleSort")]
      public void BubbleSort_NullArray_ThrowsException ()
      {
        Assert.Throws<System.ArgumentException> (() => Library.BubbleSort(null));
      }
  */
    /*
    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_PresentValuesAtDifferentIndexesInEvenNumberOfElementsArray_CorrectIndexes ()
    {
      //Even number of elements
      Assert.Equal (0, Library.LinearSearch (1, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (1, Library.LinearSearch (6, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (2, Library.LinearSearch (8, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (3, Library.LinearSearch (21, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (4, Library.LinearSearch (34, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (5, Library.LinearSearch (38, new int[] { 1, 6, 8, 21, 34, 38 }));
    }
    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_PresentValuesAtDifferentIndexesInOddNumberOfElementsArray_CorrectIndexes ()
    {
      //Odd number of elements
      Assert.Equal (0, Library.LinearSearch (1, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (1, Library.LinearSearch (6, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (2, Library.LinearSearch (8, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (3, Library.LinearSearch (21, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (4, Library.LinearSearch (34, new int[] { 1, 6, 8, 21, 34 }));
    }

    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_NotPresentValuesAtDifferentIndexesInEvenNumberOfElementsArray_MinusOne ()
    {
      //Even number of elements
      Assert.Equal (-1, Library.LinearSearch (0, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (2, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (7, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (15, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (25, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (35, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (-1, Library.LinearSearch (42, new int[] { 1, 6, 8, 21, 34, 38 }));
    }

    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_NotPresentValuesAtDifferentIndexesInOddNumberOfElementsArray_MinusOne ()
    {
      //Odd number of elements
      Assert.Equal (-1, Library.LinearSearch (0, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (-1, Library.LinearSearch (2, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (-1, Library.LinearSearch (7, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (-1, Library.LinearSearch (15, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (-1, Library.LinearSearch (25, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (-1, Library.LinearSearch (42, new int[] { 1, 6, 8, 21, 34 }));
    }

    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_EmptyArray_MinusOne ()
    {
      Assert.Equal (-1, Library.LinearSearch (42, new int[0]));
    }

    [Fact]
    [Trait ("Category", "LinearSearch")]
    public void LinearSearch_NullArray_ThrowsException ()
    {
      Assert.Throws<System.ArgumentException> (() => Library.LinearSearch(0, null));
    }
    */
    /*
    [Fact]
    [Trait ("Category", "BinarySearch")]
    public void BinarySearch_PresentValuesAtDifferentIndexesInEvenNumberOfElementsArray_CorrectIndexes ()
    {
      //Even number of elements
      Assert.Equal (0, Library.BinarySearch (1, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (1, Library.BinarySearch (6, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (2, Library.BinarySearch (8, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (3, Library.BinarySearch (21, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (4, Library.BinarySearch (34, new int[] { 1, 6, 8, 21, 34, 38 }));
      Assert.Equal (5, Library.BinarySearch (38, new int[] { 1, 6, 8, 21, 34, 38 }));
    }

    [Fact]
    [Trait ("Category", "BinarySearch")]
    public void BinarySearch_PresentValuesAtDifferentIndexesInOddNumberOfElementsArray_CorrectIndexes ()
    {
      //Odd number of elements
      Assert.Equal (0, Library.BinarySearch (1, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (1, Library.BinarySearch (6, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (2, Library.BinarySearch (8, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (3, Library.BinarySearch (21, new int[] { 1, 6, 8, 21, 34 }));
      Assert.Equal (4, Library.BinarySearch (34, new int[] { 1, 6, 8, 21, 34 }));
    }

    // A COMPLETER
    // �crivez les tests demand�s dans l'�nonc�


    [Fact]
    [Trait ("Category", "BinarySearch")]
    public void BinarySearch_NullArray_ThrowsException ()
    {
      Assert.Throws<System.ArgumentException> (() => Library.BinarySearch (0, null));
    }
    */
  }
}