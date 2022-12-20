Particle Compilation
====================

## Goal

The goal of the particle compilation is to provide a mechanism to get the effective position within a sequence of elements that a new element should be added. Because an XSD defines a potentially complicated pattern by which elements are stored, we need a generalized way to identify where the next element should be added. Particle compilation takes the potentially complicated relationship of children elements and maps it to a collection of paths of type `ParticlePath` that can be retrieved by the type to insert and whose path can be compared with other paths to know if it should be inserted before or after.

## Background

Each element in the SDK is derived from the XSD definitions for OpenXML documents. As part of this, the child elements are defined as particles within the XSD. These particles define the order of child elements within a parent node. For details on the w3 definition of this, see [here](https://www.w3.org/TR/xmlschema11-1/structures.diff-wd.html#cParticles).

The particles within this SDK are of the following types:

- *Element:* Defines the actual child element.
- *Group:* Defines a reuseable group of child elements that are combined into the parent composite particle.
- *Sequence:* Defines a list of items where order matters.
- *All:* Defines a list of items where order does not matter.
- *Choice:* Defines a list of items where only one of them may occur.

These elements are composed through composite particles and will define the children of an element. An example definition of this in the SDK is the following:

```csharp
private static readonly CompiledParticle _constraint = new CompositeParticle(ParticleType.Sequence, 1, 1)
{
    new CompositeParticle(ParticleType.Sequence, 0, 1)
    {
        new CompositeParticle(ParticleType.Choice, 0, 1)
        {
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
        },
        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1)
    }
}.Compile();
```

The `Compile` method will take the `ParticleConstraint` and return a `CompiledParticle`. This contains information for efficient comparison to identify where a new element should be inserted. For this example, the resulting compilation will contain information, similar to the following:

```
(typeof(VisibileButton), [ (Sequence, 0), (Sequence 0), (Choice, 0)])
(typeof(VisibleToggleButton), [ (Sequence, 0), (Sequence 0), (Choice, 1)])
(typeof(UnsizedMenu), [ (Sequence, 0), (Sequence 1)])
```

For each type, there is a path description which flattens the composite particles it takes to reach the element. The offset identifies where in the composite it occurs.

This mapping is used to identify if a given type is before or the other in the collection of items. The logic of this is implemented in `CompiledParticle` and is exposed via the `IComparer<OpenXmlElement>` interface. The important flow is the following:

- If it is within a choice, the other items in the choice need to be removed and replaced with the element
- If it is within a sequence, the element must be placed after the appropriate element
- If it is within an all, the element should be placed at the end of the all

In all these cases, the APIs expose the following methods:

- `Set<TElement>(TElement element)`: Clears out other instances and inserts the supplied element
- `Get<TElement>()`: Returns the first element of the type
- `GetCollection<TElement>()`: Returns a collection scoped to the specific element
