# Upcoming Changes

## 2.x Summary

- In the rush to get 2.x out the door I missed including Endianness with some of the extension methods
  and related unit tests. I've found a number of these in my work on 3.0. Many of these fixes and improvements
  have already been back ported to 2.x from 3.0. Others will follow as I find them and will be released in
  2.x well ahead of the 3.0 release.

  _You have my sincerest apologies for these oversights._

## 3.0 Summary

As you've guessed, I'm actively working on v3.0. Some big changes will hit with that release. If you have
any wants from this library please add an issue with your request.

The biggest changes are focused on completeness, simplifying the API surface/reducing volume of code, and
and keeping acceptable performance<sup>1</sup>.

1. One notable exception is a known performance hit caused by simplifying the API surface. It's described in detail
   below.

### Breaking Changes

- I've found myself strongly disliking the proliferation of types. All of the type specific `BitIndexer` and
  `ByteIndexer` types will be replaced with four types: `BigEndianByteIndexer`, `LittleEndianByteIndexer`,
  `BitIndexer`, `ReverseBitIndexer`.
- The old indexer types will be deprecated in an upcoming release of 2.x, shortly before 3.0 is released. If you're
  using them keep in mind that you will need to change over. Consider scoping out the change once the first
  prerelease of 3.0 is published.
- The `IByteIndexer` and `IBitIndexer` interfaces will go away. I'm not using them internally and using them causes
  boxing allocations. Frequent boxing allocations can consume a lot of heap memory. The intended use case for the
  indexers was at the point where bit/byte level access is **required** (i.e. stack allocated).
- For the same reasons as above none of the indexer types will derive from IEnumerable. Instead explicit
  conversion operators will be provided to and from `Span`s and `Array`s.
- To the end of enforcing the indexers stack allocated and used in place, the bit and byte indexer types will become
  `ref structs`. This carries some implications such as making them non-viable as fields and async return types.
  That's in keeping with the original intent and a desirable change, from my view. If you need them to remain
  heap allocatable, add an issue or open a dialog some other way about your needs.
- All extension methods will be moved into type-specific extesion classes (e.g. `UInt64Extensions`). This will
  only break direct calls such as ReadBytesExtensions.ReadBytes(myInt,offset,length,Endian.Big).

### New Features / Improvements

- Byte and bit level indexing of IEEE.754 floating point types: `double` and `float` will be directly provided in 3.0.
  This is currently possible if one first uses BitConverter to convert to the same sized integer type.
  The support for these types will be much more comprehensive than that in 2.0. (e.g. `.SetBits(this float,...)` will
  return a `float` with the specified bits altered)
- Performance improvements via `AggressiveInlining`. In many places in 1.x and 2.x, `AggressiveInlining` is missing.
  Using this consistently has halved and quartered the run time of some of the extension methods in the 3.0 branch.
- Performance benchmarks! I will include both the most recent performance benchmark runs as well as the benchmark
  application in 3.0. In running this I confirmed that the slight performance boost I got going with the
  type specific byte indexers, was not worth the hassle of the volume of code it requires for a .Net standard 2.0
  library. To illustrate (in the 3.0 branch, using my machine):
   - Using `BitConverter` to create an array from any int of any size and reverse the array (big endian on Intel
     processors) is 4ns on .Net 8.0 and 25ns in .Net Framework 4.8.1.
   - Using `BigEndianByteIndexerUInt64` takes rougly 6ns on both .Net 8.0 and 10ns on .Net Framework 4.8.1,
   - Using `BigEndianByteIndexerUInt16` takes roughly 3ns on both .Net 8.0 and 10ns on .Net Framework 4.8.1,
   - The replacement indexers need more logic as they are handling multiple bit sizes. `BigEndianByteIndexer` runs at
     roughly 8ns per conversion of the `UInt64` to an array of bytes.
   - This loss of performance to accomodate easier to maintain code is acceptable for two reasons:
      - In the worst case there's 6ns difference from `BitConverter`, and 5ns from the baseline implementation. 8ns per
        operation at 4GHz is still sufficiently fast for most purposes.
      - The target audience for this library are people who want more readable code. This sometimes comes at a slight
        performance hit. I believe a loss of performance of 6ns per conversion to a big endian array on an Intel
        processor
        is performant enough for the target audience.
      - If you really need as fast of performance as possible in converting integer to and from arrays, you may need to
        roll your own solution tailored to the hardware you're running on. Even `BitConverter` can be less performant
        than hand-rolled solutions for 16 bit integers on my machine.
- Improved documentation. I will improve the documentation on how to properly use the extension methods as well
  as their underlying types. One area currently lacking is on how to expect a big endian conversion from a
  a byte array to behave when the array is smaller than the destination type. (fills from position 0)
- ReSharper auto-formatting updates. Some of the code just looks silly with the settings used in 2.x (main) branch. I
  will update these settings to remove that odd formatting. (This mostly impacts data driven unit tests making it harder
  than necessary to comprehend what's happening)

### Tentative Feature/Addition

- I will investigate .Net 7.0 generic math as a possible way of providing a truly generic implementation.
  (i.e. BigEndianByteIndexer&lt;int&gt; for example.) If this approach proves performant enough, I'll create a
  .net 7.0 version of this library with that support built in. The .Net Standard 2.0 compatible indexers will
  still be provided.
