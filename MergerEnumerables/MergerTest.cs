using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace merger
{
  public class MergerTest
  {
    private Merger merger = new Merger();

    [Fact]
    public void Merge_when_first_and_second_are_empty_returns_empty_sequence()
    {
      var first = new int[] {};
      var second = new int[] {};
      var merged = merger.Merge(first, second);
      Assert.Equal(new int[] {}, merged);
    }

    [Fact]
    public void Merge_when_first_is_empty_returns_second_sequence()
    {
      var first = new int[] {};
      var second = new[] {2, 4, 6};
      var merged = merger.Merge(first, second);
      Assert.Equal(second, merged);
    }

    [Fact]
    public void Merge_when_second_is_empty_returns_first_sequence()
    {
      var first = new[] {1, 3, 5};
      var second = new int[] {};
      var merged = merger.Merge(first, second);
      Assert.Equal(first, merged);
    }

    [Fact]
    public void Merge_two_sequences_contain_one_element_each_returns_sequence_contains_two_elements_in_order()
    {
      var first = new[] {1};
      var second = new[] {2};
      var merged = merger.Merge(first, second);
      Assert.Equal(new[] {1, 2}, merged.ToArray());
    }

    [Fact]
    public void Merge_two_sequences_contain_same_element_each_returns_sequence_contains_two_elements()
    {
      var first = new[] {1};
      var second = new[] {1};
      var merged = merger.Merge(first, second);
      Assert.Equal(new[] {1, 1}, merged.ToArray());
    }

    [Fact]
    public void Merge_two_sequences_returns_sequence_contains_all_elements()
    {
      var first = new[] {1, 3, 5};
      var second = new[] {2, 4, 6};
      var merged = merger.Merge(first, second);
      Assert.Equal(new[] {1, 2, 3, 4, 5, 6}, merged.ToArray());
    }

    [Fact]
    public void Merge_one_sequence_with_itself_returns_sequence_contains_doubled_elements()
    {
      var sequence = new[] {1, 2, 3};
      var merged = merger.Merge(sequence, sequence);
      Assert.Equal(new[] {1, 1, 2, 2, 3, 3}, merged.ToArray());
    }

    [Fact]
    public void Merge_three_sequences_returns_sequence_contains_all_elements()
    {
      var first = new[] {1, 4, 7};
      var second = new[] {2, 5, 8};
      var third = new[] {3, 6, 9};
      var merged = merger.Merge(first, second, third);
      Assert.Equal(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, merged.ToArray());
    }
  }
}
