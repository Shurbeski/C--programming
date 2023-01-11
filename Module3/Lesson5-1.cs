// What if we want to pass a function as a parameter? How does C# handles the callback functions or event handler? The answer is - delegate.
// The delegate is a reference type data type that defines the method signature. You can define variables of delegate, just like other data type, that can refer to any method with the same signature as the delegate.
// There are three steps involved while working with delegates:
// Declare a delegate
// Set a target method
// Invoke a delegate
// A delegate can be declared using the delegate keyword followed by a function signature, as shown below.