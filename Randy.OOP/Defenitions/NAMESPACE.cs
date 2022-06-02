namespace Randy.OOP.Defenitions
{
    // More information about namespaces are in: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace
    /*
     *   Namespaces are used to declare a scope that contains a set of related objects.
     *   You can use a namespace to organize code elements and to create globally unique types.
     */
    // ex:
    namespace SampleNamespace
    {
        class SampleClass { }

        interface ISampleInterface { }

        struct SampleStruct { }

        enum SampleEnum { a, b }

        delegate void SampleDelegate(int i);

        namespace Nested
        {
            class SampleClass2 { }
        }
    }

    /*
     *  File scoped namespace declarations enable you to declare that all types in a file are in a single namespace. 
     *  File scoped namespace declarations are available with C# 10. 
     *  File scoped namespaces can't include additional namespace declarations. You cannot declare a nested namespace or a second file-scoped namespace.
     */

    /*
     *  Within a namespace, you can declare zero or more of the following types:
     *      class
     *      interface
     *      struct
     *      enum
     *      delegate
     *      nested namespaces can be declared except in file scoped namespace declarations 
     */
}