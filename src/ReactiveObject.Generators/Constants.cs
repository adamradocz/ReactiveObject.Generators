﻿namespace ReactiveObject.Generators;

internal static class Constants
{
    public const string Attribute = Header + @"
#if REACTIVEOBJECT_GENERATORS_EMBED_ATTRIBUTES
/// <summary>
/// Add to property to indicate that extension methods should be generated for the type.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Property)]
[System.Diagnostics.Conditional(""REACTIVEOBJECT_GENERATORS_USAGES"")]
public class ReactivePropertyAttribute : System.Attribute
{
}
#endif
";

    public const string Header = @"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ReactiveObject.Generators source generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable";
}
