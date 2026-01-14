using System;

namespace MetaMystia;

[AttributeUsage(AttributeTargets.Class)]
public sealed class AutoLogAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method)]
public sealed class OnMainThreadAttribute : Attribute { }