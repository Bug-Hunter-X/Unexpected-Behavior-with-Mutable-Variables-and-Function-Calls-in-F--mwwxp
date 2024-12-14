# F# Mutable Variable Bug

This repository demonstrates a common, yet subtle, bug in F# related to mutable variables and function calls.  The core issue revolves around the difference between passing mutable variables by reference versus creating copies of references with let-bindings. 

## The Bug

The `bug.fs` file contains code that attempts to swap two mutable variables using a function. While the first approach works as expected, the second approach, which uses let-bindings, results in unexpected output because it doesn't modify the original variables.

## The Solution

The `bugSolution.fs` file provides a corrected implementation using byref parameters to ensure that the function directly modifies the original variables.