using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
public class MotaAttribute : Attribute
{
    public string Description { get; }

    public MotaAttribute(string description)
    {
        Description = description;
    }
}
