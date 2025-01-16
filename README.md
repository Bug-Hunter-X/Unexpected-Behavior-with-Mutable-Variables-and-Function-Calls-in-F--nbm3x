# F# Mutable Variables and Function Calls Bug

This example demonstrates an uncommon error in F# related to the use of mutable variables and function calls.  The initial calculation of `z` uses the values of `x` and `y` at the time of the call to `add`. Subsequent changes to `x` and `y` do not update `z`.

This is different from other languages where such changes might reflect immediately, making this a potential source of confusion for programmers new to F#'s immutable nature by default. The example highlights the importance of understanding the immutability of values in F# unless explicitly declared as mutable. 

**To reproduce:** Run the code in `bug.fs`. Notice that `z` remains 30 despite the changes to `x` and `y`. The solution demonstrates how to obtain the desired behavior.
